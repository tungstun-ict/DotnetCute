using System.Net;
using dotnet_cute.attributes;

namespace dotnet_cute.exceptions
{
    [HttpResponseCode(Code = HttpStatusCode.BadRequest)]
    public abstract class ResponseException : Exception
    {
        public string Description { get; }
        
        public List<string> Additional { get; }
        
        protected ResponseException(
            string description,
            params string[] additional) : base(description)
        {
            Description = description;
            Additional = additional.ToList();
        }
    }
}