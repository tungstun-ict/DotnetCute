using System.Net;

namespace dotnet_cute.attributes;

[AttributeUsage(AttributeTargets.Class)]
public class HttpResponseCode : Attribute
{ 
    public HttpStatusCode Code { get; set; }
}
