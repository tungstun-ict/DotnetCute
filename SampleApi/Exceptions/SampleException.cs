using System.Net;
using DotnetCute.Attributes;
using DotnetCute.Exceptions;

namespace SampleApi.Exceptions;

[HttpResponseCode(Code = HttpStatusCode.NotFound)]
public class SampleException : ResponseException
{
    public SampleException(string description, params string[] additional) 
        : base(description, additional) { }
}