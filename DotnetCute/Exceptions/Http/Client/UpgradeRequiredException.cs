using System.Net;
using DotnetCute.Attributes;

namespace DotnetCute.Exceptions.Http.Client;

[HttpResponseCode(Code = HttpStatusCode.UpgradeRequired)]
public class UpgradeRequiredException : ResponseException
{
    public UpgradeRequiredException(string description, params string[] additional) : base(description, additional)
    {
    }
}