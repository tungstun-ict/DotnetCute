using System.Net;
using DotnetCute.Attributes;

namespace DotnetCute.Exceptions.Http.Server;

[HttpResponseCode(Code = HttpStatusCode.GatewayTimeout)]
public class GatewayTimeoutException : ResponseException
{
    public GatewayTimeoutException(string description, params string[] additional) : base(description, additional)
    {
    }
}