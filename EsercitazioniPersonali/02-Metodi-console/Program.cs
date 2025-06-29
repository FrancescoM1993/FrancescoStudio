//METODI CONSOLE

// inserisco un commento a linea singola
// questo è un commento a linea singola

/*
    questo è un commento a più linee
    che può essere utile per scrivere
    commenti più lunghi
*/

/*
Esercizio 1
Scrivere un programma che chiede all'utente di inserire il proprio nome e cognome e poi stampa a video un messaggio di saluto personalizzato.
*/

// chiedo all utente di inserire il proprio nome
Console.WriteLine("Inserisci il tuo nome:");
// leggo il nome da tastiera e lo assegno alla variabile nome
string nome = Console.ReadLine();
// chiedo all utente di inserire il proprio cognome
Console.WriteLine("Inserisci il tuo cognome:");
// leggo il cognome da tastiera e lo assegno alla variabile cognome
string cognome = Console.ReadLine();
// stampo il nome e cognome
Console.WriteLine($"Ciao {nome} {cognome}!"); // con l'interpolazione posso concatenare piu variabili in modo semplificato 

// int eta = Console.ReadLine();
int eta = 47; // inizializzo la variabile eta con il valore 47
string etaStr = eta.ToString(); // converto l eta in stringa
// stampo l eta
Console.WriteLine($"Hai {etaStr} anni"); // con l'interpolazione posso concatenare piu variabili in modo semplificato

// leggo l input dell utente come stringa convertendolo in intero

// chiede l eta all utente
Console.WriteLine("Inserisci la tua eta:"); // chiedo all utente di inserire la propria eta
// provo a leggere l input del utente come intero
int etaInt = int.Parse(Console.ReadLine()); // legge una riga di testo da tastiera e la converte in intero
// stampo l eta
Console.WriteLine($"Hai {etaInt} anni"); // con l'interpolazione posso concatenare piu variabili in modo semplificato