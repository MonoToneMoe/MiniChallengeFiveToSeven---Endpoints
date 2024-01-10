using MiniChallengeFiveToSeven___Endpoints.Services.ReverseString;
using Microsoft.AspNetCore.Mvc;

namespace MiniChallengeFiveToSeven___Endpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class ReverseStringController : ControllerBase {
    private readonly IReverseStringService _reverseStringService;

    public ReverseStringController(IReverseStringService reverseStringService)
    {
        _reverseStringService = reverseStringService;
    }

    [HttpGet]
    [Route("reversestring/{forwards}")]
    public string ReverseString(string forwards) {
        return _reverseStringService.ReverseString(forwards);
    }
}