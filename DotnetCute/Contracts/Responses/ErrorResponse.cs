namespace DotnetCute.Contracts.Responses;

public struct ErrorResponse
{
    public int? Status { get; set; }
    public string Error { get; set; }
        
    public string Description { get; set; }
    
    public List<string> Additional { get; set; }
    
    public DateTime? Timestamp { get; set; }
    
    public string? Path { get; set; }
    
    public string? StackTrace { get; set; }
}