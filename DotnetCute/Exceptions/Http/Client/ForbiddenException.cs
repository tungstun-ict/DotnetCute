using System.Net;
using DotnetCute.Attributes;

namespace DotnetCute.Exceptions.Http.Client;

[HttpResponseCode(Code = HttpStatusCode.Forbidden)]
public class ForbiddenException : ResponseException
{
    public ForbiddenException(string description, params string[] additional) : base(description, additional)
    {
    }
}