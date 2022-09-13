using System.Net;
using DotnetCute.Attributes;

namespace DotnetCute.Exceptions.Http.Client;

[HttpResponseCode(Code = HttpStatusCode.Gone)]
public class GoneException : ResponseException
{
    public GoneException(string description, params string[] additional) : base(description, additional)
    {
    }
}