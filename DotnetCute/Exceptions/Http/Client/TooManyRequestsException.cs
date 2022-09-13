using System.Net;
using DotnetCute.Attributes;

namespace DotnetCute.Exceptions.Http.Client;

[HttpResponseCode(Code = HttpStatusCode.TooManyRequests)]
public class TooManyRequestsException : ResponseException
{
    public TooManyRequestsException(string description, params string[] additional) : base(description, additional)
    {
    }
}