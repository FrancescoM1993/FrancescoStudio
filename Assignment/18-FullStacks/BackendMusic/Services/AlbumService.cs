
using BackendMusic.Models;
using BackendMusic.Utils;
using Newtonsoft.Json;

namespace BackendMusic.Services
{
    public class AlbumService
    {
        private readonly string _percorsoAlbumFile;  // Path privato di sola lettura del file JSON contenente gli album
        private List<Album> _album; // Lista privata contenente gli album, inizializzata vuota e successivamente popolata

        // Costruttore che inizializza il percorso del file JSON e carica gli album
        // Utilizza un file di configurazione per ottenere il percorso del file JSON
        public AlbumService(string percorsoAlbumFile = "Json/Album.json")
        {
            // Inizializza il percorso del file JSON da un file di configurazione
            // _percorsoAlbumFile = "config.txt";
            // string[] righe = File.ReadAllLines(_percorsoAlbumFile);
            // _percorsoAlbumFile = righe[1];

            // Controlla se il file esiste, altrimenti lancia un'eccezione
            // if (!File.Exists(_percorsoAlbumFile))
            //     throw new FileNotFoundException("File non trovato", _percorsoAlbumFile);

            // var json = File.ReadAllText(_percorsoAlbumFile);
            // var elenco = JsonConvert.DeserializeObject<List<Album>>(json);
            // _album = elenco ?? new List<Album>();

            _album = JsonFileHelper.LoadList<Album>(percorsoAlbumFile);
        }

        // Metodo per deserializzare il file JSON con controllo dell'esistenza del file
        // public List<Album> Deserialize()
        // {
        //     string percorsoAlbumFile = "Json/Album.json";

        //     if (!File.Exists(percorsoAlbumFile))
        //     {
        //         // questo metodo mi permette di gestire l'eccezione
        //         throw new FileNotFoundException("File non trovato", percorsoAlbumFile);
        //     }

        //     var json = File.ReadAllText(percorsoAlbumFile);
        //     // Deserializzo contenuto in una lista di oggetti di tipo album sulla variabile elenco
        //     var elenco = JsonConvert.DeserializeObject<List<Album>>(json);
        //     return elenco ?? new List<Album>();
        // }

        // Metodo per ottenere gli album
        public List<Album> GetAll() // Deserializzo il file JSON per ottenere la lista degli album e lo ritorna
        {
            return _album;
        }

        // Metodo per ottenere un album tramite ID
        public Album GetByID(int id)
        {
            // Deserializzo il file JSON per ottenere la lista degli album
            return _album.FirstOrDefault(a => a.Id == id); // Ritorna il primo album che corrisponde all'ID specificato
        }


        // Metodo per aggiungere un nuovo album
        public Album Aggiungi(Album nuovoAlbum)
        {
            //var elenco = Deserialize(); // Deserializzo il file JSON per ottenere la lista degli album
            // Se riceve dal Body un id == 0 allora ne genera uno nuovo univoco

            if (nuovoAlbum.Id == 0)
            {
                // Genera un nuovo ID univoco
                // Controlla se la lista è vuota, altrimenti prende il massimo ID esistente e aggiunge 1 altrimenti mette 1
                // Any è un metodo LINQ che verifica se la lista contiene elementi
                int nuovoId = _album.Any() ? _album.Max(a => a.Id) + 1 : 1;
                nuovoAlbum.Id = nuovoId;
            }
            _album.Add(nuovoAlbum);
            LoggerHelper.Log($"Aggiunto Nuovo Album: {nuovoAlbum.Id} - {nuovoAlbum.Titolo}");
            //LoggerHelper.Log($"Aggiunto Nuovo Utente: {nuovoUtente.Nome}");
            Save();
            return nuovoAlbum;
        }

        // Metodo per aggiornare un utente esistente
        public Album Update(int id, Album updatedAlbum)
        {
            // Deserializzo il file JSON per ottenere la lista degli album
            var albumToUpdate = _album.FirstOrDefault(a => a.Id == id);

            // Se l'album da aggiornare esiste nella lista
            if (albumToUpdate != null)
            {
                // Aggiorna le proprietà dell'album esistente con quelle del nuovo album
                albumToUpdate.Titolo = updatedAlbum.Titolo;
                albumToUpdate.Autore = updatedAlbum.Autore;
                albumToUpdate.Anno = updatedAlbum.Anno;
                albumToUpdate.Genere = updatedAlbum.Genere;

                Save();
                return albumToUpdate; // Ritorna l'album aggiornato
            }

            return null; // Ritorna null se l'album non esiste
        }

        // Metodo per eliminare un album
        public void Delete(int id)
        {
            // Deserializzo il file JSON per ottenere la lista degli album
            var albumToRemove = _album.FirstOrDefault(a => a.Id == id);

            // Se l'album da rimuovere esiste nella lista
            if (albumToRemove != null)
            {
                // Rimuove l'album dalla lista
                _album.Remove(albumToRemove);
                Save();
                //var json = JsonConvert.SerializeObject(utenteList, Formatting.Indented);
                //File.WriteAllText(_percorsoUtenteFile, json);
            }
            /*
            if (albumToRemove != null)
            {
                LoggerHelper.Log($"Cancellato Album: {albumToRemove.Id}");
            }
            else
            {
                LoggerHelper.Log($"Prova di Cancellazione Album: {albumToRemove.Id}");
            }
            */
        }

        public void Save()
        {
            JsonFileHelper.SaveList("Json/Album.json", _album);
        }
    }
}

/*
curl -X POST http://localhost:5017/api/album \
-H "Content-Type: application/json" \
-d'{
"titolo": "Album di Prova",
"artista": "Artista Sconosciuto",
"anno": 2023,
"genere": "Pop"
}
'


"informazioniUtente": {
"email": "luigi.verdi@example.com",
"indirizzo": "Via Milano 2",
"citta": "Torino",
"cap": 10100
}
}
'
*/
