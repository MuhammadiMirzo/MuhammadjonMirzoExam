using Microsoft.AspNetCore.Mvc;
using Services;
namespace Api.Controllers;


[ApiController]
[Route("Api/[controller]")]

public class QuoteController : ControllerBase
{
    private QuoteService _service;
    public QuoteController(QuoteService service)
    {
        _service = service;
    }
    

     [HttpDelete("DeleteQuoteById")]
     public async Task<int> DeleteQuoteById(int id)
     {
         return await _service.DeleteQuoteById(id);
     }
     [HttpGet("GetQuotes")]
    public async Task<List<GetQuotes>> GetQuotes()
    {
        return await _service.GetQuotes();
    }
}
