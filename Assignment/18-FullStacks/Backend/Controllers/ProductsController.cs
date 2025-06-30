using Backend.Models;
using Backend.Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]

public class ProductsController : ControllerBase
{
    private readonly ProductService _service;

    // public ProductsController(ProductService service) => _service = service;

    [HttpGet]
    // public ActionResult<List<Product>> Get() => _service.GetAll();

    public ActionResult<List<Product>> Get() // Metodo accessibile a ogni classe del programma che restituisce la Lista dei prodotti
    {
        List<Product> products = _service.GetAll();
        return Ok(products);
    }


    [HttpGet("{id}")]
    public ActionResult<Product> Get(int id)
    {
        var p = _service.GetById(id);
        if (p is null)
        {
            return NotFound();
        }
        return p;
    }
    // POST api/products
    
    [HttpPost]
    public ActionResult<Product> Post([FromBody] Product prod)
    {
        // Aggiunge il prodotto e ottiene l istanza creata
        Product created = _service.Add(prod);

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
    -d '{"name" : "Matita","price":0.50}'
    */

    // Metoto update
    // Aggiorna un prodotto esistente in base all' ID
    // 1 - Cerca il prodotto
    // 2 - Se trovato, aggiorna i campi desiderati
    // 3 - Ritorna true se aggiornato, altrimnti false

    
    /* bash
    curl -X PUT http://localhost:5102/api/products \
    -H "Content-Type: application/json" \
    -d '{"id":3,"name":"Matita HB","price":0.60}'
    */
    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] Product prod)
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