using Opc.Ua;
using Opc.Ua.Configuration;

namespace IHFood.UaServer
{
    class Program
    {
        private static ApplicationInstance? _applicationInstance;

        static async Task Main(string[] args)
        {
            // Set default path for equipment_tags.conf
            var defaultPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "equipment_tags.conf");
            var configFilePath = args.Length > 0 ? args[0] : defaultPath;

            _applicationInstance = new ApplicationInstance
            {
                ApplicationName = "IHFoodOpcUa-" + System.Net.Dns.GetHostName(),
                ApplicationType = ApplicationType.Server,
                ConfigSectionName = "IHFoodUaServer"
            };

            // Load the application configuration.
            var config = await _applicationInstance.LoadApplicationConfiguration(false).ConfigureAwait(false);

            // Check the application certificate. By default, generate a certificate valid for 25 years
            if (!await _applicationInstance.CheckApplicationInstanceCertificate(false, 0, 300))
            {
                throw new Exception("Application instance certificate invalid!");
            }

            if (!config.SecurityConfiguration.AutoAcceptUntrustedCertificates)
            {
                config.CertificateValidator.CertificateValidation += CertificateValidator_CertificateValidation;
            }

            // Add the IP addresses as alternative, so discovery with IP does not return hostname
            var ipAddresses = GetLocalIpAddresses();
            foreach(var ipAddress in ipAddresses)
                config.ServerConfiguration.AlternateBaseAddresses.Add($"opc.tcp://{ipAddress}:4840/UA/IHFoodOpcUaServer/");
            
            // Start the server.
            var server = new IHFoodUaServer();
            await _applicationInstance.Start(server);

            Console.WriteLine("OPC UA Server started. Available Endpoints:");
            config.ServerConfiguration.BaseAddresses.ForEach(Console.WriteLine);

            // Process the equipment_tags.conf file to add lot variables
            if (File.Exists(configFilePath))
            {
                Console.WriteLine($"Reading configuration from: {configFilePath}");
                try
                {
                    var variableNames = File.ReadAllLines(configFilePath);
                    foreach (var variableName in variableNames)
                    {
                        // Trim each line to avoid leading or trailing whitespace issues
                        string trimmedVariableName = variableName.Trim();
                        if (!string.IsNullOrEmpty(trimmedVariableName))
                        {
                            server.IhFoodNodeManager?.AddNextLotVariable(trimmedVariableName + "_WT");
                            Console.WriteLine($"Added variable: {trimmedVariableName+ "_WT"}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error reading or processing the configuration file: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine($"Configuration file not found at: {configFilePath}");
            }

            Console.WriteLine("Press Ctrl+C to exit...");
            Console.ReadLine();

            // Stop the server
            server.Stop();
        }
        
        private static List<string> GetLocalIpAddresses()
        {
            // Use a network interface to get the local IP address (IPv4) of the machine
            var host = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName());
            var ipAddresses = host.AddressList
                .Where(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                .Select(ip => ip.ToString())
                .ToList();

            return ipAddresses;
        }

        private static void CertificateValidator_CertificateValidation(CertificateValidator validator,
            CertificateValidationEventArgs e)
        {
            if (e.Error.StatusCode != StatusCodes.BadCertificateUntrusted) return;

            if (_applicationInstance.ApplicationConfiguration.SecurityConfiguration.AutoAcceptUntrustedCertificates)
                Console.WriteLine("Accepted Certificate: {0}", e.Certificate.Subject);
            else
                Console.WriteLine("Rejected Certificate: {0}", e.Certificate.Subject);
        }
    }
}