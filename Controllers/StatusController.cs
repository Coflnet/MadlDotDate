using Microsoft.AspNetCore.Mvc;

namespace MadlDotDate.Controllers;

[ApiController]
[Route("[controller]")]
public class StatusController : ControllerBase
{
    private readonly ILogger<StatusController> _logger;

    public StatusController(ILogger<StatusController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "/status")]
    public string Get()
    {
        return "running";
    }
}
