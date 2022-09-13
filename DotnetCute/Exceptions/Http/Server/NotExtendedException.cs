using System.Net;
using DotnetCute.Attributes;

namespace DotnetCute.Exceptions.Http.Server;

[HttpResponseCode(Code = HttpStatusCode.NotExtended)]
public class NotExtendedException : ResponseException
{
    public NotExtendedException(string description, params string[] additional) : base(description, additional)
    {
    }
}