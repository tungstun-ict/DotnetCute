using System.Net;
using DotnetCute.Attributes;

namespace DotnetCute.Exceptions.Http.Server;

[HttpResponseCode(Code = HttpStatusCode.InsufficientStorage)]
public class InsufficientStorageException : ResponseException
{
    public InsufficientStorageException(string description, params string[] additional) : base(description, additional)
    {
    }
}