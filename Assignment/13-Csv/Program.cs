/*

prodotti.csv

Id,Nome,Prezzo
1,Penna,1.50
2,Quaderno,2.00
3,Gomma,0.80

Gestire un elenco di prodottu da un file CSV.

-leggere
-aggiungere
-salvare
-eliminare

Usare i metodi di stringa in modo da separare i valori riferiti ad un prodotto (, punto e virgola, tab, ecc.).
Usare i metodi di files per leggere e scrivere su file.
Usare le liste per gestire i prodotti in memoria.

Versione 2 

aggiungere la logica che permette all utente di inserire un altro prodotto
- Il programma deve chiedere all utente se inserire un altro prodotto o no

*/



string percorso = "Prodotti.csv";

List<string[]> prodotti = LeggiProdotti(percorso);

MostraProdotti(prodotti);
AggiungiProdotto(prodotti);
ScriviProdotti(percorso, prodotti);

List<string[]> LeggiProdotti(string file)
{
    // creo una lista di stringhe per contenere i prodotti
    List<string[]> lista = new();
    if (File.Exists(file))
    {
        string[] righe = File.ReadAllLines(file);
        for (int i = 1; i < righe.Length; i++)
        {
            // separo i valori della riga (dove c'è la virgola) usando il metodo split
            string[] campi = righe[i].Split(',');
            // aggiungo i campi alla lista
            lista.Add(campi);
        }
    }
    return lista;
    
}

void AggiungiProdotto(List<string[]> prodotti)
{
    while (true)
    {
        
        // chiediamo all'utente di insererire il nome del prodotto
        Console.Write("Inserisci il nome del prodotto (con la virgola tipo 0,80) o no per terminare il programma: ");
        string nome = Console.ReadLine();
        if (nome == "no")
        {
            break;
        }
        Console.Write("Inserisci il prezzo del prodotto: ");
        if (!string.IsNullOrWhiteSpace(nome))
        {
            nome = char.ToUpper(nome[0]) + nome.Substring(1).ToLower();
        }

        string prezzoInput = Console.ReadLine();
        double prezzo;
        while (!double.TryParse(prezzoInput, out prezzo))
        {
            Console.Write("Prezzo non valido. Riprova: ");
            prezzoInput = Console.ReadLine();
        }
        int nuovoId = CalcolaNuovoId(prodotti);
        // usiamo F2 per formattare il prezzo con due decimali
        string[] nuovoProdotto = new string[] { nuovoId.ToString(), nome, prezzo.ToString("F2") };
        nuovoProdotto[2] = nuovoProdotto[2].Replace(',', '.');
        prodotti.Add(nuovoProdotto);
    }
}

void MostraProdotti(List<string[]> prodotti)
{
    if (prodotti.Count == 0)
    {
        Console.WriteLine("Nessun prodotto disponibile.");
        return;
    }
    Console.WriteLine("Prodotti disponibili");
    foreach (var prodotto in prodotti)
    {
        Console.WriteLine($"ID: {prodotto[0]}, Nome: {prodotto[1]}, Prezzo: {prodotto[2]}");
    }
}

int CalcolaNuovoId(List<string[]> prodotti)
{
    if (prodotti.Count == 0)
    {
        return 1;
    }
    string[] ultimoProdotto = prodotti[prodotti.Count - 1];
    int ultimoId = int.Parse(ultimoProdotto[0]);
    return ultimoId + 1;
}

void ScriviProdotti(string file, List<string[]> prodotti)
{
    // scrivo l intestazione del file CSV
    List<string> righe = new() { "ID,Nome,Prezzo" };
    // ciclo i prodotti e li aggiungo
    foreach (var prodotto in prodotti)
    {
        // creo la riga del prodotto usando il metodo join
        string riga = string.Join(",", prodotto);
        // aggiungo la riga
        righe.Add(riga);
    }
    // scrivo il contenuto sul file CSV
    File.WriteAllLines(file, righe);
}