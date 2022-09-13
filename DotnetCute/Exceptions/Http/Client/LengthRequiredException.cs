using System.Net;
using DotnetCute.Attributes;

namespace DotnetCute.Exceptions.Http.Client;

[HttpResponseCode(Code = HttpStatusCode.LengthRequired)]
public class LengthRequiredException : ResponseException
{
    public LengthRequiredException(string description, params string[] additional) : base(description, additional)
    {
    }
}