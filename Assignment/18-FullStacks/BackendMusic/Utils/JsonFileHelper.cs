using System.Text.Json;

namespace BackendMusic.Utils
{
    public static class JsonFileHelper
    {
        // questa classe fornisce metodi per caricare e salvare lisye di oggetti in file JSON
        // questa è un classe statica che nn può essere istanziata

        // Configuro le impostazioni di serializzazione
        private static readonly JsonSerializerOptions options = new JsonSerializerOptions // Costruttore
        {
            // Imposta le opzioni di serializzazione per gestire i nomi delle proprietà in modo case-insensitive
            PropertyNameCaseInsensitive = true,
            // Imposta l'indentazione per una migliore leggibilità del file Json
            WriteIndented = true
        };
        // Metodo per caricare una lista di oggetti da un file JSON (deserializzazione)
        // T indica che il metodo può essere utilizzato con qualsiasi tipo di oggetto ad esempio List<User>, List<Product>
        public static List<T> LoadList<T>(string filepath)
        {
            // Controllo se il file esiste, se non esiste restituisce una lista vuota
            if (!File.Exists(filepath))
                // Restituisce una lista vuota
                return new List<T>();
            // Legge il contenuto del file JSON
            string json = File.ReadAllText(filepath);
            // Deserializza il JSON in una lista di oggetti del tipo T
            return JsonSerializer.Deserialize<List<T>>(json, options) ?? new List<T>();
        }

        // Metodo per salvare una lista di oggetti in un file JSON (serializzazione)
        public static void SaveList<T>(string filePath, List<T> list)
        {

            string json = JsonSerializer.Serialize(list, options);
            File.WriteAllText(filePath, json);
        }
    }
}
