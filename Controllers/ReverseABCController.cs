using FiveToSeven.Services.ReverseABC;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSeven.Controllers;

[ApiController]
[Route("[controller]")]
public class ReverseABCController : ControllerBase
{
    private readonly IReverseABCService _reverseABCService;
    
    public ReverseABCController(IReverseABCService reverseABCService)
    {
        _reverseABCService = reverseABCService;
    }
    
    [HttpGet]
    [Route("ReverseABC/{inputSequence}")]
    public string ReverseAlphanumeric(string inputSequence) {
        return _reverseABCService.ReverseAlphanumeric(inputSequence);
    }
}
