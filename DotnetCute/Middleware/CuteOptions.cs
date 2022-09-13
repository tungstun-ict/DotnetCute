namespace DotnetCute.Middleware;

public struct CuteOptions
{
    public bool ShowStatusCode { get; set; }
    public bool ShowTimeStamp { get; set; }
    public bool ShowPath { get; set; }
    public bool ShowStacktrace { get; set; }
    public bool ShowLogs { get; set; }
}