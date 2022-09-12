namespace dotnet_cute.contracts.responses;

public struct ErrorResponse
{
    public string Code { get; set; }
        
    public string Description { get; set; }
        
    public List<string> Additional { get; set; }
}