using Microsoft.AspNetCore.Mvc;

namespace Interface.Controllers.Behavioral;

[ApiController]
[Route("[controller]")]
public class StrategyController : ControllerBase
{
    public StrategyController()
    {}

    [HttpGet]
    public async Task<IActionResult> GetStrategy() => Ok();
}