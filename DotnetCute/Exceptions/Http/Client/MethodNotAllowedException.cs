using System.Net;
using DotnetCute.Attributes;

namespace DotnetCute.Exceptions.Http.Client;

[HttpResponseCode(Code = HttpStatusCode.MethodNotAllowed)]
public class MethodNotAllowedException : ResponseException
{
    public MethodNotAllowedException(string description, params string[] additional) : base(description, additional)
    {
    }
}