using System.Net;
using DotnetCute.Attributes;

namespace DotnetCute.Exceptions.Http.Client;

[HttpResponseCode(Code = HttpStatusCode.RequestedRangeNotSatisfiable)]
public class RangeNotSatisfiableException : ResponseException
{
    public RangeNotSatisfiableException(string description, params string[] additional) : base(description, additional)
    {
    }
}