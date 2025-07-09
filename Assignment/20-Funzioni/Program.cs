
/*Senza classe
using Newtonsoft.Json.Linq;

string json = @"{
    ""Marca"":""Lamborghini"",
    ""Anno_immatricolazione"": 2006,
    ""Modello"": ""Sportiva"",
    ""Assicurazione_attiva"": true,
}";

JObject automobile = JObject.Parse(json);

Console.WriteLine($"Marca: {automobile["Marca"]}");
Console.WriteLine($"Anno_immatricolazione: {automobile["Anno_immatricolazione"]}");
Console.WriteLine($"Modello: {automobile["Modello"]}");
Console.WriteLine($"Assicurazione_attiva: {automobile["Assicurazione_attiva"]}");
*/

/* Con classe senza costruttore

using Newtonsoft.Json;

string json = @"{
    ""Marca"":""Lamborghini"",
    ""Anno_immatricolazione"": 2006,
    ""Modello"": ""Sportiva"",
    ""Assicurazione_attiva"": true,
}";

Automobile automobile = JsonConvert.DeserializeObject<Automobile>(json);

Console.WriteLine($"Marca: {automobile.Marca}");
Console.WriteLine($"Anno_immatricolazione: {automobile.Anno_immatricolazione}");
Console.WriteLine($"Modello: {automobile.Modello}");
Console.WriteLine($"Assicurazione_attiva : {automobile.Assicurazione_attiva}");

public class Automobile
{
    public string Marca { get; set; }
    public int Anno_immatricolazione { get; set; }
    public string Modello { get; set; }
    public bool Assicurazione_attiva { get; set; }
}

*/

/* Con classe senza costruttore

using Newtonsoft.Json;

Automobile automobile = new Automobile(
    marca: "Lamborghini",
    annoImmatricolazione: 2006,
    modello: "Sportiva",
    assicurazioneAttiva: true
);


Console.WriteLine("Marca: ");
automobile.Marca = Console.ReadLine();
Console.WriteLine($"Anno di Immatricolazione:");
automobile.AnnoImmatricolazione = int.Parse(Console.ReadLine());
Console.WriteLine($"Modello:");
automobile.Modello = Console.ReadLine();
Console.WriteLine($"Assicurazione:true o false");
automobile.AssicurazioneAttiva = bool.Parse(Console.ReadLine());


new Automobile("Marca", 2025, "Tesla", false); // Andiamo a creare un automobile personalizzato

// Mi stampa il costruttore default

Automobile automobileDefault = new Automobile(); // Creo un automobile di default

Console.WriteLine($"Marca: {automobileDefault.Marca}");
Console.WriteLine($"Marca: {automobileDefault.AnnoImmatricolazione}");
Console.WriteLine($"Marca: {automobileDefault.Modello}");
Console.WriteLine($"Marca: {automobileDefault.AssicurazioneAttiva}");
*/

// app con menu e funzioni di base
// le funzioni sono dei principali tipi (void, int, con dati complessi di ritorno)
using Newtonsoft.Json;
// ci sono due tipi di metodi dei quali uno è statico
// il metodo statico è un metodo che può essere invocato senza creare un'istanza della classe
// i metodi statici sono invocati direttamente dalla classe quindi direttamente accessibili senza bisogno di creare un'istanza della classe
// static readonly -> valore condiviso da tutte le istanze, ma immutabile dopo inizializzazione
// public static readonly -> valore condiviso da tutte le istanze, ma immutabile dopo inizializzazione ed accessibile ovunque
// public -> Accessibilità -> Chi può vedere/chiamare il membro
// static -> Legame alla classe -> Membro condiviso, invocabile senza istanza
// readonly -> 	Immutabilità dopo inizializzazione -> Campo assegnabile solo in dichiarazione o costruttore

// creo un menu di opzioni in modo da scegliere quale funzione invocare
while (true)
{
    Console.Clear();
    Console.WriteLine("=== App per Imparare le Funzioni ===");
    Console.WriteLine("1. Esempio funzione void");
    Console.WriteLine("2. Esempio funzione con azione");
    Console.WriteLine("3. Esempio funzione con dati complessi");
    Console.WriteLine("0. Esci");
    Console.Write("Scegli un'opzione: ");

    // acquisisco l'input dell utente
    string scelta = Console.ReadLine();

    // gestisco le scelte dell utente con uno switch
    switch (scelta)
    {
        case "1":
            EsempioVoid();
            break; // uso break in modo da uscire dallo switch e non eseguire le altre opzioni
        case "2":
            EsempioConAzione();
            break;
        case "3":
            EsempioDatiComplessi();
            break;
        case "0":
            Console.WriteLine("Uscita dal programma...");
            return; // esco dal while e quindi esco dal programma
        default:
            Console.WriteLine("Opzione non valida. Premi un tasto per continuare...");
            Console.ReadKey();
            break;
    }
}

// funzione void: non restituisce nulla
static void EsempioVoid()
{
    // pulisco la console
    Console.Clear();
    Console.WriteLine("--- Funzione void ---");
    // stampo un messaggio di saluto
    StampaSaluto();
    Console.WriteLine("Premi un tasto per tornare al menu...");
    Console.ReadKey();
}

// funzione void: non restituisce nulla
static void StampaSaluto()
{
    Console.WriteLine("Ciao!");
}

// Funzione void: non restituisce nulla ma esegue un azione
static void EsempioConAzione()
{
    Console.Clear();
    Console.WriteLine("--- Funzione con azione ---");

    // chiedo i dati all utente
    Console.Write("Inserisci il primo numero: ");
    int a = int.Parse(Console.ReadLine() ?? "0");
    Console.Write("Inserisci il secondo numero: ");
    int b = int.Parse(Console.ReadLine() ?? "0");

    // calcolo la somma invocando la funzione Somma
    int somma = Somma(a, b);

    Console.WriteLine($"La somma di {a} e {b} è: {somma}");
    Console.WriteLine("Premi un tasto per tornare al menu...");
    Console.ReadKey();
}

// funzione con tipo di ritorno: restituisce un valore
static int Somma(int x, int y)
{
    return x + y;
}

// Funzione che gestisce dati complessi: elenco di libri
static void EsempioDatiComplessi()
{
    Console.Clear();
    Console.WriteLine("--- Funzione con Dati Complessi ---");

    // creo elenco libri
    var libri = new List<Libro>
    {
        new Libro("Il nome della rosa", 1980, "Storico", true),
        new Libro("1984", 1949, "Distopico", false),
        new Libro("Il Signore degli Anelli", 1954, "Fantasy", true)
    };

    // filtro i libri letti usando la funzione FiltraLibriLetti
    var libriLetti = FiltraLibriLetti(libri);

    // stampo i libri letti
    Console.WriteLine("Libri già letti:");
    foreach (var libro in libriLetti)
    {
        Console.WriteLine($"- {libro.Titolo} ({libro.AnnoPubblicazione}) - {libro.Genere}");
    }

    Console.WriteLine("Premi un tasto per tornare al menu...");
    Console.ReadKey();
}

// Funzione che filtra i libri letti restituisce una lista di libri che sono stati letti
static List<Libro> FiltraLibriLetti(List<Libro> elenco)
{
    // creo una lista per i risultati del filtraggio
    var risultati = new List<Libro>();
    // ciclo attraverso l'elenco dei libri
    // e aggiungo alla lista dei risultati solo i libri che sono stati letti
    foreach (var libro in elenco)
    {
        if (libro.Letto)
            risultati.Add(libro);
    }
    return risultati;
}

