using BackendMusic.Models;
using BackendMusic.Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]

public class CanzoneController : ControllerBase
{
    private readonly CanzoneService _service;
    public CanzoneController(CanzoneService service)
    {
        _service = service;
    }

    [HttpGet]
    public ActionResult<List<Canzone>> Get()
    {
        List<Canzone> canzoni = _service.GetAll(); // Da rivedere
        return Ok(canzoni);
    }

    [HttpGet("{id}")]
    public ActionResult<Canzone> GetByID(int id)
    {
        var canzone = _service.GetByID(id);

        if (canzone == null)
        {
            return NotFound();
        }

        return Ok(canzone);
    }
    [HttpPut("{id}")]
    public ActionResult<Canzone> Update(int id, [FromBody] Canzone updatedCanzone)
    {
        if (updatedCanzone == null)
        {
            return BadRequest("Canzone non può essere null");
        }

        var canzone = _service.Update(id, updatedCanzone);
        if (canzone == null)
        {
            return NotFound();
        }

        return Ok(canzone);
    }

    [HttpPost]
    public ActionResult<Canzone> Aggiungi([FromBody] Canzone nuovaCanzone)
    {
        if (nuovaCanzone == null)
        {
            return BadRequest("Canzone non può essere null");
        }

        var addedCanzone = _service.Aggiungi(nuovaCanzone);
        return CreatedAtAction(nameof(Get), new { id = addedCanzone.Id }, addedCanzone);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        try
        {
            _service.Delete(id);
            return NoContent();
        }
        catch (FileNotFoundException)
        {
            return NotFound();
        }
    }
}
