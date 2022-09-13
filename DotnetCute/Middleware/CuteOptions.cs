namespace DotnetCute.Middleware;

public struct CuteOptions
{
    public bool ShowStatusCode { get; init; }
    public bool ShowTimeStamp { get; init; }
    public bool ShowPath { get; init; }
    public bool ShowStacktrace { get; init; }
    public bool ShowLogs { get; init; }
}