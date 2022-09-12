using System.Reflection;
using dotnet_cute.attributes;
using dotnet_cute.contracts.responses;
using dotnet_cute.exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;

namespace dotnet_cute.middleware;

public class CuteMiddleWare
{
    private readonly RequestDelegate _next;

    public CuteMiddleWare(RequestDelegate next, ILogger<CuteMiddleWare> logger)
    {
        _next = next;
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
            response.StatusCode = (int)attribute.Code;
        }

        // Creating a response body
        await context.Response.WriteAsJsonAsync(new ErrorResponse
        {
            Code = exceptionType.ShortDisplayName().Replace(nameof(Exception), string.Empty),
            Description = exception.Message,
            Additional = exception.Additional
        });
    }
}