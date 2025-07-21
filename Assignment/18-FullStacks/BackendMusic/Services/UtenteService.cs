
using BackendMusic.Models;
using BackendMusic.Utils;
using Newtonsoft.Json;

namespace BackendMusic.Services
{
    public class UtenteService
    {
        private readonly string _percorsoUtenteFile;  // Path privato di sola lettura del file JSON contenente gli utenti
        private List<Utente> _utenti; // Lista privata contenente gli utenti, inizializzata vuota e successivamente popolata

        // Costruttore che inizializza il percorso del file JSON e carica gli album
        // Utilizza un file di configurazione per ottenere il percorso del file JSON
        public UtenteService(string percorsoUtenteFile = "Json/Utenti.json")
        {
            // Inizializza il percorso del file JSON da un file di configurazione
            // _percorsoUtenteFile = "config.txt";
            // string[] righe = File.ReadAllLines(_percorsoUtenteFile);
            // _percorsoUtenteFile = righe[1];

            // Controlla se il file esiste, altrimenti lancia un'eccezione
            // if (!File.Exists(_percorsoUtenteFile))
            //     throw new FileNotFoundException("File non trovato", _percorsoUtenteFile);

            // var json = File.ReadAllText(_percorsoUtenteFile);
            // var elenco = JsonConvert.DeserializeObject<List<Utente>>(json);
            // _utenti = elenco ?? new List<Utente>();

            _utenti = JsonFileHelper.LoadList<Utente>(percorsoUtenteFile);
        }

        // Metodo per deserializzare il file JSON con controllo dell'esistenza del file
        // public List<Utente> Deserialize()
        // {
        //     string percorsoUtenteFile = "Json/Utenti.json";

        //     if (!File.Exists(percorsoUtenteFile))
        //     {
        //         // questo metodo mi permette di gestire l'eccezione
        //         throw new FileNotFoundException("File non trovato", percorsoUtenteFile);
        //     }

        //     var json = File.ReadAllText(percorsoUtenteFile);
        //     // Deserializzo contenuto in una lista di oggetti di tipo utente sulla variabile elenco
        //     var elenco = JsonConvert.DeserializeObject<List<Utente>>(json);
        //     return elenco ?? new List<Utente>();
        // }

        // Metodo per ottenere gli utenti
        public List<Utente> GetAll() // Deserializzo il file JSON per ottenere la lista degli utenti e lo ritorna
        {
            return _utenti;
        }

        // Metodo per ottenere un utente tramite ID
        public Utente GetByID(int id)
        {
            // Deserializzo il file JSON per ottenere la lista degli utenti
            return _utenti.FirstOrDefault(u => u.Id == id); // Ritorna il primo utente che corrisponde all'ID specificato
        }


        // Metodo per aggiungere un nuovo utente
        public Utente Aggiungi(Utente nuovoUtente)
        {
            //var elenco = Deserialize(); // Deserializzo il file JSON per ottenere la lista degli utenti
            // Se riceve dal Body un id == 0 allora ne genera uno nuovo univoco

            if (nuovoUtente.Id == 0)
            {
                // Genera un nuovo ID univoco
                // Controlla se la lista è vuota, altrimenti prende il massimo ID esistente e aggiunge 1 altrimenti mette 1
                // Any è un metodo LINQ che verifica se la lista contiene elementi
                int nuovoId = _utenti.Any() ? _utenti.Max(u => u.Id) + 1 : 1;
                nuovoUtente.Id = nuovoId;
            }
            _utenti.Add(nuovoUtente);
            LoggerHelper.Log($"Aggiunto Nuovo Utente: {nuovoUtente.Id} - {nuovoUtente.Nome}");
            //LoggerHelper.Log($"Aggiunto Nuovo Utente: {nuovoUtente.Nome}");
            Save();
            return nuovoUtente;
        }

        // Metodo per eliminare un utente
        public void Delete(int id)
        {
            // Deserializzo il file JSON per ottenere la lista degli utenti
            var utenteToRemove = _utenti.FirstOrDefault(u => u.Id == id);

            // Se l'utente da rimuovere esiste nella lista
            if (utenteToRemove != null)
            {
                // Rimuove l'utente dalla lista
                _utenti.Remove(utenteToRemove);
                Save();
                //var json = JsonConvert.SerializeObject(utenteList, Formatting.Indented);
                //File.WriteAllText(_percorsoUtenteFile, json);
            }
            /*
            if (utenteToRemove != null)
            {
                LoggerHelper.Log($"Cancellato Utente: {utenteToRemove.Id}");
            }
            else
            {
                LoggerHelper.Log($"Prova di Cancellazione Utente: {utenteToRemove.Id}");
            }
            */
        }

        public void Save()
        {
            JsonFileHelper.SaveList("Json/Utenti.json", _utenti);
        }
    }
}

/*

curl -X POST http://localhost:5017/api/utenti \
-H "Content-Type: application/json" \
-d'{
"nome": "Luigi",
"cognome": "Verdi",

"informazioniUtente": {
"email": "luigi.verdi@example.com",
"indirizzo": "Via Milano 2",
"citta": "Torino",
"cap": 10100
}
}
'
*/
