// FUNZIONI 

// void (senza ritorno senza parametri)

void StampaMessaggio()
{
    Console.WriteLine("funzione void");
}

// chiamata della funzione

StampaMessaggio();

void StampaMessaggioConParametro(string messaggio)
{
    Console.WriteLine(messaggio);
}
// chiamata della funzione con un parametro
StampaMessaggioConParametro("funzione void con parametro");

// funzione che stampa un messaggio con due parametri
void StampaMessaggioConPiuParametri(string messaggio1, string messaggio2)
{
    Console.WriteLine($"{messaggio1} {messaggio2}");
}
// chiamata della funzione con due parametri
StampaMessaggioConPiuParametri("funzione void con","piu parametri");

void StampaMessaggioConParametriDiversi(string messaggio, int numero)
{
    Console.WriteLine($"{messaggio} {numero}");
}
// chiamata della funzione con due parametri
StampaMessaggioConParametriDiversi("funzione void con", 2);

// Esempio di funzione void che manipola una lista

List<string> lista = new List<string> {"elemento 1", "elemento 2", "elemento 3"};
List<string> lista2 = new List<string> { "elemento 4", "elemento 5" };
List<string> lista3 = new List<string> {"elemento 5000", "elemento 6000"};
List<string> listaUnita = UnisciListe(lista, lista2, lista3);

void StampaLista(List<string> lista)
{
    foreach (var item in lista)
    {
        Console.WriteLine(item);
    }
}
// chiamata della funzione con un lista
StampaLista(lista2); //chiamata apposta "a2" per capire che la variabile non conta
// chiamata della funzione con un'altra lista

StampaLista(lista);

StampaLista(lista3);



List<string> UnisciListe(List<string> lista1, List<string> lista2, List<string> lista3)
{
    List<string> listaUnita = new List<string>();
    listaUnita.AddRange(lista1);
    listaUnita.AddRange(lista2);
    listaUnita.AddRange(lista3);
    return listaUnita;
}

StampaLista(listaUnita);

int Somma(int a, int b)
{
    return a + b; // restituisco la somma dei due numeri
}
// chiamata della funzione Somma
int risultato = Somma(5, 10); // passo alla funzione Somma i due numeri da sommare
Console.WriteLine($"La somma di 5 e 10 è: {risultato}");

Console.WriteLine($"La somma di 5 e 10 è: {Somma(5, 10)}");

bool ParolaPari(string parola)
{
    return parola.Length % 2 == 0; // restituisco true se la lunghezza della parola è pari
}
// chiamata della funzione ParolaPari
bool risultatoPari = ParolaPari("cane"); // utilizzo della funzioni
Console.WriteLine($"La parola ha un numero di lettere pari?{risultatoPari}"); // stampo il risultato della verifica

// funzione che restituisce una stringa formattata
string FormattaMessaggio(string nome, int eta)
{
    return $"Ciao{nome}, hai {eta} anni"; // restituisco una stringa formattata
}
// chiamata deòòa funzione FormattaMessaggio
string messaggio = FormattaMessaggio("Utente 1", 30); // passo alla funzione i parametri
Console.WriteLine(messaggio); // stampo il messaggio formattato

// Esempio di una funzione con parametri out
// funzione che divide due numeri e restituisce il risultato e il resto
void Divisione(int dividendo, int divisore, out int quoziente, out int resto)
{
    quoziente = dividendo / divisore; // calcolo il quoziente
    resto = dividendo % divisore; // calcolo il resto
}
// chiamata della funzione
int quoziente, resto; // dichiaro le variabili per il quoziente e il resto
Divisione(10, 3, out quoziente, out resto); // passo alla funzione i parametri
Console.WriteLine($"Quoziente: {quoziente}, resto: {resto}"); // stampo il risultato della divisione