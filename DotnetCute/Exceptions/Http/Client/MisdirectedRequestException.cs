using System.Net;
using DotnetCute.Attributes;

namespace DotnetCute.Exceptions.Http.Client;

[HttpResponseCode(Code = HttpStatusCode.MisdirectedRequest)]
public class MisdirectedRequestException : ResponseException
{
    public MisdirectedRequestException(string description, params string[] additional) : base(description, additional)
    {
    }
}