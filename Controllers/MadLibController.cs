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
    [Route("madlib/{person}/{adj}/{age}/{place}/{activity}/{personTwo}/{adjTwo}/{ageTwo}/{placeTwo}/{activityTwo}")]
    public string MadLib(string person, string adj, string age, string place, string activity, string personTwo, string adjTwo, string ageTwo, string activityTwo, string placeTwo){
        return _madLibService.MadLib(person, adj, age, place, activity, personTwo, adjTwo, ageTwo, activityTwo, placeTwo);
    }
}