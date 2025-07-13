using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/album")]

public class AlbumController : ControllerBase
{
    private readonly AlbumService _service;
    public AlbumController(AlbumService service)
    {
        _service = service; //?? throw new ArgumentNullException(nameof(service));
    }


    [HttpGet]
    public ActionResult<List<Album>> Get()
    {
        List<Album> Albums = _service.Deserialize();
        return Ok(Albums);
    }


    [HttpGet("{id}")]
    public ActionResult<Album> GetByID(int id)
    {
        var album = _service.GetByID(id);

        if (album == null)
        {
            return NotFound();
        }

        return Ok(album); // This ensures you return 200 with the album object
    }

}