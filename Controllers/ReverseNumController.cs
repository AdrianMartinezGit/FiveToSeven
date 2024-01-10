using FiveToSeven.Services.ReverseNum;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSeven.Controllers;

[ApiController]
[Route("[controller]")]
public class ReverseNumController : ControllerBase
{
    private readonly IReverseNumService _reverseNumService;

    public ReverseNumController(IReverseNumService reverseNumService)
    {
        _reverseNumService = reverseNumService;
    }

    [HttpGet]
    [Route("ReverseNum/{inputSequence}")]
    public string ReverseNumerical(string inputSequence)
    {
        return _reverseNumService.ReverseNumerical(inputSequence);
    }
}