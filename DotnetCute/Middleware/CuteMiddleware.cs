using System.Reflection;
using DotnetCute.Attributes;
using DotnetCute.Contracts.Responses;
using DotnetCute.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace DotnetCute.Middleware;

public class CuteMiddleWare
{
    private readonly RequestDelegate _next;
    private readonly CuteOptions _options;
    private readonly ILogger<CuteMiddleWare> _logger;

    public CuteMiddleWare(RequestDelegate next, ILogger<CuteMiddleWare> logger, CuteOptions options = new CuteOptions())
    {
        _next = next;
        _logger = logger;
        _options = options;
    }

    public async Task InvokeAsync(HttpContext httpContext)
    {
        try
        {
            await _next(httpContext);
        }
        catch (ResponseException exception)
        {
            await HandleExceptionAsync(httpContext, exception);
        }
    }

    private async Task HandleExceptionAsync(HttpContext context, ResponseException exception)
    {
        var response = context.Response;

        // Finding the status code attribute
        var exceptionType = exception.GetType();
        var attribute = exceptionType.GetTypeInfo().GetCustomAttribute<HttpResponseCode>();

        // If there is an attribute we set the response status code to the content of the attribute
        if (attribute is not null)
        {
            response.StatusCode = (int) attribute.Code;
        }

        // Assembling the body
        var body = new ErrorResponse
        {
            Error = exceptionType.ShortDisplayName().Replace(nameof(Exception), string.Empty),
            Description = exception.Message,
            Additional = exception.Additional,
        };
        
        // Adding optional parameters
        if(_options.ShowTimeStamp)
            body.Timestamp = DateTime.Now;

        if (_options.ShowStatusCode && attribute != null)
            body.Status = (int) attribute.Code;

        if (_options.ShowPath)
            body.Path = context.Request.Path;

        if (_options.ShowStacktrace)
            body.StackTrace = exception.StackTrace;

        if (_options.ShowLogs)
            _logger.Log(LogLevel.Error, $"[{body.Timestamp}]: [{body.Error}Exception] was thrown. [Status]: {body.Status}, [Description]: {body.Description}, [Path]: {body.Path}");

        // Creating a response
        context.Response.ContentType = "application/json";
        await context.Response.WriteAsync(JsonConvert.SerializeObject(body, Formatting.Indented, new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore
        }));
    }
}