# FUNZIONI
- Una funzione è un blocco di codice che esegue un compito specifico.
- Il vantaggio di usare le funzioni è che il codice diventa più leggibile e modulare.

Ci sono 2 tipi principali di funzioni:
- Funzioni che elaborano i dati però non restituiscono un valore (void)
- Funzione che elaborano i dati e restituiscono un valore (return) -> sono definite un tipo di ritorno

## Una funzione è definita da:
- Un tipo di ritorno
- Un nome
- Una lista di parametri (opzionale)
- Un corpo della funzione
- Un'istruzione di ritorno (opzionale)
- Una funzione in csharp deve avere il nome scritto in PascalCase
- Una variabile definita all'interno di una funzione è visibile solo all'interno di quella funzione

## Esempio di funzione void (senza ritorno senza parametri)
```csharp
// funzione che stampa un messaggio
void StampaMessaggio()
{
    Console.WriteLine("funzione void");
}
// chiamata della funzione
StampaMessaggio();
```
## Esempio di funzione void (senza ritorno con parametri)
```csharp
// funzione che stampa un messaggio con un parametro
void StampaMessaggioConParametro(string messaggio)
{
    Console.WriteLine(messaggio);
}
// chiamata della funzione con un parametro
StampaMessaggioConParametro("funzione void con parametro");
```
## Esempio di funzione void (senza ritorno con più parametri)
```csharp
// funzione che stampa un messaggio con due parametri
void StampaMessaggioConPiuParametri(string messaggio1, string messaggio2)
{
    Console.WriteLine($"{messaggio1} {messaggio2}");
}
// chiamata della funzione con due parametri
StampaMessaggioConPiuParametri("funzione void con","piu parametri");
```
//funzione che stampa un messaggio con due parametri di tipo diverso

```csharp
void StampaMessaggioConParametriDiversi(string messaggio, int numero)
{
    Console.WriteLine($"{messaggio} {numero}");
}
// chiamata della funzione con due parametri
StampaMessaggioConParametriDiversi("funzione void con", 2);

```

## Esempio di funzione void che manipola una lista
```csharp
List<string> lista = new List<string> {"elemento 1", "elemento 2", "elemento 3"};
List<string> lista2 = new List<string> {"elemento 4", "elemento 5"};

void StampaLista(List<string> lista)
{
    foreach (var item in lista)
    {
        Console.WriteLine(item);
    }
}
// chiamata della funzione con un lista
StampaLista(lista);
// chiamata della funzione con un'altra lista
StampaLista(lista2);
```

## Esempio di una funzione che somma due valori e restituisce il risultato
```csharp
int Somma(int a, int b)
{
    return a + b; // restituisco la somma dei due numeri
}
// chiamata della funzione Somma
int risultato = Somma(5, 10); // passo alla funzione Somma i due numeri da sommare
Console.WriteLine($"La somma di 5 e 10 è: {risultato}");
// stampo il risultato della somma
```
## Esempio di una funzione che restituisce un booleano
```csharp
// funzione che verifica se una parola ha un numero di lettere pari

bool ParolaPari(string parola)
{
    return parola.Length % 2 == 0; // restituisco true se la lunghezza della parola è pari
}
// chiamata della funzione ParolaPari
bool risultatoPari = ParolaPari("cane"); // utilizzo della funzioni
Console.WriteLine($"La parola ha un numero di lettere pari?{risultatoPari}"); // stampo il risultato della verifica
```
## Esempio di una funzione che restituisce una stringa
```csharp

// funzione che restituisce una stringa formattata
string FormattaMessaggio(string nome, int eta)
{
    return $"Ciao{nome}, hai {eta} anni"; // restituisco una stringa formattata
}
// chiamata deòòa funzione FormattaMessaggio
string messaggio = FormattaMessaggio("Utente 1", 30); // passo alla funzione i parametri
Console.WriteLine(messaggio); // stampo il messaggio formattato
```
## Esempio di una funzione con parametri out
```csharp
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

```
## Esempio di una funzione che trasmette il valore ad un altra
```csharp
int Doppio(int n)
{
    return n * 2; // resituisce il doppio di n
                  // il primo return e il valore che viene passato alla funzione Quadruplo
}
int Quadruplo(int n)
{
    return Doppio(n) * 2; // resituisce il doppio di n
                  // il primo return e il valore che viene passato alla funzione Quadruplo
}
int numero = 5; // numero da elaborare
int risultato2 = Quadruplo(numero); // Chiama la funzione Quadruplo con il numero
Console.WriteLine($"Il quadruplo di {Numero} è {risultato2}");
```
