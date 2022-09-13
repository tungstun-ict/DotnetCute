using System.Net;
using DotnetCute.Attributes;

namespace DotnetCute.Exceptions.Http.Client;

[HttpResponseCode(Code = HttpStatusCode.PreconditionFailed)]
public class PreconditionFailedException : ResponseException
{
    public PreconditionFailedException(string description, params string[] additional) : base(description, additional)
    {
    }
}