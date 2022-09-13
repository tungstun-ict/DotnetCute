using System.Net;
using DotnetCute.Attributes;

namespace DotnetCute.Exceptions.Http.Client;

[HttpResponseCode(Code = HttpStatusCode.UnsupportedMediaType)]
public class UnsupportedMediaTypeException : ResponseException
{
    public UnsupportedMediaTypeException(string description, params string[] additional) : base(description, additional)
    {
    }
}