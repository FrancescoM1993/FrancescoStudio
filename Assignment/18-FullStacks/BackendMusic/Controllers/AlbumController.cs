using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]

public class AlbumController : ControllerBase
{
    private readonly AlbumService _service;
    public AlbumController(AlbumService service) => _service = service;

    [HttpGet]
    public ActionResult<List<Album>> Get()
    {
        List<Album> Albums = _service.Deserializza();
        return Ok(Albums);
    }

    [HttpGet("{FileName}")]
    public ActionResult<Album> Get(string FileName)
    {
        System.Console.WriteLine(FileName);
        var p = _service.Deserializza(FileName);
        if (p is null)
        {
            return NotFound();
        }
        return Ok(p);
    }
    [HttpDelete("{FileName}")]
    public IActionResult Delete(string FileName)
    {
        System.Console.WriteLine(FileName);
        bool success = _service.Delete(FileName);
        System.Console.WriteLine(success);
        if (!success)
            return NotFound();

        return NoContent(); // 204
    }

    [HttpPost("{FileName}")]
    public ActionResult<Album> Post([FromBody] Album alb, string FileName)
    {
        Album creaAlbum = _service.Aggiungi(alb , FileName );

        return CreatedAtAction(
            actionName : nameof(Get),
            routeValues: new {alb = creaAlbum },
            value: true
        );
    }
}