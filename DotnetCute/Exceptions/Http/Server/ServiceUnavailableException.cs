using System.Net;
using DotnetCute.Attributes;

namespace DotnetCute.Exceptions.Http.Server;

[HttpResponseCode(Code = HttpStatusCode.ServiceUnavailable)]
public class ServiceUnavailableException : ResponseException
{
    public ServiceUnavailableException(string description, params string[] additional) : base(description, additional)
    {
    }
}