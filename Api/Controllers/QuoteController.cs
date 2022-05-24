using Microsoft.AspNetCore.Mvc;
using Services;
namespace Api.Controllers;


[ApiController]
[Route("Api/[controller]")]

public class QuoteController : ControllerBase
{
    private QuoteService _service;
    private IHostEnvironment  _hostEnvironment;
    public QuoteController(QuoteService service, IHostEnvironment hostEnvironment)
    {
        _service = service;
        _hostEnvironment = hostEnvironment;
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
    // [HttpPost("InsertQuote")]


    [HttpPost("InsertFile")]
    public async Task<string> InsertFile(IFormFile file)
    {
        if(file != null)
        {
            var root = _hostEnvironment.ContentRootPath;
            var path = Path.Combine(root, "Uploads", file.FileName);
            using (var fileStream = new FileStream(path,FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }
                return "succes";
        }
        return "failed";
    }
    [HttpPost("InsertFiles")]
    public async Task<string> InsertFiles(List<IFormFile> files)
    {
        if(files.Count > 0 )
        {
           foreach (var fil in files)
           {
                var root = _hostEnvironment.ContentRootPath;
            var path = Path.Combine(root, "Uploads", fil.FileName);
            using (var fileStream = new FileStream(path,FileMode.Create))
            {
                await fil.CopyToAsync(fileStream);
            }
           }
                return "success";
        }
        return "failed";
    }

}
