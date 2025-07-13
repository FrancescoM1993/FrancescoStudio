// using Newtonsoft.Json;
// public class AlbumService
// {
//     // Inizializzazione percorsoAlbumFile privato con "_"
//     // Inizializzazione di lista album

//     // private List<Album> _album = new List<Album>();




//     private readonly string _percorsoAlbumFile;

//     public List<Album> Deserialize()
//     {
//         string percorsoAlbumFile = "Json/Album.json";

//         if (!File.Exists(percorsoAlbumFile))
//         {
//             // questo metodo mi permette di gestire l'eccezione
//             throw new FileNotFoundException("File non trovato", percorsoAlbumFile);
//         }

//         var json = File.ReadAllText(percorsoAlbumFile);
//         // Deserializzo contenuto in una lista di oggetti di tipo album sulla variabile elenco
//         var elenco = JsonConvert.DeserializeObject<List<Album>>(json);
//         return elenco ?? new List<Album>();
//     }

    
  

//     //Costruttore della classe dove gli passo il percorso con relativo nome
//     public AlbumService(string percorsoAlbumFile = "Json/Album.json")
//     {
//         _percorsoAlbumFile = percorsoAlbumFile; // Rendo da privata a pubblica per poterla utilizzare nel controller
//     }
//     /*
//     // Funzione carica album void dove nn mi deve return nulla va a prendere il percorso privato e se non esiste gestisco l'eccezione
//     public void CaricaAlbum()
//     {

//         if (!File.Exists(_percorsoAlbumFile))
//         {
//             // questo metodo mi permette di gestire l'eccezione
//             throw new FileNotFoundException("File non trovato", _percorsoAlbumFile);
//         }

//         else
//         {
//             // qui uso la funzione deserializza 
//             Deserializza("Json/Album.json");
//         }
//     }

//     // Uso della funzione deserializza
//     public List<Album> Deserializza(string percorsoAlbumFile)
//     {

//         // Leggo il contenuto del file e lo assegno alla variabile contenuto
//         var contenuto = File.ReadAllText(percorsoAlbumFile);
//         // Deserializzo contenuto in una lista di oggetti di tipo album sulla variabile elenco
//         var elenco = JsonConvert.DeserializeObject<List<Album>>(contenuto);

//         if (elenco == null)
//         {
//             throw new JsonException("Deserializzazione tornata null");
//         }

//         return elenco;
//     }
//     */
    

//     // Ritorna l'elenco di tutti gli album
//     public Album GetAll()
//     {
//         // Creo una lista di oggetti album vuota
//         album = Deserialize();
//         // Ciclo gli elementi della lista album privata e li aggiungo alla lista album pubblica
//         foreach (var album in _percorsoAlbumFile)
//         {
//             return album;
//         }
//         return null;
//     }

//     // Ritorna una lista di oggetti di tipo album che corrisponde alla ricerca effettuata dall'utente(per nome)
//     public Album GetByID(int id)
//     {
        
//         foreach (var album in _percorsoAlbumFile)
//         {
//             if (album.Id == id)
//             {
//                 return album;
//             }
//         }
//         return null; // or throw an exception
//     }

//     // public Album GetByName(string lamiastringainentrata)
//     // {
//     //     var albumScelto = GetAll();
//     //     foreach (var album in album)
//     //     {
//     //         // Solo se il mio titolo è uguale alla scelta utente aggiungo e restituisco
//     //         if (album.Titolo == lamiastringainentrata)
//     //         {
//     //             return album;
//     //         }
//     //     }
//     //     return null;
//     // }
//     // 
//     // public void Delete(int AlbumId)
//     // {

//     // }

//     // public Album Aggiungi(Album newAlbum, string FileName)
//     // {
//     //     newAlbum.Titolo = FileName;
//     //     _album.Add(newAlbum);

//     //     return newAlbum;
//     // }
// }


using Newtonsoft.Json;

public class AlbumService
{
    private readonly string _percorsoAlbumFile;
    private List<Album> _album = new List<Album>();

    public AlbumService(string percorsoAlbumFile = "Json/Album.json")
    {
        _percorsoAlbumFile = percorsoAlbumFile;
    }

    public List<Album> Deserialize()
    {
        if (!File.Exists(_percorsoAlbumFile))
            throw new FileNotFoundException("File non trovato", _percorsoAlbumFile);

        var json = File.ReadAllText(_percorsoAlbumFile);
        var elenco = JsonConvert.DeserializeObject<List<Album>>(json);
        return elenco ?? new List<Album>();
    }

    public List<Album> GetAll()
    {
        _album = Deserialize();
        return _album;
    }

    public Album GetByID(int id)
    {
        var albumList = Deserialize();
        return albumList.FirstOrDefault(a => a.Id == id);
    }

    public Album GetByName(string nome)
    {
        var albumList = Deserialize();
        return albumList.FirstOrDefault(a => a.Titolo.Equals(nome, StringComparison.OrdinalIgnoreCase));
    }

    public Album Aggiungi(Album nuovoAlbum)
    {
        var elenco = Deserialize();
        elenco.Add(nuovoAlbum);
        var json = JsonConvert.SerializeObject(elenco, Formatting.Indented);
        File.WriteAllText(_percorsoAlbumFile, json);
        return nuovoAlbum;
    }
}




