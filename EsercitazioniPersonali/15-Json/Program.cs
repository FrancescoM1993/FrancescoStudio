using Newtonsoft.Json; // importazione della libreria Newtonsoft.Json


// ESEMPIO DI DESERIALIZZAZIONE (lettura)

// in questo caso il file è nella stessa cartella del programma
// percorso del file json
string path = @"Persona.json";

// In csharp, per leggere un file json, è possibile utilizzare la libreria Newtonsoft.Json

// I files json hanno bisogno di essere serializzati e deserializzati per poter essere utilizzati in csharp.

// dotnet add package Newtonsoft.Json

// I files csharp che usano la libreria Newtonsoft.json devono importare il namespace Newtonsoft.Json

// deserializzo il file json in un oggetto

// Partecipante partecipante = JsonConvert.DeserializeObject<Partecipante>(File.ReadAllText(path));
string json = File.ReadAllText(path); // Leggo il contenuto del file json

// deserializzo con JsonConvert
Partecipante partecipante = JsonConvert.DeserializeObject<Partecipante>(json); // Deserializzo il json in un oggetto Partecipante

// deserializzazione tramite Newtonsoft.Json
// Partecipante partecipante = JsonSerializer.Deserialize<Partecipante>(json); 

// una volta deserializzato, posso accedere ai campi dell'oggetto
Console.WriteLine($"Nome: {partecipante.nome}");
// età
Console.WriteLine($"Età: {partecipante.eta}");
// presente
Console.WriteLine($"Presente: {partecipante.presente}");
// interessi metodo 1 con foreach

/* foreach (var interesse in partecipante.interessi) // per ogni interesse nella lista interessi
{
    Console.WriteLine($"- {interesse}"); // stampo l'interesse
} 
*/

// interessi metodo 2 con string.Join
Console.WriteLine($"Interessi: {string.Join(", ", partecipante.interessi)}"); // stampo gli interessi come stringa

// deserializzo in modo specifico in questo caso indirizzo che è formato da piu campi.
Console.WriteLine($"Indirizzo: {partecipante.indirizzo.via}, {partecipante.indirizzo.citta}, {partecipante.indirizzo.cap}");

// ESEMPIO DI SERIALIZZAZIONE (Scrittura)

Partecipante nuovoPartecipante = new Partecipante
{
    nome = "Mario Rossi",
    eta = 30,
    presente = true,
    interessi = new List<string> { "Calcio", "Programmazione", "Musica" },
    indirizzo = new Indirizzo
    {
        via = "Via Roma",
        citta = "Milano",
        cap = "20100"
    }
};

// SERIALIZZAZIONE
string jsonOutput = JsonConvert.SerializeObject(nuovoPartecipante, Formatting.Indented);
string outputPath = @"output.json"; // percorso del file di output
// scrivo il json in un file    
File.WriteAllText(outputPath, jsonOutput);
// stampo a console il json
Console.WriteLine("JSON serializzato:");
Console.WriteLine(jsonOutput); // stampo il json serializzato

// modifica del valore di un campo di una classe
// modifico il campo nome del partecipante
partecipante.nome = "Giovanni Bianchi";
// serializzo di nuovo l'oggetto partecipante modificato
string jsonModificato = JsonConvert.SerializeObject(partecipante, Formatting.Indented);
// scrivo il json modificato in un file
File.WriteAllText(path, jsonModificato);
Console.WriteLine("JSON modificato");
// stampo il json modificato
Console.WriteLine(jsonModificato);

// ESEMPIO DI CANCELLAZIONE DI UN FILE JSON
// cancello il file json

/*
if (File.Exists(path))
{
    File.Delete(path); // cancello il file json
    Console.WriteLine($"File {path} cancellato.");
}
else
{
    Console.WriteLine($"Il file {path} non esiste.");
}
*/


// creare la classe Partecipante
public class Partecipante
{
    public string nome { get; set; } // proprietà nome
    public int eta { get; set; } // proprietà età
    public bool presente { get; set; } // proprietà presente
    public List<string> interessi { get; set; } // proprietà interessi, una lista di stringhe
    public Indirizzo indirizzo { get; set; } // proprietà indirizzo, un oggetto di tipo Indirizzo
}

public class Indirizzo
{
    public string via { get; set; } // proprietà via
    public string citta { get; set; } // proprietà città
    public string cap { get; set; } // proprietà cap
}


