# dotnet-cute
Custom Utility to Throw Exceptions in ASP .NET Core.

## Installation 
```
Install-Package Tungstun.Cute -Version 1.0.0
```

## How to use?
First we need to register the middleware in `Program.cs`.
```cs
// Program.cs

using DotnetCute.Middleware;

app.UseMiddleware<CuteMiddleWare>();
```

After registering, every (custom) exception that inherits from the `ResponseException` class will be caught in the middleware. A custom exception would look like this:

```cs
// SampleException.cs

using DotnetCute.Attributes;
using DotnetCute.Exceptions;

[HttpResponseCode(Code = HttpStatusCode.NotFound)]
public class SampleException : ResponseException
{
    public SampleException(string description, params string[] additional) 
        : base(description, additional) { }
}
```

## License
[GPL-3.0](https://www.gnu.org/licenses/gpl-3.0.nl.html)
[]()
