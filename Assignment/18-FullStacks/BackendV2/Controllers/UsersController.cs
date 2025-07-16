using Backend.Models;
using Backend.Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]

public class UsersController : ControllerBase
{
    private readonly UserService _service;

    // public UsersController(UserService service) => _service = service;

    public UsersController(UserService service)
    {
        _service = service ?? throw new ArgumentNullException(nameof(service));
        // Costruttore è un metodo che a differenza degli altri metodi tipo add remove ecc non c'è bisogno richiamarlo
        // Viene attivato ogni volta che creo un istanza della classe
    }

    

    [HttpGet]
    // public ActionResult<List<User>> Get() => _service.GetAll();

    public ActionResult<List<User>> Get() // Metodo accessibile a ogni classe del programma che restituisce la Lista dei prodotti
    {
        List<User> products = _service.GetAll();
        return Ok(products);
        
    }


    [HttpGet("{id}")]
    public ActionResult<User> Get(int id)
    {
        var p = _service.GetById(id);
        if (p is null)
        {
            return NotFound();
        }
        return Ok(p);
    }
    // POST api/products
    
    [HttpPost]
    public ActionResult<User> Post([FromBody] User prod)
    {
        // Aggiunge il prodotto e ottiene l istanza creata
        User created = _service.Add(prod);

        // Restituisce 201 Created con un header Location che punta a GET api/products/{id}
        return CreatedAtAction(actionName: nameof(Get), // nome dell azione che gestisce la richiesta GET per ottenere un prodotto
        routeValues: new { id = created.Id }, // valori della rotta che includono l ID del prodotto creato
        value: created // il valore restituito è il prodotto creato
        );
    }
    /*
    curl -X POST \
    http://localhost:5102/api/products \
    -H "Content-Type: application/json" \
    -d '{"name" : "Matita","price":0.50,"Quantita"}'
    */

    // Metoto update
    // Aggiorna un prodotto esistente in base all' ID
    // 1 - Cerca il prodotto
    // 2 - Se trovato, aggiorna i campi desiderati
    // 3 - Ritorna true se aggiornato, altrimnti false

    
    /* bash
    curl -X PUT http://localhost:5102/api/products \
    -H "Content-Type: application/json" \
    -d '{"id":3,"name":"Matita HB","price":0.60,"Quantita"}'
    */
    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] User prod)
    {
        // Prova ad aggiornare il prodotto
        bool success = _service.Update(id, prod);

        // Se non esiste, restituisco 404 not found
        if (success == false)
        {
            return NotFound();
        }
        else
        {
            // Se l aggiornamento è andato a buon fine, restituisci 204 No Content
            return NoContent();
        }
    }
}