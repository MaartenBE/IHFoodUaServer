# IHFood OPC UA Server - README

## Overview

This repository contains the implementation of an OPC UA server designed for IHFood, which allows communication with Meyn Connect following the OPC UA standard. The server is built using the OPC UA .NET Standard SDK and includes functionality to dynamically load equipment tags from a configuration file (`equipment_tags.conf`) and create variables for each tag in the OPC UA address space. It also provides a clear hook for integrating with the "lot write callback" to handle lot variable updates.
Features


## Features

- **OPC UA Server**: Implements a fully functional OPC UA server with customizable endpoints and security configuration.
- **Dynamic Tag Loading**: Dynamic Tag Loading: Automatically loads equipment tags from a file (equipment_tags.conf) and adds them to the OPC UA address space.
- **Next Lot info callback**: Provides a clear callback (`OnNextLotWriteValue`) for receiving written next lot info, allowing easy integration

## How IHFood Can Integrate the Server

IHFood can integrate the server "as is" without any major modifications. Below are the key integration points and explanations of how the system works:

### 1. **Lot Write Callback Hook**

The server includes a callback method called `OnNextLotWriteValue`, which is responsible for receiving next lot info written to the OPC UA address space. This method will be called whenever Meyn Connect writes next lot info for that equipment tag.


### 2. **equipment_tags.conf File**

The `equipment_tags.conf` file contains a list of equipment tag names, one per line. These tags are automatically read and registered as variables in the OPC UA server. The tags represent equipment-related data points that can be tracked and monitored in the OPC UA server.

#### Example File Format:

```
L1_DEF1_QGS1
L2_DEF2_QGS2
L3_SRT3_QGS3
```

In the above example, each tag represents a Quality Grading System that will be dynamically added to the OPC UA address space. The server will read this file upon startup, and for each tag, it will call the `AddNextLotVariable` method, creating variables in the OPC UA server's address space.

If the file does not exist or is empty, the server will start without adding any tags. You can modify the file or update it dynamically if needed.

### 3. **How to Hook into the Lot Write Logic**

If IHFood needs to execute its own logic to capture next lot info when it is written by Meyn Connect, the logic should be inserted inside the `OnNextLotWriteValue` method. 

```csharp
private static ServiceResult OnNextLotWriteValue(ISystemContext context, NodeState node,
    NumericRange indexRange,
    QualifiedName dataEncoding, ref object value, ref StatusCode statusCode, ref DateTime timestamp)
{
    if (ExtensionObject.ToEncodeable(value as ExtensionObject) is MeynConnectNext newValue)
    {
        // IHFood needs to hook into this callback. It is triggered when next Lot information is received
        Console.WriteLine($"New VersionId written for {node.BrowseName.Name}: {newValue.VersionID}");
        Console.WriteLine($"Next Lot Id: {UnpackLotId(newValue.Next.LotID)}");
        Console.WriteLine($"The next lot name is: {UnpackLotName(newValue.Next.LotName.Name)}");
        // After unpacking IHFood can prepare for the next lot I/O trigger to switch lots
    }
    else
    {
        return StatusCodes.BadTypeMismatch;
    }
    return ServiceResult.Good;
}
```

## How to Run the Server

### Prerequisites

- .NET 6.0 SDK or later
- OPC UA .NET Standard SDK from the OPC Foundation

### Steps to Run

1. **Clone the Repository**:
   Clone this repository to your local machine.

   ```bash
   git clone https://github.com/MaartenBE/IHFoodUaServer.git
   cd IHFoodUaServer
   ```

2. **Edit the Configuration File (Optional)**:
   Open the `equipment_tags.conf` file and add your equipment tag names, one per line. This file is located in the server's root directory.

   ```plaintext
   equipment_tags.conf
   ```

3. **Build the Project**:
   Build the project using the .NET SDK.

   ```bash
   dotnet build
   ```

4. **Run the Server**:
   Run the server with the following command:

   ```bash
   dotnet run
   ```

   The server will start and output the available OPC UA endpoints, which clients can use to connect.

### Configuration Options

- **Default Path for `equipment_tags.conf`**: The server automatically looks for the `equipment_tags.conf` file in the application's root directory. You can provide a different path by passing it as a command-line argument:

  ```bash
  dotnet run "C:\path\to\equipment_tags.conf"
  ```

- **OPC UA Endpoints**: The server's base addresses are configured in the application configuration. By default, the server binds to `opc.tcp://localhost:4840`.

## Server Endpoints

The server exposes multiple OPC UA endpoints depending on your configuration. Upon startup, the server will list the available endpoints in the console. These can include:

- **opc.tcp**: Standard OPC UA binary protocol endpoint.

Clients can use these endpoints to connect to the server and access the equipment tags and lot variables registered in the address space.

### Example Endpoints:

```
OPC UA Server started. Available Endpoints:
opc.tcp://192.168.1.100:4840/UA/IHFoodOpcUaServer
```

## License

This project is licensed under the MIT License. See the `LICENSE` file for details.
