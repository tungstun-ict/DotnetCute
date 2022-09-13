using System.Net;
using DotnetCute.Attributes;

namespace DotnetCute.Exceptions.Http.Client;

[HttpResponseCode(Code = HttpStatusCode.ProxyAuthenticationRequired)]
public class ProxyAuthRequiredException : ResponseException
{
    public ProxyAuthRequiredException(string description, params string[] additional) : base(description, additional)
    {
    }
}