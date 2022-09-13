using System.Net;
using DotnetCute.Attributes;

namespace DotnetCute.Exceptions.Http.Server;

[HttpResponseCode(Code = HttpStatusCode.InternalServerError)]
public class InternalServerErrorException : ResponseException
{
    public InternalServerErrorException(string description, params string[] additional) : base(description, additional)
    {
    }
}