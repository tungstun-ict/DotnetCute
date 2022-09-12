using System.Net;
using DotnetCute.Attributes;

namespace DotnetCute.Exceptions;

[HttpResponseCode(Code = HttpStatusCode.NotFound)]
public class NotFoundException : ResponseException
{
    public NotFoundException(string name, params string[] additional) : base($"{name} not found", additional)
    {
    }
}