using ModelContextProtocol.Server;
using System.ComponentModel;

namespace GuidMCPServer.Tools;

internal class GuidCreationTools
{
    [McpServerTool]
    [Description("Generates a new GUID in the format of a version 4 UUID.")]
    public string GetGuidv4()
    {
        return Guid.NewGuid().ToString();
    }

    [McpServerTool]
    [Description("Generates a new GUID in the format of a version 7 UUID.")]
    public string GetGuidv7()
    {
        return Guid.CreateVersion7().ToString();
    }

    [McpServerTool]
    [Description("Generates a new GUID in the format of a version 7 UUID for the given Datetime offset.")]
    public string GetGuidv7ByDateTimeOffset([Description("DateTime Offset of the UUID v7")]DateTimeOffset datetimeOffset)
    {
        return Guid.CreateVersion7(datetimeOffset).ToString();
    }
}
