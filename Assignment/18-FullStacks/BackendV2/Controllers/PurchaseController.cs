using Backend.Models;
using Backend.Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]

public class PurchasesController : ControllerBase
{
    private readonly PurchaseService _service;
    private readonly ProductService _productService;
    private readonly UserService _userService;

    // public PurchasesController(PurchaseService service) => _service = service;

    public PurchasesController(PurchaseService service, ProductService productService, UserService userService)
    {
        _service = service ?? throw new ArgumentNullException(nameof(service));
        _productService = productService ?? throw new ArgumentNullException(nameof(productService));
        _userService = userService ?? throw new ArgumentNullException(nameof(userService));
        // Costruttore è un metodo che a differenza degli altri metodi tipo add remove ecc non c'è bisogno richiamarlo
        // Viene attivato ogni volta che creo un istanza della classe
    }

    [HttpGet]
    // public ActionResult<List<Purchase>> Get() => _service.GetAll();

    public ActionResult<List<PurchaseDTO>> Get() // Metodo accessibile a ogni classe del programma che restituisce la Lista dei prodotti
    {
        // Elenco dei purchases
        List<Purchase> purchases = _service.GetAll();
        // Elenco dei utenti
        List<User> users = _service.GetAll();
        // Elenco dei prodotti
        List<Product> products = _service.GetAll();
        // Creo una lista di PurchaseDTO
        List<PurchaseDTO> result = new List<PurchaseDTO>();
        // Ciclo su ogni acquisto in modo da ottenere lo user e il prodotto assiociati
        foreach (Purchase p in purchases)
        {
            User user = null; // definisco una variabile user inizialmente a null perche non so se esiste
            Product product = null; // definisco una variabile product inizialmente a null per
                                    // cerco l utente associato all'acquisto
            foreach (User u in users)
            {
                if (u.Id == p.UserId) // controllo se l ' ID dell'utente corrisponde a quello dell'acquisto
                {
                    user = u;
                    break;
                }
            }
            // cerco il prodotto associato all'acquisto
            foreach (Product prod in products)
            {
                if (prod.Id == p.ProductId) // controllo se l'ID del prodotto corrisponde a quello dell'acquisto
                {
                    product = prod;
                    break;
                }
            }
            // Costruisco il PurcaseDTO con i dati che ho trovato
            PurchaseDTO dto = new PurchaseDTO
            {
                Id = p.Id,
                UserName = user != null ? user.Name : "Unknown User", // Se l'utente è null, metto "Unknown User"
                ProductName = product != null ? product.Name : "Unknown Product", // Se il prodotto è null, metto "Unknown Product"
                Quantity = p.Quantity,
                PurchaseDate = p.PurchaseDate
            };
            // Aggiungo il DTO alla lista dei risultati
            result.Add(dto);
        }
        // Restituisco la lista dei PurchaseDTO
        return Ok(result); // Ok restituisce 200 OK con il contenuto della risposta
    }



    [HttpGet("{id}")]
    public ActionResult<Purchase> Get(int id)
    {
        var p = _service.GetById(id);
        if (p is null)
        {
            return NotFound();
        }
        return Ok(p);
    }
    // POST api/purchases

    [HttpPost]
    public ActionResult<Purchase> Post([FromBody] Purchase prod)
    {
        // Aggiunge il prodotto e ottiene l istanza creata
        Purchase created = _service.Add(prod);

        // Restituisce 201 Created con un header Location che punta a GET api/purchases/{id}
        return CreatedAtAction(actionName: nameof(Get), // nome dell azione che gestisce la richiesta GET per ottenere un prodotto
        routeValues: new { id = created.Id }, // valori della rotta che includono l ID del prodotto creato
        value: created // il valore restituito è il prodotto creato
        );
    }
    /*
    curl -X POST \
    http://localhost:5102/api/purchases \
    -H "Content-Type: application/json" \
    -d '{"name" : "Matita","price":0.50,"Quantita"}'
    */

    // Metoto update
    // Aggiorna un prodotto esistente in base all' ID
    // 1 - Cerca il prodotto
    // 2 - Se trovato, aggiorna i campi desiderati
    // 3 - Ritorna true se aggiornato, altrimnti false


    /* bash
    curl -X PUT http://localhost:5102/api/purchases \
    -H "Content-Type: application/json" \
    -d '{"id":3,"name":"Matita HB","price":0.60,"Quantita"}'
    */
    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] Purchase prod)
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