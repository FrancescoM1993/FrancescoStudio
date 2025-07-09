﻿// separazione delle responsabilita con Services
// in questa versione separiamo la logica di business in un servizio dedicato
// in questo caso il servizio gestira la lagica di caricamento e filtraggio dei libri
// in questo modo il codice principale rimane pulito e facilmente testabile
// in questa versione diamo un senso alla funzione somma che fino ad edasso era scollegata
// e la usiamo in modo da calcolare il totale dei libri letti o non letti
// anziche usare lo switch usiamo un menu con delle condizioni

var servizio = new LibroService("libri.json");

while (true)
{
    Console.Clear();
    Console.WriteLine("1. Stampa saluto (void)");
    Console.WriteLine("2. Esegui somma");
    Console.WriteLine("3. Elenca libri e totale");
    Console.WriteLine("0. Esci"); // esce con qualsiasi input che non sia 1 2 3
    Console.Write("Scelta: ");

    // Acquisisco l input dell utente
    // string op = Console.ReadLine();

    // oppure acquisisco direttamente l input dell utente pulito da spazi in eccesso
    // con il ? evito il warning del dato che potrebbe essere null
    string op = Console.ReadLine()?.Trim();

    if (op == "1")
    {
        StampaSaluto();
    }
    else if (op == "2")
    {
        EseguiSomma();
    }
    else if (op == "3")
    {
        EseguiDatiComplessi(servizio);
    }
    else
    {
        break; // Esce dal ciclo e termina il programma
    }
}

static void StampaSaluto()
{
    Console.WriteLine("Ciao! Funzione void.");
    Console.WriteLine("Premi un tasto...");
    Console.ReadKey();
}

static void EseguiSomma()
{
    Console.Write("Primo numero: ");
    int a = int.Parse(Console.ReadLine() ?? "0"); // non gestisce nulla in questo modo
    Console.Write("Secondo numero: ");
    int b = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine($"Risultato: {a + b}");
    Console.WriteLine("Premi un tasto...");
    Console.ReadKey();
}

// funzione che si occupa di caricare i vari servizi
static void EseguiDatiComplessi(LibroService servizio)
{
    Console.Clear();
    Console.WriteLine("--- Libri da JSON ---");
    try
    {
        // blocco nel quale inserisco il codice da provare che potrebbe generare un eccezione
        // carico l elenco dei libri
        var elenco = servizio.CaricaLibri();
        // applico il filtro sui libri letti
        var letti = servizio.FiltraLibriLetti(elenco);
        // calcolo il numero di libri gia letti
        int numLetti = letti.Count;
        // calcolo il numero dei ibri da leggere
        int numNonLetti = elenco.Count - numLetti;
        // calcolo il totale dei libri
        int totale = Somma(numLetti, numNonLetti);

        // stampo i libri gia letti
        Console.WriteLine("Libri già letti:");
        foreach (var libro in letti)
        {
            Console.WriteLine($"Libri letti: {libro.Titolo} - {libro.AnnoPubblicazione} ({libro.Genere})");
        }
        // stampo il totale dei libri letti e non letti
        Console.WriteLine($"Totale libri: {totale} (Letti: {numLetti}, Non letti: {numNonLetti})");
    }
    // eccezione generica
    catch (Exception ex)
    {
        Console.WriteLine($"Errore: {ex.Message}");
    }

    Console.WriteLine("Premi un tasto...");
    Console.ReadKey();

    static int Somma(int x, int y)
    {
        return x + y;
    }
}