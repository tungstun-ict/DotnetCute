using System.Net;
using DotnetCute.Attributes;

namespace DotnetCute.Exceptions.Http.Client;

[HttpResponseCode(Code = HttpStatusCode.RequestHeaderFieldsTooLarge)]
public class HeaderFieldsTooLargeException : ResponseException
{
    public HeaderFieldsTooLargeException(string description, params string[] additional) : base(description, additional)
    {
    }
}