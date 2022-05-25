using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using topics_api.Models;

namespace topics_api.Controllers;

[ApiController]
[Route("[controller]")]
public class TopicController : ControllerBase
{
  private readonly ILogger<TopicController> _logger;

  public TopicController(ILogger<TopicController> logger)
  {
    _logger = logger;
  }

  [EnableCors("AllowOrigin")]
  [HttpGet(Name = "List")]
  public IEnumerable<TopicItem> List()
  {
    return Enumerable.Range(1, 5).Select(index => new TopicItem()
    {
      Title = $"Oğuz'a Giriş {index}",
      Source = "www.oguzevrensel.com"
    }).ToArray();
  }
}
