using System.Net;
using DotnetCute.Attributes;

namespace DotnetCute.Exceptions.Http.Client;

[HttpResponseCode(Code = HttpStatusCode.PreconditionRequired)]
public class PreconditionRequiredException : ResponseException
{
    public PreconditionRequiredException(string description, params string[] additional) : base(description, additional)
    {
    }
}