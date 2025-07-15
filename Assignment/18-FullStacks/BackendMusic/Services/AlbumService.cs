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