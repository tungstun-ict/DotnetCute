using System.Net;
using dotnet_cute.attributes;

namespace dotnet_cute.exceptions;

[HttpResponseCode(Code = HttpStatusCode.NotFound)]
public class NotFoundException : ResponseException
{
    public NotFoundException(string name, params string[] additional) : base($"{name} not found", additional)
    {
    }
}