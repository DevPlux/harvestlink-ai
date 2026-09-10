using Microsoft.AspNetCore.Mvc;

namespace HarvestLink.Api.Controllers;

[ApiController]
[Route("api/v1/health")]
public sealed class HealthController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult GetHealth()
    {
        return Ok(new
        {
            status = "ok",
            service = "HarvestLink API",
            timestamp = DateTime.UtcNow
        });
    }
}