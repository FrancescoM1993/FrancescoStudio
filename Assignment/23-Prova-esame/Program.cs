// Creare un file
string path= @"Studenti.txt";
// Chiudere il file dopo la creazione permette poterci scrivere sopra
File.Create(path).Close();

List<Studente> studenti = new List<Studente>();

// Input da console
Console.Write("Inserisci il nome dello studente: ");
string nome = Console.ReadLine();

Console.Write("Inserisci il voto dello studente: ");
string voto = Console.ReadLine();

// Creare un nuovo oggetto Studente e aggiungerlo alla lista
studenti.Add(new Studente { Nome = nome, Voto = int.Parse(voto) });
// Scrivere i dati degli studenti nel file
foreach (var studente in studenti)

{
    // Aggiunge il testo alla fine del file senza sovrascrivere il contenuto
    File.AppendAllText(path, $"Nome: {studente.Nome}\nVoto: {studente.Voto}\n");
}
Console.WriteLine("Dati degli studenti salvati in Studenti.txt");

// Class Studente
public class Studente
{
    public string Nome { get; set; }
    public int Voto { get; set; }
}

