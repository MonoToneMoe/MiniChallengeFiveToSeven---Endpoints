using MiniChallengeFiveToSeven___Endpoints.Services.MadLib;
using Microsoft.AspNetCore.Mvc;

namespace MiniChallengeFiveToSeven___Endpoints.Controllers;

[ApiController]
[Route("[controller]")]

public class MadLibController : ControllerBase {
    private readonly IMadLibService _madLibService;

    public MadLibController(IMadLibService madLibService)
    {
        _madLibService = madLibService;
    }

    [HttpGet]
    [Route("madlib/{person}/{adj}")]
    public string MadLib(string person, string adj){
        return _madLibService.MadLib(person, adj);
    }
}