using System.Net;
using DotnetCute.Attributes;

namespace DotnetCute.Exceptions.Http.Client;

[HttpResponseCode(Code = HttpStatusCode.Unauthorized)]
public class UnauthorizedException : ResponseException
{
    public UnauthorizedException(string description, params string[] additional) : base(description, additional)
    {
    }
}