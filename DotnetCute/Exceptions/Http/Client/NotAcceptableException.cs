using System.Net;
using DotnetCute.Attributes;

namespace DotnetCute.Exceptions.Http.Client;

[HttpResponseCode(Code = HttpStatusCode.NotAcceptable)]
public class NotAcceptableException : ResponseException
{
    public NotAcceptableException(string description, params string[] additional) : base(description, additional)
    {
    }
}