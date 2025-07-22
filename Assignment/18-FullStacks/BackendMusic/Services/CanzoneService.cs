using BackendMusic.Models;
using BackendMusic.Utils;
using Newtonsoft.Json;

namespace BackendMusic.Services
{
    public class CanzoneService
    {
        private readonly string _percorsoCanzoneFile;  // Path privato di sola lettura del file JSON contenente le canzoni
        private List<Canzone> _canzoni; // Lista privata contenente le canzoni, inizializzata vuota e successivamente popolata

        // Costruttore che inizializza il percorso del file JSON e carica le canzoni
        // Utilizza un file di configurazione per ottenere il percorso del file JSON
        public CanzoneService(string percorsoCanzoneFile = "Json/Canzoni.json")
        {
            // Inizializza il percorso del file JSON da un file di configurazione
            // _percorsoCanzoneFile = "config.txt";
            // string[] righe = File.ReadAllLines(_percorsoCanzoneFile);
            // _percorsoCanzoneFile = righe[1];

            // Controlla se il file esiste, altrimenti lancia un'eccezione
            // if (!File.Exists(_percorsoCanzoneFile))
            //     throw new FileNotFoundException("File non trovato", _percorsoCanzoneFile);

            // var json = File.ReadAllText(_percorsoCanzoneFile);
            // var elenco = JsonConvert.DeserializeObject<List<Canzone>>(json);
            // _canzoni = elenco ?? new List<Canzone>();

            _canzoni = JsonFileHelper.LoadList<Canzone>(percorsoCanzoneFile);
        }

        // Metodo per deserializzare il file JSON con controllo dell'esistenza del file
        // public List<Canzone> Deserialize()
        // {
        //     string percorsoCanzoneFile = "Json/Canzoni.json";

        //     if (!File.Exists(percorsoCanzoneFile))
        //     {
        //         // questo metodo mi permette di gestire l'eccezione
        //         throw new FileNotFoundException("File non trovato", percorsoCanzoneFile);
        //     }

        //     var json = File.ReadAllText(percorsoCanzoneFile);
        //     // Deserializzo contenuto in una lista di oggetti di tipo canzone sulla variabile elenco
        //     var elenco = JsonConvert.DeserializeObject<List<Canzone>>(json);
        //     return elenco ?? new List<Canzone>();
        // }

        // Metodo per ottenere le canzoni
        public List<Canzone> GetAll() // Deserializzo il file JSON per ottenere la lista delle canzoni e lo ritorna
        {
            return _canzoni;
        }

        // Metodo per ottenere una canzone tramite ID
        public Canzone GetByID(int id)
        {
            // Deserializzo il file JSON per ottenere la lista delle canzoni
            return _canzoni.FirstOrDefault(c => c.Id == id); // Ritorna la prima canzone che corrisponde all'ID specificato
        }


        // Metodo per aggiungere una nuova canzone
        public Canzone Aggiungi(Canzone nuovaCanzone)
        {
            if (nuovaCanzone == null)
            {
                throw new ArgumentNullException(nameof(nuovaCanzone), "La canzone non può essere null");
            }
            if (ValidationHelper.IsNullOrWhiteSpace(nuovaCanzone.Titolo))
            {
                throw new ArgumentException("Il titolo non può essere vuoto", nameof(nuovaCanzone.Titolo));
            }
            // Genera un nuovo ID univoco per la canzone
            // Controlla se l'ID generato è già presente nella lista delle canzoni
            int nuovoId = IdGenerator.GetNextId(_canzoni); // Genera un nuovo ID univoco per la canzone
                                                           // Controlla se l'ID generato è già presente nella lista delle canzoni
            nuovaCanzone.Id = nuovoId;
            _canzoni.Add(nuovaCanzone);
            LoggerHelper.Log($"Aggiunta Nuova Canzone: {nuovaCanzone.Id} - {nuovaCanzone.Titolo}");
            //LoggerHelper.Log($"Aggiunto Nuovo Utente: {nuovoUtente.Nome}");
            Save();
            return nuovaCanzone;
        }

        // Metodo per aggiornare un utente esistente
        public Canzone Update(int id, Canzone updatedCanzone)
        {
            if (updatedCanzone == null)
            {
                throw new ArgumentNullException(nameof(updatedCanzone), "La canzone non può essere null");
            }
            if (ValidationHelper.IsNullOrWhiteSpace(updatedCanzone.Titolo))
            {
                throw new ArgumentException("Il titolo non può essere vuoto", nameof(updatedCanzone.Titolo));
            }
            
            var canzoneToUpdate = _canzoni.FirstOrDefault(c => c.Id == id);
            if (canzoneToUpdate != null)
            {
                // Aggiorna le proprietà della canzone esistente con quelle della nuova canzone
                canzoneToUpdate.Titolo = updatedCanzone.Titolo;
                canzoneToUpdate.Durata = updatedCanzone.Durata;
                canzoneToUpdate.Artista = updatedCanzone.Artista;

                Save();
                return canzoneToUpdate; // Ritorna la canzone aggiornata
            }

            return null; // Ritorna null se la canzone non esiste
        }

        // Metodo per eliminare un album
        public void Delete(int id)
        {
            var canzoneToDelete = _canzoni.FirstOrDefault(c => c.Id == id);
            if (canzoneToDelete != null)
            {
                _canzoni.Remove(canzoneToDelete);
                LoggerHelper.Log($"Cancellata Canzone: {canzoneToDelete.Id} - {canzoneToDelete.Titolo}");
                Save();
            }
        }

        public void Save()
        {
            JsonFileHelper.SaveList("Json/Canzone.json", _canzoni);
        }
    }
}