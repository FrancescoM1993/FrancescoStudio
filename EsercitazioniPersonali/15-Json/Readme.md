# JSON

I files json sono file di testo che contengono dati strutturati in un formato leggibile dall'uomo e facilmente interpretabile dalle macchine.

JSON sta per JavaScript Object Notation ed è un formato di scambio dati molto comune.

## Esempio di file json
```json
{
"nome": "Partecipante 1",
"eta": 30,
"presente": true,
"interessi": ["programmazione", "musica", "sport"],
"indirizzo": {
    "via": "Via Roma",
    "citta": "Milano",
    "cap": "20100"
  }
}
```
```csharp
string path = @"test.json"; // in questo caso il file è nella stessa cartella del programma
```
In csharp, per leggere un file json, è possibile utilizzare la libreria `Newtonsoft.Json`.

I files json hanno bisogno di essere serializzati e deserializzati per poter essere utilizzati in csharp.

## Installazione della libreria Newtonsoft.Json
```bash
dotnet add package Newtonsoft.Json
```
I files csharp che usano la libreria Newtonsoft.Json devono importare il namespace `Newtonsoft.Json`.

## Esempio di deserializzazione di un file json

Program.cs:
```csharp
using Newtonsoft.Json; // importazione della libreria Newtonsoft.Json

// percorso del file json
string path = @"test.json"; // in questo caso il file è nella stessa cartella del programma

// deserializzo il file json in un oggetto
string json = File.ReadAllText(path); // leggo il contenuto del file json
// deserializzazione tramite JsonConvert
Partecipante partecipante = JsonConvert.DeserializeObject<Partecipante>(json);

// una volta deserializzato, posso accedere ai campi dell'oggetto
// nome
Console.WriteLine($"Nome: {partecipante.nome}");
// eta
Console.WriteLine($"Età: {partecipante.eta}");
// presente
Console.WriteLine($"Presente: {partecipante.presente}");
// interessi
Console.WriteLine("Interessi:");
foreach (var interesse in partecipante.interessi)
{
    Console.WriteLine($"- {interesse}");
}
// oppure con il join
Console.WriteLine($"Interessi: {string.Join(", ", partecipante.interessi)}");
// deserializzare un nodo specifico in questo caso indirizzo che è formato da piu campi tipo via citta cap
// indirizzo
Console.WriteLine($"Indirizzo: {partecipante.indirizzo.via}, {partecipante.indirizzo.citta}, {partecipante.indirizzo.cap}");

// creare la clase Partecipante
public class Partecipante
{
    public string nome { get; set; } // campo string
    public int eta { get; set; } // campo int
    public bool presente { get; set; } // campo bool
    public List<string> interessi { get; set; } // campo lista di stringhe
    public Indirizzo indirizzo { get; set; } // campo oggetto di tipo Indirizzo
}

public class Indirizzo
{
    public string via { get; set; } // campo string
    public string citta { get; set; } // campo string
    public string cap { get; set; } // campo string
}
```
## Esempio di serializzazione di un file json
```csharp
// serializzo l'oggetto in un file json
Partecipante partecipante = new Partecipante
// e lo inizializzo con i valori desiderati
{
    nome = "Partecipante 1",
    eta = 30,
    presente = true,
    interessi = new List<string> { "programmazione", "musica", "sport" },
    indirizzo = new Indirizzo
    {
        via = "Via Roma",
        citta = "Milano",
        cap = "20100"
    }
};
// serializzo l'oggetto in un file json
string json = JsonConvert.SerializeObject(nuovoPartecipante, Formatting.Indented); // serializzo l'oggetto in un file json
// percorso del file json
string outputPath = @"output.json"; // in questo caso il file è nella stessa cartella del programma
// scrivo il file json
File.WriteAllText(outputPath, json); // scrivo il file json
// stampo il file json
Console.WriteLine(json); // stampo il file json
```