using MiniChallengeFiveToSeven___Endpoints.Services.OddOrEven;
using Microsoft.AspNetCore.Mvc;

namespace MiniChallengeFiveToSeven___Endpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class OddOrEvenController : ControllerBase {
    private readonly IOddOrEvenService _oddOrEvenService;

    public OddOrEvenController(IOddOrEvenService oddOrEvenService)
    {
        _oddOrEvenService = oddOrEvenService;
    }

    [HttpGet]
    [Route("oddoreven/{num}")]
    public string OddOrEven(string num) {
        return _oddOrEvenService.OddOrEven(num);
    }
}