using System.Net;
using DotnetCute.Attributes;

namespace DotnetCute.Exceptions.Http.Client;

[HttpResponseCode(Code = HttpStatusCode.RequestTimeout)]
public class RequestTimeoutException : ResponseException
{
    public RequestTimeoutException(string description, params string[] additional) : base(description, additional)
    {
    }
}