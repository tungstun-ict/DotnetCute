using System.Net;
using DotnetCute.Attributes;

namespace DotnetCute.Exceptions.Http.Server;

[HttpResponseCode(Code = HttpStatusCode.HttpVersionNotSupported)]
public class HttpVersionNotSupportedException : ResponseException
{
    public HttpVersionNotSupportedException(string description, params string[] additional) : base(description, additional)
    {
    }
}