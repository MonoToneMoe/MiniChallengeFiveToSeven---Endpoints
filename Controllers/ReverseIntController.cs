using MiniChallengeFiveToSeven___Endpoints.Services.ReverseInt;
using Microsoft.AspNetCore.Mvc;

namespace MiniChallengeFiveToSeven___Endpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class ReverseIntController : ControllerBase {
    private readonly IReverseIntService _reverseIntService;

    public ReverseIntController(IReverseIntService reverseIntService)
    {
        _reverseIntService = reverseIntService;
    }

    [HttpGet]
    [Route("reverseint/{num}")]
    public string ReverseInt(string num) {
        return _reverseIntService.ReverseInt(num);
    }
}