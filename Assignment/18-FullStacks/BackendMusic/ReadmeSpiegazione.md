# Album Manager

## Indice
- [Descrizione](#descrizione)
- [Struttura del progetto](#struttura-del-progetto)
- [Funzionalità principali](#funzionalità-principali)
- [Come usare](#come-usare)
- [Models](#models)
  - [Album.cs](#albumcs)
  - [Canzone.cs](#canzonecs)
  - [Utente.cs](#utentecs)
  - [InformazioniUtente.cs](#informazioninutente)
- [AlbumService.cs](#albumservicecs)
- [AlbumController.cs](#albumcontrollerscs)
  - [Route `api/album`](#route-apialbum)
  - [Route `api/album/{id}`](#route-apialbumid)
  - [Route `api/album/{id}/canzoni`](#route-apialbumidcanzoni)
  - [Route POST `api/album`](#route-post-apialbum)
  - [Route DELETE `api/album/{id}`](#route-delete-apialbumid)
  - [Route `api/utenti`](#route-apiutenti)
  - [Route `api/utenti/{id}`](#route-apiutenti)
  - [Route POST `api/utenti`](#route-post-apiutenti)
  - [Route DELETE `api/utenti`](#route-delete-apiutenti)
## Descrizione
Applicazione per gestire un archivio di album musicali e relative canzoni salvate in un file JSON.

## Struttura del progetto
Il progetto è organizzato in tre principali componenti:

- Model: contiene le classi `Album` e `Canzone` che rappresentano la struttura dei dati.
- Service: contiene la classe `AlbumService` che si occupa di leggere/scrivere i dati su file JSON e di fornire
  metodi per operazioni CRUD sugli album.
- Controller: Gestisce la comunicazione tra utente e service usando la classe controllerbase `ControllerBase`.

## Funzionalità principali

- Caricamento lista album dal file JSON (`Deserialize()`).
- Recupero di tutti gli album (`GetAll()`).
- Ricerca album per ID (`GetByID(int id)`) o per nome (`GetByName(string nome)`).
- Aggiunta di un nuovo album e salvataggio su file (`Aggiungi(Album nuovoAlbum)`).
- Eliminazione di un album (`Delete(int id)`).
- Recupero delle canzoni associate a un album (`GetCanzoniByAlbumID(int id)`).

## Come usare

1. Creare un'istanza di `AlbumService`, specificando eventualmente il percorso del file JSON.
2. Usare i metodi messi a disposizione (`GetAll()`, `GetByID()`, etc.).
3. Le modifiche agli album aggiornano automaticamente il file JSON.

## Tecnologie usate

- C#
- Newtonsoft.Json per la serializzazione/deserializzazione JSON
- File system per la persistenza dati
- using Microsoft.AspNetCore.Mvc; per la gestione dei controller

## Models

### Album.cs
```c#
namespace BackendMusic.Models
{
    public class Album
    {
    public int Id { get; set; }
    public string Titolo { get; set; }
    public int Anno { get; set; }
    public string Autore { get; set; }
    public List<Canzone> Canzoni { get; set; }
    public string Genere { get; set; }
    public bool Ascoltato { get; set; }
    }
}
```
### Spiegazione Album.cs
La classe `Album` rappresenta un album musicale con le seguenti proprietà:
- `Id`: Identificatore univoco dell'album.
- `Titolo`: Titolo dell'album.
- `Anno`: Anno di pubblicazione dell'album.
- `Autore`: Nome dell'autore dell'album.
- `Canzoni`: Elenco delle canzoni presenti nell'album.
- `Genere`: Genere musicale dell'album.
- `Ascoltato`: Indica se l'album è stato ascoltato.

### Canzone.cs
```c#
public class Canzone
{
    public int Id { get; set; }
    public string Titolo { get; set; }
    public string Durata { get; set; }
    public string Artista { get; set; }
}
```
### Spiegazione Canzone.cs
La classe `Canzone` rappresenta una canzone con le seguenti proprietà:
- `Id`: Identificatore univoco della canzone.
- `Titolo`: Titolo della canzone.
- `Durata`: Durata della canzone.
- `Artista`: Nome dell'artista della canzone.

### Utente.cs
```c#
namespace BackendMusic.Models
{
    public class Utente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public InformazioniUtente informazioniUtente { get; set; }
    }
}
```
### Spiegazione Utente.cs
La classe `Utente` rappresenta un utente del sistema con le seguenti proprietà:
- `Id`: Identificatore univoco dell'utente.
- `Nome`: Nome dell'utente.
- `Cognome`: Cognome dell'utente.
- `InformazioniUtente`: Oggetto contenente informazioni aggiuntive sull'utente.

### InformazioniUtente.cs
```c#
   public class InformazioniUtente
    {
        public string Email { get; set; }
        public string Indirizzo { get; set; }
        public string Citta { get; set; }
        public int Cap { get; set; }
    }

```
### Spiegazione InformazioniUtente.cs
La classe `InformazioniUtente` contiene informazioni di contatto dell'utente:
- `Email`: Indirizzo email dell'utente.
- `Indirizzo`: Indirizzo fisico dell'utente.
- `Citta`: Città di residenza dell'utente.
- `Cap`: Codice di avviamento postale dell'utente.

### AlbumService.cs

```c#
using BackendMusic.Models;
using Newtonsoft.Json;

namespace BackendMusic.Services
{
    public class AlbumService
    {
        private readonly string _percorsoAlbumFile; // Path privato di sola lettura del file JSON contenente gli album
        private List<Album> _album = new List<Album>(); // Lista privata contenente gli albums, inizializzata vuota e successivamente popolata 

        // Costruttore che inizializza il percorso del file JSON e carica gli album
        // Utilizza un file di configurazione per ottenere il percorso del file JSON
        public AlbumService(string percorsoAlbumFile = "Json/Album.json")
        {
            // Inizializza il percorso del file JSON da un file di configurazione
            _percorsoAlbumFile = "config.txt";
            string[] righe = File.ReadAllLines(_percorsoAlbumFile);
            _percorsoAlbumFile = righe[0];

            // Controlla se il file esiste, altrimenti lancia un'eccezione
            if (!File.Exists(_percorsoAlbumFile))
                throw new FileNotFoundException("File non trovato", _percorsoAlbumFile);

            var json = File.ReadAllText(_percorsoAlbumFile);
            var elenco = JsonConvert.DeserializeObject<List<Album>>(json);
            _album = elenco ?? new List<Album>();
        }

        // Metodo per deserializzare il file JSON con controllo dell'esistenza del file
        public List<Album> Deserialize()
        {
            if (!File.Exists(_percorsoAlbumFile))
            {
                // questo metodo mi permette di gestire l'eccezione
                throw new FileNotFoundException("File non trovato", _percorsoAlbumFile);
            }

            var json = File.ReadAllText(_percorsoAlbumFile);
            // Deserializzo contenuto in una lista di oggetti di tipo album sulla variabile elenco
            var elenco = JsonConvert.DeserializeObject<List<Album>>(json);
            return elenco ?? new List<Album>();
        }

        // Metodo per ottenere gli album
        public List<Album> GetAll()
        {
            _album = Deserialize(); // Deserializzo il file JSON per ottenere la lista degli album e lo ritorna
            return _album;
        }
        // Metodo per ottenere un album tramite ID
        public Album GetByID(int id)
        {
            var albumList = Deserialize(); // Deserializzo il file JSON per ottenere la lista degli album
            return albumList.FirstOrDefault(a => a.Id == id); // Ritorna il primo album che corrisponde all'ID specificato
        }
        // Metodo per ottenere un album tramite nome
        public Album GetByName(string nome)
        {
            var albumList = Deserialize(); // Deserializzo il file JSON per ottenere la lista degli album
            return albumList.FirstOrDefault(a => a.Titolo.Equals(nome, StringComparison.OrdinalIgnoreCase)); // Ritorna il primo album corrispondente al Titolo specificato
        }
        // Metodo per aggiungere un nuovo album
        public Album Aggiungi(Album nuovoAlbum)
        {
            var elenco = Deserialize(); // Deserializzo il file JSON per ottenere la lista degli album
            // Se riceve dal Body un id == 0 allora ne genera uno nuovo univoco
            if (nuovoAlbum.Id == 0)
            {
                // Genera un nuovo ID univoco
                // Controlla se la lista è vuota, altrimenti prende il massimo ID esistente e aggiunge 1 altrimenti mette 1
                // Any è un metodo LINQ che verifica se la lista contiene elementi
                int nuovoId = elenco.Any() ? elenco.Max(a => a.Id) + 1 : 1; 
                nuovoAlbum.Id = nuovoId;
            }
            elenco.Add(nuovoAlbum);
            var json = JsonConvert.SerializeObject(elenco, Formatting.Indented);
            File.WriteAllText(_percorsoAlbumFile, json);
            return nuovoAlbum;
        }
        // Metodo per trovare le canzoni tramite un id all'interno di un album
        public List<Canzone> GetCanzoniByAlbumID(int id)
        {
            var album = GetByID(id);
            return album?.Canzoni ?? new List<Canzone>(); // Ritorna la lista di canzoni dell'album oppure ritorna una lista vuota se l'album non esiste
        }
        // Metodo per eliminare un album
        public void Delete(int id)
        {
            var albumList = Deserialize(); // Deserializzo il file JSON per ottenere la lista degli album
            var albumToRemove = albumList.FirstOrDefault(a => a.Id == id);
            // Se l'album da rimuovere esiste nella lista
            if (albumToRemove != null)
            {
                // Rimuove l'album dalla lista
                albumList.Remove(albumToRemove);
                var json = JsonConvert.SerializeObject(albumList, Formatting.Indented);
                File.WriteAllText(_percorsoAlbumFile, json);
            }
        }
    }
}
```
### AlbumControllers.cs
```c#
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
```

### Route `api/album`
Route `api/album`: Restituisce la lista di tutti gli album. 

```c#
[HttpGet]
    public ActionResult<List<Album>> Get()
    {
        List<Album> Albums = _service.Deserialize();
        return Ok(Albums);
    }
```

### Route `api/album/{id}`
Route `api/album/{id}`: Restituisce un album specifico in base all'ID. Se l'album non esiste, restituisce un errore 404 Not Found.
```c#
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
```
### Route `api/album/{id}/canzoni`
Route `api/album/{id}/canzoni`: Restituisce le canzoni associate a un album specifico in base all'ID. Se l'album non esiste o non ha canzoni, restituisce un errore 404 Not Found.
```c#
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
```
### Route POST `api/album`
Route POST `api/album`: Aggiunge un nuovo album. Se il corpo in POST è vuoto allora ritorna una risposta 400 altrimenti crea l'album
```c#
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
```

### Route DELETE `api/album/{id}`
Route DELETE `api/album/{id}`: Cancella un Album tramite ID. Se va a buon fine ritorna una risposta 204, altrimenti manda una risposta 404
```c#
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
```

## UtenteService.cs

```c#

using BackendMusic.Models;
using Newtonsoft.Json;

namespace BackendMusic.Services
{
    public class UtenteService
    {
        private readonly string _percorsoUtenteFile;  // Path privato di sola lettura del file JSON contenente gli utenti
        private List<Utente> _utenti = new List<Utente>(); // Lista privata contenente gli utenti, inizializzata vuota e successivamente popolata 

        // Costruttore che inizializza il percorso del file JSON e carica gli album
        // Utilizza un file di configurazione per ottenere il percorso del file JSON
        public UtenteService(string percorsoUtenteFile = "Json/Utenti.json")
        {
            // Inizializza il percorso del file JSON da un file di configurazione
            _percorsoUtenteFile = "config.txt";
            string[] righe = File.ReadAllLines(_percorsoUtenteFile);
            _percorsoUtenteFile = righe[1];

            // Controlla se il file esiste, altrimenti lancia un'eccezione
            if (!File.Exists(_percorsoUtenteFile))
                throw new FileNotFoundException("File non trovato", _percorsoUtenteFile);

            var json = File.ReadAllText(_percorsoUtenteFile);
            var elenco = JsonConvert.DeserializeObject<List<Utente>>(json);
            _utenti = elenco ?? new List<Utente>();
        }

        // Metodo per deserializzare il file JSON con controllo dell'esistenza del file
        public List<Utente> Deserialize()
        {
            string percorsoUtenteFile = "Json/Utenti.json";

            if (!File.Exists(percorsoUtenteFile))
            {
                // questo metodo mi permette di gestire l'eccezione
                throw new FileNotFoundException("File non trovato", percorsoUtenteFile);
            }

            var json = File.ReadAllText(percorsoUtenteFile);
            // Deserializzo contenuto in una lista di oggetti di tipo utente sulla variabile elenco
            var elenco = JsonConvert.DeserializeObject<List<Utente>>(json);
            return elenco ?? new List<Utente>();
        }

        // Metodo per ottenere gli utenti
        public List<Utente> GetAll() // Deserializzo il file JSON per ottenere la lista degli utenti e lo ritorna
        {
            return _utenti;
        }

        // Metodo per ottenere un utente tramite ID
        public Utente GetByID(int id)
        {
            var utenteList = Deserialize(); // Deserializzo il file JSON per ottenere la lista degli utenti
            return utenteList.FirstOrDefault(u => u.Id == id); // Ritorna il primo utente che corrisponde all'ID specificato
        }


        // Metodo per aggiungere un nuovo utente
        public Utente Aggiungi(Utente nuovoUtente)
        {
            var elenco = Deserialize(); // Deserializzo il file JSON per ottenere la lista degli utenti
            // Se riceve dal Body un id == 0 allora ne genera uno nuovo univoco
            if (nuovoUtente.Id == 0)
            {
                // Genera un nuovo ID univoco
                // Controlla se la lista è vuota, altrimenti prende il massimo ID esistente e aggiunge 1 altrimenti mette 1
                // Any è un metodo LINQ che verifica se la lista contiene elementi
                int nuovoId = elenco.Any() ? elenco.Max(a => a.Id) + 1 : 1;
                nuovoUtente.Id = nuovoId;
            }
            elenco.Add(nuovoUtente);
            var json = JsonConvert.SerializeObject(elenco, Formatting.Indented);
            File.WriteAllText(_percorsoUtenteFile, json);
            return nuovoUtente;
        }

        // Metodo per eliminare un utente
        public void Delete(int id)
        {
            var utenteList = Deserialize(); // Deserializzo il file JSON per ottenere la lista degli utenti
            var utenteToRemove = utenteList.FirstOrDefault(u => u.Id == id);

            // Se l'utente da rimuovere esiste nella lista
            if (utenteToRemove != null)
            {
                // Rimuove l'utente dalla lista
                utenteList.Remove(utenteToRemove);
                var json = JsonConvert.SerializeObject(utenteList, Formatting.Indented);
                File.WriteAllText(_percorsoUtenteFile, json);
            }
        }
    }
}

```

## UtentiController.cs

```c#
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
        List<Utente> utenti = _service.Deserialize();
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
```

### Route `api/utenti`
Route `api/utenti`: Restituisce la lista di tutti gli utenti. 
```c#
[HttpGet]
    public ActionResult<List<Utente>> Get()
    {
        List<Utente> utenti = _service.Deserialize();
        return Ok(utenti);
    }

```

### Route `api/utenti/{id}`
Route `api/utenti/{id}`: Restituisce un utente specifico in base all'ID. Se l'utente non esiste, restituisce un errore 404 Not Found.
```c#
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
```

### Route POST `api/utenti`
Route POST `api/utenti`: Aggiunge un nuovo utente. Se il corpo in POST è vuoto allora ritorna una risposta 400 altrimenti crea l'album
```c#
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
```

### Route DELETE `api/utenti/{id}`
Route DELETE `api/utenti/{id}`: Cancella un Utente tramite ID. Se va a buon fine ritorna una risposta 204, altrimenti manda una risposta 404
```c#
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
```