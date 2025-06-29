// TIPI DI DATI

// i tipi di dati possono essere dati semplici o complessi (strutture di dati)

int eta2; // dichiaro una variabile di tipo intero 
eta2 = 30; // inizializzo la variabile di tipo intero

// variabili di tipo intero (si usa questo metodo rispetto a quello di sopra)
int eta = 30; // dichiarazione e inizializzazione della variabile di tipo intero

// variabili di tipo stringa (devo specificare il valore tra gli apici)
string numero = "5"; // dichiarazione e inizializzazione della variabile di tipo stringa

// variabili di tipo char (devo specificare il valore tra gli apici singoli)
char lettera = 'a'; // dichiarazione e inizializzazione della variabile di tipo char

// variabili di tipo float (devo separare gli interi dai decimali con il punto)
float pi = 3.14f; // dichiarazione e inizializzazione della variabile di tipo float

// La differenza tra float e double è che il primo ha una precisione di 7 cifre decimali mentre il secondo di 15
float pi2 = 3.14f; // dichiarazione e inizializzazione della variabile di tipo float
double pi3 = 3.14; // dichiarazione e inizializzazione della variabile di tipo double

// variabili di tipo booleano (con due stati: true o false)
bool maggiorenne = true; // dichiarazione e inizializzazione della variabile di tipo booleano

//eccetto le stringhe che vogliono gli apici doppi
//eccetto i char che vogliono gli apici singoli
//tutti gli altri tipi di dati non vogliono gli apici!!

// variabili di tipo var che permette di dichiarare una variabile senza specificare il tipo
// il tipo viene dedotto dal compilatore in base al valore assegnato
var eta4 = 30; // dichiarazione e inizializzazione della variabile di tipo var     
var nome = "Nome della persona"; // dichiarazione e inizializzazione della variabile di tipo var

// non posso dichiarare una variabile di tipo var senza inizializzarla
// var eta5; // errore: non posso dichiarare una variabile di tipo var senza inizializzarla
// var pero necessita di essere inizializzata al momento della dichiarazione

// variabili di tipo data
DateTime datanascita = new DateTime(1990, 1, 1); // dichiarazione e inizializzazione della variabile di tipo Data
// new é una parola chiave che serve per creare un oggetto (costruttore)

// esempio di utilizzo di una variabile attraverso i metodi di console
Console.WriteLine($"La variabile maggiorenne vale: {maggiorenne}"); // stampo il valore della variabile maggiorenne
Console.WriteLine($"La variabile nome vale: {nome}"); // stampo il valore della variabile nome

// tipi di dati complessi (strutture di dati)
// un insieme di dati di dello stesso tipo
// array -> ha la caratteristica di avere una lunghezza fissa e predeterminata 
int[] numeri = new int[5]; // dichiarazione e inizializzazione di un array di interi di lunghezza 5
numeri[0] = 1; // iniziallizazione del primo elemento dell array [0] é l indice dell array e parte da 0
numeri[1] = 6; 
numeri[2] = 35;  
numeri[3] = 40; 
numeri[4] = 5;
// oppure posso inizializzare l'array in un unica riga
int[] numeri2 = new int[] { 1, 6, 35, 40, 5 }; // dichiarazione e inizializzazione di un array di interi di lunghezza 5

// array di stringhe 
string[] nomi = new string[5]; // dichiarazione e inizializzazione di un array di stringhe di lunghezza 5
nomi[0] = "Partecipante 1"; // inizializzo il primo elemento dell array
nomi[1] = "Partecipante 2";
nomi[2] = "Partecipante 3";
nomi[3] = "Partecipante 4";
nomi[4] = "Partecipante 5";
// oppure posso inizializzare l'array in un unica riga
string[] nomi2 = new string[] { "Partecipante 1", "Partecipante 2", "Partecipante 3", "Partecipante 4", "Partecipante 5" }; // dichiarazione e inizializzazione di un array di stringhe di lunghezza 5

//list
// una lista è una collezione di oggetti di uno stesso tipo
// la lista ha la caratteristica di avere una lunghezza variabile 
List<int> numeri3 = new List<int>(); // dichiarazione e inizializzazione di una lista di interi
numeri3.Add(1); // aggiungo il primo elemento alla lista
numeri3.Add(6); 
numeri3.Add(35); 
numeri3.Add(40); 
numeri3.Add(5); 
// oppure posso inizializzare la lista in un unica riga
List<int> numeri4 = new List<int>() { 1, 6, 35, 40, 5 }; // dichiarazione e inizializzazione di una lista di interi
// lista di stringhe
List<string> nomi3 = new List<string>(); // dichiarazione e inizializzazione di una lista di stringhe
nomi3.Add("Partecipante 1"); // aggiungo il primo elemento alla lista
nomi3.Add("Partecipante 2"); 
nomi3.Add("Partecipante 3"); 
nomi3.Add("Partecipante 4"); 
nomi3.Add("Partecipante 5"); 
// oppure posso inizializzare la lista in un unica riga
List<string> nomi4 = new List<string>() { "Partecipante 1", "Partecipante 2", "Partecipante 3", "Partecipante 4", "Partecipante 5" }; // dichiarazione e inizializzazione di una lista di stringhe  

// dizionario
// un dizionario è una collezione di coppie chiave/valore
// la chiave è univoca e non può essere duplicata
Dictionary<int, string> dizionario = new Dictionary<int, string>(); // dichiarazione e inizializzazione di un dizionario di interi e stringhe
dizionario.Add(1, "Partecipante 1"); // aggiungo la prima coppia chiave/valore al dizionario
dizionario.Add(6, "Partecipante 2"); 
dizionario.Add(35, "Partecipante 3"); 
dizionario.Add(40, "Partecipante 4"); 
dizionario.Add(5, "Partecipante 5"); 
// oppure posso inizializzare il dizionario in un unica riga
Dictionary<int, string> dizionario2 = new Dictionary<int, string>() { { 1, "Partecipante 1" }, { 6, "Partecipante 2" }, { 35, "Partecipante 3" }, { 40, "Partecipante 4" }, { 5, "Partecipante 5" } }; // dichiarazione e inizializzazione di un dizionario di interi e stringhe

// dizionario int bool
Dictionary<int, bool> dizionario3 = new Dictionary<int, bool>(); // dichiarazione e inizializzazione di un dizionario di interi e booleani
dizionario3.Add(1, true); // aggiungo la prima coppia chiave/valore al dizionario
dizionario3.Add(6, false);
dizionario3.Add(35, true);
dizionario3.Add(40, false);
dizionario3.Add(5, true);
// oppure posso inizializzare il dizionario in un unica riga
Dictionary<int, bool> dizionario4 = new Dictionary<int, bool>() { { 1, true }, { 6, false }, { 35, true }, { 40, false }, { 5, true } }; // dichiarazione e inizializzazione di un dizionario di interi e booleani

// BEST PRACTICES PER LA DICHIARAZIONE DI VARIABILI
// dichiarare le variabili con nomi significativi
// dichiarare le variabili con la notazione CamelCase o PascalCase
// esempio camel case etaStudente
// esempio pascal case EtaStudente
