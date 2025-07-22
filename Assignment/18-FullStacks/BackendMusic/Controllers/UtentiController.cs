using BackendMusic.Models;
using BackendMusic.Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]

public class UtentiController : ControllerBase
{
    private readonly UtenteService _service;
    public UtentiController(UtenteService service)
    {
        _service = service;
    }

    [HttpGet]
    public ActionResult<List<Utente>> Get()
    {
        List<Utente> utenti = _service.GetAll(); // Da rivedere
        return Ok(utenti);
    }

    [HttpGet("{id}")]
    public ActionResult<Utente> GetByID(int id)
    {
        var utente = _service.GetByID(id);

        if (utente == null)
        {
            return NotFound();
        }

        return Ok(utente);
    }
    [HttpPut("{id}")]
    public ActionResult<Utente> Update(int id, [FromBody] Utente updatedUtente)
    {
        if (updatedUtente == null)
        {
            return BadRequest("Utente non può essere null");
        }

        var utente = _service.Update(id, updatedUtente);
        if (utente == null)
        {
            return NotFound();
        }

        return Ok(utente);
    }

    [HttpPost]
    public ActionResult<Utente> Aggiungi([FromBody] Utente nuovoUtente)
    {
        if (nuovoUtente == null)
        {
            return BadRequest("Utente non può essere null");
        }

        var addedUtente = _service.Aggiungi(nuovoUtente);
        return CreatedAtAction(nameof(Get), new { id = addedUtente.Id }, addedUtente);
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
