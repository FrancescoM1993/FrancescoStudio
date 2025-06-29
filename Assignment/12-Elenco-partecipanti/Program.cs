/*

string elencoPa = @"partecipanti.txt";
File.Create(elencoPa).Close();

List<string> partecipanti = new List<string> { "Alice", "Luca", "Marco", "Giulia", "Sara" };
File.WriteAllLines(elencoPa, partecipanti);

string contenuto = File.ReadAllText(elencoPa);
Console.WriteLine(contenuto);

Random rnd = new Random();
int indice = rnd.Next(partecipanti.Count);
Console.WriteLine("Il partecipante scelto è: " + partecipanti[indice]);
string estratto = @"estratto.txt";

File.Create(estratto).Close();
File.AppendAllText(estratto, $"{partecipanti[indice]}");

*/

// Leggo l'elenco dei partecipanti dal file

string time = DateTime.Now.ToString("yyyy-MM-dd-ss");
string[] partecipanti = File.ReadAllLines("partecipanti.txt");
// Inizializzo un array per gli estratti
string[] estratti = new string[0];
// Mi assicuro che il file dei partecipanti estratti esista

if (File.Exists("estratti.txt"))
{
    estratti = File.ReadAllLines("estratti.txt");
}

// Crea un istanza di Random per generare un numero casuale
Random random = new Random();

// Pulisco lo schermo
Console.Clear();
// stampo a video il timestamp corrente
Console.WriteLine($"Timestamp corrente: {time}");
// Stampo una linea divisoria
Console.WriteLine(new string('-', 40));
// Stampa i partecipanti a video
Console.WriteLine("\nPartecipanti:");
foreach (string partecipante in partecipanti)
{
    Console.WriteLine(partecipante);
}

// Uso il metodo Except per trovare i partecipanti non estratti
string[] disponibili = partecipanti.Except(estratti).ToArray();

// Verifico se ci sono partecipanti è disponibili

if (disponibili.Length == 0)
{
    Console.WriteLine("Non ci sono più partecipanti da estrarre!!.");
    return; // Esce dal programma se non ci sono più partecipanti disponibili
}

// Stampa i partecipanti disponibili
Console.WriteLine("\nPartecipanti disponibili:");
foreach (string partecipante in disponibili)
{
    Console.WriteLine(partecipante);
}

// estrae un indice casuale dall'elenco dei partecipanti disponibili
int indiceEstratto = random.Next(disponibili.Length);

// ottengo il partecipante estratto
string partecipanteEstratto = disponibili[indiceEstratto];

// visualizzo il partecipante estratto a video

Console.WriteLine($"Partecipante estratto: {partecipanteEstratto}");

// Aggiungo il partecipante estratto al file degli estratti

File.AppendAllText("estratti.txt", partecipanteEstratto + Environment.NewLine);
// File.AppendAllText("estratti.txt", $"{partecipanteEstratto}\n")

// Stampa il numero di partecipanti estratti e quelli ancora disponibili
Console.WriteLine($"Partecipanti estratti: {estratti.Length + 1}");
 
Console.WriteLine($"Partecipanti ancora disponibili: {disponibili.Length - 1}");