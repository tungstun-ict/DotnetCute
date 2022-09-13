using System.Net;
using DotnetCute.Attributes;

namespace DotnetCute.Exceptions.Http.Client;

[HttpResponseCode(Code = HttpStatusCode.RequestUriTooLong)]
public class UriTooLongException : ResponseException
{
    public UriTooLongException(string description, params string[] additional) : base(description, additional)
    {
    }
}