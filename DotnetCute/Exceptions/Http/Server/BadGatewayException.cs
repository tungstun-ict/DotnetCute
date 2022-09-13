using System.Net;
using DotnetCute.Attributes;

namespace DotnetCute.Exceptions.Http.Server;

[HttpResponseCode(Code = HttpStatusCode.BadGateway)]
public class BadGatewayException : ResponseException
{
    public BadGatewayException(string description, params string[] additional) : base(description, additional)
    {
    }
}