using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
[ApiController]
[Route("api/articles")]
public class ArticlesController : ControllerBase
{
    [HttpGet]
    public IActionResult GetArticles()
    {
        return Ok("Get Articles");
    }
}
