using FiveToSeven.Services.OddEven;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSeven.Controllers;

[ApiController]
[Route("[controller]")]
public class OddEvenController : ControllerBase
{
    private readonly IOddEvenService _oddEvenService;

    public OddEvenController(IOddEvenService oddEvenService)
    {
        _oddEvenService = oddEvenService;
    }

    [HttpGet]
    [Route("OddOrEven/{numberInput}")]
    public List<string> OddOrEvenNumber(string numberInput) {
        return _oddEvenService.OddOrEvenNumber(numberInput);
    }
}
