// Servizio dedicato alla logica di lettura e filtro dei libri
using Newtonsoft.Json;
// dotnet add package Newtonsoft.Json
public class LibroService
{
    // Percorso del file JSON come variabile privata
    private readonly string _percorsoFile;

    public LibroService(string percorsoFile)
    {
        _percorsoFile = percorsoFile; // rendo pubblica la variabile in modo che possa essere usata in altri metodi tipo CaricaLibri o FiltraLibriLetti
    }

    // funzione che carica i libri da un file JSON
    public List<Libro> CaricaLibri()
    {
        // Controllo se il file esiste prima di tentare di leggerlo
        if (!File.Exists(_percorsoFile))
        {
            throw new FileNotFoundException("File non trovato", _percorsoFile);
        }
        // Leggo il contenuto del file JSON e lo memorizzo su una stringa
        var contenuto = File.ReadAllText(_percorsoFile);
        // Deserializzo il contenuto JSON in una lista di oggetti Libro
        var elenco = JsonConvert.DeserializeObject<List<Libro>>(contenuto);
        // Controllo se l'elenco è null e lancio un'eccezione se lo è altrimenti ritorno l elenco
        if (elenco == null)
        {
            throw new JsonException("Deserializzazione tornata null");
        }
            
        return elenco; // Ritorno l'elenco dei libri deserializzati
    }

    public List<Libro> FiltraLibriLetti(List<Libro> elenco)
    {
        //  creo una variabile per memorizzare i libri letti
        var risultati = new List<Libro>();
        foreach (var libro in elenco)
        {
            if (libro.Letto)
            {
                risultati.Add(libro);
            }
        }
        return risultati; // Ritorno l'elenco dei libri letti
    }
}