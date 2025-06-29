Dictionary<string, DateTime> partecipanti = new Dictionary<string, DateTime>();
List<string> idonei = new List<string>();
DateTime oggi = DateTime.Today;

while (true)
{
    // Gestione del nome
    Console.Write("Nome o 'fine' per uscire: ");
    string nome = Console.ReadLine();
    if (nome.ToLower() == "fine")
    {
        break;
    }

    // gestione della data di nascita
    Console.Write("Data di nascita (es. 01/01/2000): ");
    string inputData = Console.ReadLine();
    DateTime data;
    if (!DateTime.TryParse(inputData, out data))
    {
        Console.WriteLine("Data non valida. Riprova.\n");
        continue;
    }
    partecipanti[nome] = data; // Aggiunta del partecipante al dizionario
}
// Gestione partecipanti idonei
foreach (var p in partecipanti)
{
    int eta = oggi.Year - p.Value.Year;
    if (eta >= 21)
    {
        idonei.Add(p.Key); // Aggiunta del partecipante idoneo alla lista
    }
}
// Gestione del sorteggio
if (idonei.Count > 0)
{
    Random rnd = new Random();
    string scelto = idonei[rnd.Next(idonei.Count)];
    Console.WriteLine("\nPartecipante scelto: " + scelto);
}
else
{
    Console.WriteLine("\nNessun partecipante ha più di 21 anni.");
}















