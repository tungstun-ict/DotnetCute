using System.Net;
using DotnetCute.Attributes;

namespace DotnetCute.Exceptions.Http.Server;

[HttpResponseCode(Code = HttpStatusCode.LoopDetected)]
public class LoopDetectedException : ResponseException
{
    public LoopDetectedException(string description, params string[] additional) : base(description, additional)
    {
    }
}