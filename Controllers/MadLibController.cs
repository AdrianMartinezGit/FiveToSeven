using FiveToSeven.Services.MadLib;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSeven.Controllers;

[ApiController]
[Route("[controller]")]
public class MadLibController : ControllerBase
{
    private readonly IMadLibService _madLibService;

    public MadLibController(IMadLibService madLibService)
    {
        _madLibService = madLibService;
    }    

    [HttpGet]
    [Route("CreateStory/{place}/{creature}/{pronouns}/{adjective}/{verb}/{adverb}/{noun}/{otherverb}/{othernoun}/{customending}")]
    public string CreateStory(string place, string creature, string pronouns, string adjective, string verb, string adverb, string noun, string otherverb, string othernoun, string customending) {
        return _madLibService.CreateStory(place, creature, pronouns, adjective, verb, adverb, noun, otherverb, othernoun, customending);
    }
}
