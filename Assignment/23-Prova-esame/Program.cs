// // Creare un file
// string path= @"Studenti.txt";
// // Chiudere il file dopo la creazione permette poterci scrivere sopra
// File.Create(path).Close();

// List<Studente> studenti = new List<Studente>();

// // Input da console
// Console.Write("Inserisci il nome dello studente: ");
// string nome = Console.ReadLine();

// Console.Write("Inserisci il voto dello studente: ");
// string voto = Console.ReadLine();

// // Creare un nuovo oggetto Studente e aggiungerlo alla lista
// studenti.Add(new Studente { Nome = nome, Voto = int.Parse(voto) });
// // Scrivere i dati degli studenti nel file
// foreach (var studente in studenti)

// {
//     // Aggiunge il testo alla fine del file senza sovrascrivere il contenuto
//     File.AppendAllText(path, $"Nome: {studente.Nome}\nVoto: {studente.Voto}\n");
// }
// Console.WriteLine("Dati degli studenti salvati in Studenti.txt");

// // Class Studente
// public class Studente
// {
//     public string Nome { get; set; }
//     public int Voto { get; set; }
// }


//Studente studente = new();

/*
System.Console.WriteLine("Inserisci il nome");
string nomeRicevuto = Console.ReadLine(); //Nome
System.Console.WriteLine("Inserisci il voto");
int votoRicevuto = int.Parse(Console.ReadLine()); //Voto

Studente studente1 = new(nomeRicevuto, votoRicevuto);

string path = @"allievi.txt";
File.AppendAllText(path, $"Nome: {studente1.Nome}\nVoto: {studente1.Voto}\n");


public class Studente
{
    public string Nome { get; set; } = string.Empty;
    public int Voto { get; set; }

    public Studente(string Nome, int Voto)
    {
        this.Nome = Nome;
        this.Voto = Voto;
    }
}
*/

/*
using Newtonsoft.Json;

List<Libro> libri = new();

while (true)
{
Libro libro = new();

System.Console.WriteLine("Titolo");
string titoloRicevuto = Console.ReadLine();

System.Console.WriteLine("Genere");
string genereRicevuto = Console.ReadLine();

System.Console.WriteLine("Letto");
string lettoRicevuto = Console.ReadLine().ToLower();

if ( lettoRicevuto == "s")
{
    libro.Letto = true;
}

libro.Titolo = titoloRicevuto;
libro.Genere = genereRicevuto;

libri.Add(libro);

System.Console.WriteLine("Continuare?");
string risposta = Console.ReadLine();
if( risposta == "n")
    {
        break;
    }
}

string json = JsonConvert.SerializeObject(libri, Formatting.Indented);

string path = @"libreria.json";
File.AppendAllText(path, json);

public class Libreria
{
    public List<Libro> libri = new();
}

public class Libro
{
    public string Titolo { get; set; } = string.Empty;
    public string Genere { get; set; } = string.Empty;
    public bool Letto { get; set; } = false;

    public Libro()
    {
        
    }
}
*/

/*
string[] frizzbuzz = ["Frizz" , "Buzz"];

for ( int i=0; i <= 100; i++)
{
    
    if ( i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine($"{frizzbuzz[0]}{frizzbuzz[1]}");
    }
    else if ( i % 5 == 0)
    {
        Console.WriteLine($"{frizzbuzz[1]}");
    }
    else if ( i % 3 == 0)
    {
        Console.WriteLine($"{frizzbuzz[0]}");
    }
    else
    {
        Console.WriteLine(i);
    }
}
*/


void Frizzbuzz()
{
    int min = 0;
    int max = 100;
    GeneraNumeri(min,max);
}

void GeneraNumeri(int min, int max)
{
    for ( int numero=min; numero <= max; numero++)
    {
        CheckFrizzBuzz(numero);
    }
}

void CheckFrizzBuzz(int numero)
{
    string[] frizzbuzz = ["Frizz" , "Buzz"];

    if ( numero % 3 == 0 && numero % 5 == 0)
    {
        Console.WriteLine($"{frizzbuzz[0]}{frizzbuzz[1]}");
    }
    else if ( numero % 5 == 0)
    {
        Console.WriteLine($"{frizzbuzz[1]}");
    }
    else if ( numero % 3 == 0)
    {
        Console.WriteLine($"{frizzbuzz[0]}");
    }
    else
    {
        Console.WriteLine(numero);
    }
}

Frizzbuzz();






