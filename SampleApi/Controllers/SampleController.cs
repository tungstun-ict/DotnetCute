using Microsoft.AspNetCore.Mvc;
using SampleApi.Exceptions;

namespace SampleApi.Controllers;

[ApiController]
[Route("[controller]")]
public class SampleController : ControllerBase
{
    private readonly ILogger<SampleController> _logger;

    public SampleController(ILogger<SampleController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Get()
    {
        throw new SampleException("This is a sample!");
    }
}