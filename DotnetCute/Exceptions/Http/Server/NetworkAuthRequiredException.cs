using System.Net;
using DotnetCute.Attributes;

namespace DotnetCute.Exceptions.Http.Server;

[HttpResponseCode(Code = HttpStatusCode.NetworkAuthenticationRequired)]
public class NetworkAuthRequiredException : ResponseException
{
    public NetworkAuthRequiredException(string description, params string[] additional) : base(description, additional)
    {
    }
}