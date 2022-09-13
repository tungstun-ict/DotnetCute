using System.Net;
using DotnetCute.Attributes;

namespace DotnetCute.Exceptions.Http.Client;

[HttpResponseCode(Code = HttpStatusCode.ExpectationFailed)]
public class ExpectationFailedException : ResponseException
{
    public ExpectationFailedException(string description, params string[] additional) : base(description, additional)
    {
    }
}