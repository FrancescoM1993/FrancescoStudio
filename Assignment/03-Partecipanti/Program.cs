// Inizializza una lista di stringhe per memorizzare i nomi dei partecipanti

List<string> squadra1 = new List<string>();
List<string> squadra2 = new List<string>();

string nome;


// Ciclo per l'inserimento dei partecipanti

while (true)

{
    Console.WriteLine("Inserisci il nome del partecipante ('fine' per terminare): ");
    nome = Console.ReadLine();

    if (nome.ToLower() == "fine")
    {

        break;
    }

    Console.WriteLine("Inserisci il numero della squadra (1 o 2): ");
    string squadra = Console.ReadLine();
    if (squadra == "1")
    {
        squadra1.Add(nome);
    }
    else if (squadra == "2")
    {
        squadra2.Add(nome);
    }
    if (nome.ToLower() == "fine")
    {
        break;
    }
}
    Console.WriteLine("Elenco dei partecipanti della squadra 1:");
    foreach (string partecipante in squadra1)
    {
        Console.WriteLine(partecipante);
    }
    Console.WriteLine("Elenco dei partecipanti della squadra 2:");
    foreach (string partecipante in squadra2)
    {
        Console.WriteLine(partecipante);
    }



