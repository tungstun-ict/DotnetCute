using System.Net;
using DotnetCute.Attributes;

namespace DotnetCute.Exceptions.Http.Client;

[HttpResponseCode(Code = HttpStatusCode.Locked)]
public class LockedException : ResponseException
{
    public LockedException(string description, params string[] additional) : base(description, additional)
    {
    }
}