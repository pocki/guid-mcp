# GUID MCP Server

Model Context Protocol (MCP) server that generates a new Guid (v4, v7).

## Using the MCP Server from NuGet.org

Once the MCP server package is published to NuGet.org, you can configure it in your preferred IDE. Both VS Code and Visual Studio use the `dnx` command to download and install the MCP server package from NuGet.org.


> **ℹ️ INFO:** `dnx` is part of .NET SDK 10 (preview).  
Install .NET SDK 10 (currently in preview) to use the MCP server via nuget package directly. You can download it from the [.NET SDK download page](https://dotnet.microsoft.com/download/dotnet/10.0).


- **VS Code**: Create a `<WORKSPACE DIRECTORY>/.vscode/mcp.json` file
- **Visual Studio**: Create a `<SOLUTION DIRECTORY>\.mcp.json` file

For both VS Code and Visual Studio, the configuration file uses the following server definition:

```json
{
  "servers": {
    "GuidMCPServer": {
      "type": "stdio",
      "command": "dnx",
      "args": [
        "pock-programming.guid-mcp",
        "--yes"
      ]
    }
  }
}
```

## Developing locally

To test this MCP server from source code (locally) without using a built MCP server package, you can configure your IDE to run the project directly using `dotnet run`.

```json
{
  "servers": {
    "GuidMCPServer": {
      "type": "stdio",
      "command": "dotnet",
      "args": [
        "run",
        "--project",
        "./GuidMCPServer/"
      ]
    }
  }
}
```

## Testing the MCP Server

Once configured, you can ask Copilot Chat for a Guid, for example, `Get me a new Guid`. It should prompt you to use the `get_guidv4` tool on the `GuidMCPServer` MCP server and show you the results.

## More information


.NET MCP servers use the [ModelContextProtocol](https://www.nuget.org/packages/ModelContextProtocol) C# SDK. For more information about MCP:

- [Official Documentation](https://modelcontextprotocol.io/)
- [Protocol Specification](https://spec.modelcontextprotocol.io/)
- [GitHub Organization](https://github.com/modelcontextprotocol)

Refer to the VS Code or Visual Studio documentation for more information on configuring and using MCP servers:

- [Use MCP servers in VS Code (Preview)](https://code.visualstudio.com/docs/copilot/chat/mcp-servers)
- [Use MCP servers in Visual Studio (Preview)](https://learn.microsoft.com/visualstudio/ide/mcp-servers)
