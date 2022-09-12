using System.Net;
using DotnetCute.Attributes;

namespace DotnetCute.Exceptions;

[HttpResponseCode(Code = HttpStatusCode.BadRequest)]
public abstract class ResponseException : Exception
{
    public string Description { get; }
        
    public List<string> Additional { get; }
        
    protected ResponseException(
        string description,
        params string[] additional) : base(description)
    {
        Description = description;
        Additional = additional.ToList();
    }
}