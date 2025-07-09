// DESERIALIZZAZIONE JSON SENZA CLASSI

// Using di Newtonsoft.Json

// Using Newtonsoft.Json.Linq;

using Newtonsoft.Json;

// Comando dotnet add package Newtonsoft.Json  da mettere nel terminale

// Guardare nuget su google dove ci sono i vari pacchetti da aggiungere

// Libro
// La @ ci permette di andare a capo senza interrompere la stringa

/*
string json = @"{
    ""Titolo"":""Il Signore Degli Anelli"",
    ""AnnoPubblicazione"": 1954,
    ""Genere"":""Fantasy"",
    ""Letto"": true,
}";


// Faccio il parse in un oggetto generico
JObject libro = JObject.Parse(json);


// Stampo direttamente ogni campo
Console.WriteLine($"Titolo: {libro["Titolo"]}");
Console.WriteLine($"Anno di pubblicazione: {libro["AnnoPubblicazione"]}");
Console.WriteLine($"Genere: {libro["Genere"]}");
Console.WriteLine($"Letto: {libro["Letto"]}");
*/


// DESERIALIZZAZIONE JSON CON CLASSI
/*
string json = @"{
    ""Titolo"":""Il Signore Degli Anelli"",
    ""AnnoPubblicazione"": 1954,
    ""Genere"":""Fantasy"",
    ""Letto"": true,
}";


// Deserializzazione automatica
Libro libro = JsonConvert.DeserializeObject<Libro>(json);

// Stampo direttamente ogni campo accedendo direttamente alle proprietà della classe

Console.WriteLine($"Titolo: {libro.Titolo}");
Console.WriteLine($"Anno di Pubblicazione: {libro.AnnoPubblicazione}");
Console.WriteLine($"Genere: {libro.Genere}");
Console.WriteLine($"Letto: {(libro.Letto ? "Letto" : "Non Letto")}"); // Stampa True o False
// Se Metto ? "Letto : "Non Letto"

// Possiamo spostare la classe Libro in un file separato, ad esempio Libro.cs

// COSTRUTTORI

// un costruttore è un metodo speciale che viene invocato automaticamente quando crei un istanza di una classe (con new)

// serve a:

// - Inizializzazione campi e proprietà con valori di default o obbligatori
// - Garantire che l'oggetto sia sempre in uno stato valido (ad es. evitare null o valori non sensati)
// - Ci semplica la costruzione dell'oggetto, raggruppando in un'unica chiamata tutte le assegnazioni iniziali


public class Libro
{
    Proprietà (da public fino al Titolo)

    public string Titolo { get; set; }
    public int AnnoPubblicazione { get; set; }
    public string Genere { get; set; }
    public bool Letto { get; set; }

    Costruttore (parte dalle graffe)
    public Libro(string Titolo, int AnnoPubblicazione, string Genere, bool Letto)
    {
        // Qui inizializzo le proprietà con i valori passati
        Titolo = titolo
        Anno = anno
        Genere = genere
        Letto = letto
    }
*/
// CREO UN NUOVO LIBRO CON IL COSTRUTTORE PARAMETRICO



/*Libro libro = new Libro(
    titolo:"Il Signore degli Anelli",
    annoPubblicazione:1954,
    genere:"Fantasy",
    letto:true
);

Console.WriteLine($"Titolo: {libro.Titolo}");
Console.WriteLine($"Anno di Pubblicazione: {libro.AnnoPubblicazione}");
Console.WriteLine($"Genere: {libro.Genere}");
Console.WriteLine($"Letto: {(libro.Letto ? "Letto" : "Non Letto")}");
*/
// Vantaggi

// - Oggetto sempre completo: non rischi di dimenticare di impostare una proprietà
// - Codice più pulito : in un'unica riga di new Book(...) passi tutti i valori, anziche settarli uno a uno dopo la creazione

// Costruttore di default
// Se non si dichiara nessun costruttore viene fornito un costruttore senza parametri(costruttore di dafault)
// Però appena dichiariamo il costruttore personalizzato, quello di default scompare, quindi dobbiamo definirlo in modo esplicito


Libro libro = new Libro(); // Creo un libro di default
new Libro("Titolo", 2025, "Fantascienza", false); // Andiamo a creare un libro personalizzato
Console.WriteLine($"Titolo: {libro.Titolo}");