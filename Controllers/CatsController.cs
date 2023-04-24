
namespace cSharpDayOne.Controllers;

[ApiController]
[Route("api/cats")]
public class CatsController : ControllerBase
{
  private readonly CatsService _catsService;

  public CatsController(CatsService catsService)
  {
    _catsService = catsService;
  }

  [HttpGet]
  public ActionResult<List<Cat>> Get()
  {
    try
    {
      List<Cat> cats = _catsService.Get();
      return Ok(cats);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }

  }

  [HttpGet("{catId}")]
  public ActionResult<Cat> GetOne(int catId)
  {
    try
    {
      Cat cat = _catsService.GetOne(catId);
      return Ok(cat);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpPost]
  public ActionResult<Cat> Create([FromBody] Cat catData)
  {
    try
    {
      Cat cat = _catsService.Create(catData);
      return Ok(cat);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpDelete("{catId}")]
  public ActionResult<string> Remove(int catId)
  {
    try
    {
      string message = _catsService.Remove(catId);
      return Ok(message);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
}
