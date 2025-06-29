```csharp
// dizionario globale con i partecipanti (nome e data di nascita)
Dictionary<string, DateTime> partecipanti = RaccogliPartecipanti();
// lista globale per i partecipanti idonei
List<string> idonei = FiltraIdonei(partecipanti);
// chiamata alla funzione che sorteggia un partecipante idoneo
SorteggiaPartecipante(idonei);

// funzione che raccoglie i partecipanti senza nessn parametro
Dictionary<string, DateTime> RaccogliPartecipanti()
{
    // dizionario locale per memorizzare i partecipanti
    Dictionary<string, DateTime> partecipanti = new();

    while (true)
    {
        // gestione del nome
        Console.Write("Nome o 'fine' per uscire: ");
        string nome = Console.ReadLine();
        // se l'utente inserisce "fine" esce dal ciclo
        if (nome.ToLower() == "fine")
        {
            break; // Esce dal ciclo se l'utente inserisce "fine"
        }
        // gestione della data
        Console.Write("Data di nascita (es. 01/01/2000): ");
        string inputData = Console.ReadLine();
        // parse della data inserita in modo che da string diventi DateTime
        DateTime data; // Variabile per memorizzare la data di nascita
        if (!DateTime.TryParse(inputData, out data))
        {
            Console.WriteLine("Data non valida. Riprova.\n");
            continue; // Se la data non è valida, richiede nuovamente l'input
        }
        // aggiunta del partecipante al dizionario
        partecipanti[nome] = data; // Aggiunge il partecipante al dizionario con nome come chiave e data come valore
    }

    return partecipanti; // restituisce il dizionario dei partecipanti
}
// funzione che filtra i partecipanti idonei con parametro dizionario partecipanti da filtrare in una lista
List<string> FiltraIdonei(Dictionary<string, DateTime> partecipanti)
{
    // lista per i partecipanti idonei
    List<string> idonei = new();
    // gestire la data di oggi
    DateTime oggi = DateTime.Today;
    // ciclo per filtrare i partecipanti idonei
    foreach (var p in partecipanti)
    {
        // calcolo l eta del partecipante
        int eta = oggi.Year - p.Value.Year;
        // se l'eta è maggiore o uguale a 21 aggiungo il partecipante alla lista degli idonei
        if (eta >= 21)
        {
            // aggiunta del partecipante idoneo alla lista
            idonei.Add(p.Key); // Aggiunge il partecipante idoneo alla lista
        }
    }

    return idonei; // restituisce la lista dei partecipanti idonei
}
// funzione che sorteggia un partecipante idoneo con parametro lista di idonei e nessun return dato che deve solo stampare
void SorteggiaPartecipante(List<string> idonei)
{
    // gestire il caso in cui non ci sono partecipanti idonei
    if (idonei.Count > 0)
    {
        // generare un indice casuale per sorteggiare un partecipante idoneo
        Random rnd = new();
        // sorteggio un partecipante idoneo
        string scelto = idonei[rnd.Next(idonei.Count)];
        // stampare il nome del partecipante sorteggiato
        Console.WriteLine("\nPartecipante scelto: " + scelto);
    }
    else
    {
        // se non ci sono partecipanti idonei stampo un messaggio
        Console.WriteLine("Nessun partecipante idoneo trovato.");
    }
}
```