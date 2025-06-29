// METODI ARRAY

/*
I principali metodi per gli array sono:
- Length
- Copy
- Clear
- Sort
- Reverse
- IndexOf
*/

// Definizione di un array di interi
int[] numeri = { 11, 12, 3, 41, 5 };

// Accedere ad un elemento dell'array
Console.WriteLine(numeri[0]); // Stampa 1

// Se provo ad accedere ad un elemento che non esiste, ottengo un errore di runtime (un eccezione non gestita)

// #Lunghezza dell'array
Console.WriteLine(numeri.Length); // Stampa 5
// oppure usando l interpolazione di stringhe
Console.WriteLine($"Lunghezza dell'array: {numeri.Length}");

// #Copia dell'array
int[]  numeri2 = new int[numeri.Length];
Array.Copy(numeri, numeri2, numeri.Length); // Devo dichiarare l'array di destinazione con la stessa lunghezza dell'array di origine
// oppure
numeri.CopyTo(numeri2, 0); // Copia l'array numeri in numeri2 a partire dalla posizione 0
Console.WriteLine(string.Join(", ", numeri2)); // Stampa 11, 12, 3, 41, 5 (.Join unisce gli elementi dell'array in una stringa separata da una virgola)

// #Clear
// Resettare il valore degli elementi dell'array 
Array.Clear(numeri2, 0, numeri2.Length); // Pulisce l'array a partire dalla posizione 0 per la lunghezza dell'array
Console.WriteLine(string.Join(", ", numeri2)); // Stampa 0, 0, 0, 0, 0 (tutti gli elementi dell'array sono stati azzerati)
// Oppure
numeri2 = new int[0]; // Inizializza l'array a zero
Console.WriteLine(string.Join(", ", numeri2)); // Stampa 0

// #Ordinare un array
Array.Sort(numeri2); // Ordina l'array in ordine crescente
Console.WriteLine(string.Join(", ", numeri2)); // Stampa 3, 5, 11, 12, 41

// #Invertire un array 
Array.Reverse(numeri2); // Inverte l'array
Console.WriteLine(string.Join(", ", numeri2)); // Stampa 41, 12, 11, 5, 3 // Inverte l'array ma se io nn avessi fatto il sort prima, l'array sarebbe rimasto in ordine casuale

// #IndexOf 
// Restituisce la posizione del primo elemento trovato nell'array
int posizione = Array.IndexOf(numeri2, 12); // Restituisce la posizione del primo elemento trovato nell'array
Console.WriteLine($"Posizione di 12: {posizione}"); // Stampa Posizione di 12: 1

// Se ci sono più elementi uguali, restituisce la posizione del primo trovato
// Se l'elemento non è presente, restituisce -1


