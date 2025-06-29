# ARRAY (Somma gli elementi di un array)
Calcola la somma di tutti gli elementi di un array di interi e stampa il risultato.

## Suggerimenti
- Inizializza una variabile per la somma a zero prima di iniziare il ciclo.
- Utilizza un ciclo `for` per iterare attraverso gli elementi dell'array.
- Aggiungi ogni elemento alla variabile somma durante l'iterazione. (usando +=)

## Esempio di codice (solo commenti)
```csharp
// Definisci un array di interi

// Inizializza la variabile somma a zero

// Utilizza un ciclo for per iterare attraverso gli elementi dell'array

// Aggiungi ogni elemento alla variabile somma

// Stampa il risultato finale
```

## Esempio di codice (completo)
```csharp
// Definisci un array di interi
int[] numeri = { 1, 2, 3, 4, 5 };

// Inizializza la variabile somma a zero
int somma = 0;

// Utilizza un ciclo for per iterare attraverso gli elementi dell'array
for (int i = 0; i < numeri.Length; i++)
{
    // Aggiungi ogni elemento alla variabile somma
    somma += numeri[i];
}
// Stampa il risultato finale
Console.WriteLine($"La somma degli elementi dell'array è: {somma}");
```
## ARRAY (Stampa i numeri pari)
Scrivi un programma che stampa solo i numeri pari da un array di interi.

## Suggerimenti
- Utilizza un ciclo `for` per iterare attraverso gli elementi dell'array.
- Utilizza un'istruzione `if` per controllare se un numero è pari (utilizzando l'operatore modulo `%`).

## Esempio di codice (solo commenti)
```csharp
// Definisci un array di interi

// Utilizza un ciclo for per iterare attraverso gli elementi dell'array

// Utilizza un'istruzione if per controllare se un numero è pari

// Stampa il numero se è pari
```

## Esempio di codice (completo)
```csharp
// Definisci un array di interi
int[] numeri = { 1, 2, 3, 4, 5 };
// Utilizza un ciclo for per iterare attraverso gli elementi dell'array
for (int i = 0; i < numeri.Length; i++)
{
    // Utilizza un'istruzione if per controllare se un numero è pari
    if (numeri[i] % 2 == 0)
    {
        // Stampa il numero se è pari
        Console.WriteLine($"Il numero {numeri[i]} è pari.");
    }
}
```
# ARRAY (Ricerca di un valore in un array)
Scrivi un programma che cerca un valore specifico in un array di interi e stampa la posizione dell'elemento trovato. Se l'elemento non viene trovato, stampa un messaggio appropriato.
## Suggerimenti
- Utilizza un ciclo `for` per iterare attraverso gli elementi dell'array.
- Se trovi l'elemento, stampa la posizione e interrompi il ciclo.
- Se il ciclo termina senza trovare l'elemento, stampa un messaggio che indica che l'elemento non è stato trovato.

## Esempio di codice (solo commenti)
```csharp
// Definisci un array di interi

// Definisci il valore da cercare

// Inizializza una variabile per tenere traccia della posizione trovata

// Utilizza un ciclo for per iterare attraverso gli elementi dell'array

// Confronta ogni elemento con il valore cercato

// Se trovi l'elemento, stampa la posizione e interrompi il ciclo

// Se il ciclo termina senza trovare l'elemento, stampa un messaggio che indica che l'elemento non è stato trovato
```
## Esempio di codice (completo)
```csharp
// Definisci un array di interi
int[] numeri = { 1, 2, 3, 4, 5 };
// Definisci il valore da cercare
int valoreDaCercare = 3;
// Inizializza una variabile per tenere traccia della posizione trovata
int posizioneTrovata = -1;
// Utilizza un ciclo for per iterare attraverso gli elementi dell'array
for (int i = 0; i < numeri.Length; i++)
{
    // Confronta ogni elemento con il valore cercato
    if (numeri[i] == valoreDaCercare)
    {
        // Se trovi l'elemento, stampa la posizione e interrompi il ciclo
        posizioneTrovata = i;
        break;
    }
}
// Se il ciclo termina senza trovare l'elemento, stampa un messaggio che indica che l'elemento non è stato trovato
if (posizioneTrovata != -1)
{
    Console.WriteLine($"Il valore {valoreDaCercare} è stato trovato alla posizione {posizioneTrovata}.");
}
else
{
    Console.WriteLine($"Il valore {valoreDaCercare} non è stato trovato nell'array.");
}
```
# ARRAY (Invertire un array)
Scrivi un programma che inverte gli elementi di un array di interi e stampa l'array invertito.
## Suggerimenti
- Crea un nuovo array della stessa lunghezza dell'array originale.
- Utilizza un ciclo `for` per copiare gli elementi dall'array originale all'array invertito, partendo dalla fine dell'array originale.
- Stampa l'array invertito.
## Esempio di codice (solo commenti)
```csharp
// Definisci un array di interi

// Crea un nuovo array della stessa lunghezza dell'array originale

// Utilizza un ciclo for per copiare gli elementi dall'array originale all'array invertito, partendo dalla fine dell'array originale

// Stampa l'array invertito
```
## Esempio di codice (completo)
```csharp
// Definisci un array di interi
int[] numeri = { 1, 2, 3, 4, 5 };
// Crea un nuovo array della stessa lunghezza dell'array originale
int[] numeriInvertiti = new int[numeri.Length];
// Utilizza un ciclo for per copiare gli elementi dall'array originale all'array invertito, partendo dalla fine dell'array originale
for (int i = 0; i < numeri.Length; i++)
{
    numeriInvertiti[i] = numeri[numeri.Length - 1 - i];
}
// Stampa l'array invertito
Console.WriteLine("Array invertito: " + string.Join(", ", numeriInvertiti));
```
# ARRAY (Esercizio completo con interattività)
Scrivi un programma che:
- chieda all'utente di inserire un numero di elementi per un array
- chieda all'utente di inserire ciascun elemento.
- chieda all'utente di inserire un numero da cercare nell'array.
- scorra gli elementi con un `foreach` e, se trovi il valore, stampa “Trovato in posizione X” (prima occorrenza) e interrompi la ricerca; altrimenti “Non trovato”.
## Suggerimenti
- Utilizza `Console.ReadLine()` per leggere l'input dell'utente.
- Utilizza `int.Parse()` per convertire l'input dell'utente in un numero intero.
- Utilizza un ciclo `foreach` per scorrere gli elementi dell'array.

## Esempio di codice (solo commenti)
```csharp
// Chiedi all'utente di inserire un numero di elementi per un array

// Crea un array della lunghezza specificata dall'utente

// Chiedi all'utente di inserire ciascun elemento

// Chiedi all'utente di inserire un numero da cercare nell'array

// Scorri gli elementi con un foreach

// Se trovi il valore, stampa "Trovato in posizione X" e interrompi la ricerca

// Altrimenti, stampa "Non trovato"
```
## Esempio di codice (completo)
```csharp
// Chiedi all'utente di inserire un numero di elementi per un array
Console.Write("Inserisci il numero di elementi per l'array: ");
int numeroElementi = int.Parse(Console.ReadLine());
// Crea un array della lunghezza specificata dall'utente
int[] numeri = new int[numeroElementi];
// Chiedi all'utente di inserire ciascun elemento
for (int i = 0; i < numeroElementi; i++)
{
    Console.Write($"Inserisci l'elemento {i + 1}: ");
    numeri[i] = int.Parse(Console.ReadLine());
}
// Chiedi all'utente di inserire un numero da cercare nell'array
Console.Write("Inserisci il numero da cercare nell'array: ");
int numeroDaCercare = int.Parse(Console.ReadLine());
// Scorri gli elementi con un foreach
bool trovato = false;
foreach (int numero in numeri)
{
    // Se trovi il valore, stampa "Trovato in posizione X" e interrompi la ricerca
    if (numero == numeroDaCercare)
    {
        Console.WriteLine($"Trovato in posizione {Array.IndexOf(numeri, numero)}");
        trovato = true;
        break;
    }
}
// Altrimenti, stampa "Non trovato"
if (!trovato)
{
    Console.WriteLine("Non trovato");
}
```