namespace DotnetCute.Contracts.Responses;

public struct ErrorResponse
{
    public string Code { get; set; }
        
    public string Description { get; set; }
        
    public List<string> Additional { get; set; }
}