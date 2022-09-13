using System.Net;
using DotnetCute.Attributes;

namespace DotnetCute.Exceptions.Http.Client;

[HttpResponseCode(Code = HttpStatusCode.UnavailableForLegalReasons)]
public class UnavailableForLegalReasonsException : ResponseException
{
    public UnavailableForLegalReasonsException(string description, params string[] additional) : base(description, additional)
    {
    }
}