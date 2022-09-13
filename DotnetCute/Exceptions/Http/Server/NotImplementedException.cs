using System.Net;
using DotnetCute.Attributes;

namespace DotnetCute.Exceptions.Http.Server;

[HttpResponseCode(Code = HttpStatusCode.NotImplemented)]
public class NotImplementedException : ResponseException
{
    public NotImplementedException(string description, params string[] additional) : base(description, additional)
    {
    }
}