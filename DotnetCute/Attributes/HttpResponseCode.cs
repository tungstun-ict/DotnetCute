using System.Net;

namespace DotnetCute.Attributes;

[AttributeUsage(AttributeTargets.Class)]
public class HttpResponseCode : Attribute
{ 
    public HttpStatusCode Code { get; set; }
}
