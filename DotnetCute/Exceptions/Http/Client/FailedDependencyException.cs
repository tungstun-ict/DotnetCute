using System.Net;
using DotnetCute.Attributes;

namespace DotnetCute.Exceptions.Http.Client;

[HttpResponseCode(Code = HttpStatusCode.FailedDependency)]
public class FailedDependencyException : ResponseException
{
    public FailedDependencyException(string description, params string[] additional) : base(description, additional)
    {
    }
}