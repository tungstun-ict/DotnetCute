using System.Net;
using DotnetCute.Attributes;

namespace DotnetCute.Exceptions.Http.Client;

[HttpResponseCode(Code = HttpStatusCode.PaymentRequired)]
public class PaymentRequiredException : ResponseException
{
    public PaymentRequiredException(string description, params string[] additional) : base(description, additional)
    {
    }
}