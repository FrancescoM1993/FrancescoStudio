using BackendMusic.Models;
using BackendMusic.Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]

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

    [HttpGet("{id}/canzoni")]
    public ActionResult<List<Canzone>> GetCanzoniByAlbumID(int id)
    {
        var canzoni = _service.GetCanzoniByAlbumID(id);

        if (canzoni == null || !canzoni.Any())
        {
            return NotFound();
        }

        return Ok(canzoni);
    }

    [HttpPost]
    public ActionResult<Album> Aggiungi([FromBody] Album nuovoAlbum)
    {
        if (nuovoAlbum == null)
        {
            return BadRequest("Album non può essere null");
        }

        var addedAlbum = _service.Aggiungi(nuovoAlbum);
        return CreatedAtAction(nameof(Get), new { id = addedAlbum.Id }, addedAlbum);
    }
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        try
        {
            _service.Delete(id);
            return NoContent(); // 204 No Content
        }
        catch (FileNotFoundException)
        {
            return NotFound(); // 404 Not Found
        }
    }
    
}