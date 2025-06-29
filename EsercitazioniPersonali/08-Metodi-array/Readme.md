# METODI ARRAY

I principali metodi per manipolare gli array sono:
- Length
- Copy
- Clear
- Reverse
- Sort
- IndexOf

## Definizione di un array di interi
```csharp
// definizione di un array di interi
int[] numeri = { 11, 12, 3, 41, 5 };
// oppure
int[] array = new int[5]; // dichiara un array di interi di lunghezza 5
```
## Accedere ad un elemento dell'array
```csharp
// accedere ad un elemento dell'array
Console.WriteLine(numeri[0]); // stampa 1
```
Se provo ad accedere ad un elemento che non esiste, il programma darà un errore di runtime. (un eccezione non gestita)
## Lunghezza dell'array
```csharp
// lunghezza dell'array
Console.WriteLine(numeri.Length); // stampa 5
// oppure usando l interpolazione di stringa
Console.WriteLine($"Lunghezza dell'array: {numeri.Length}"); // stampa 5
```
## Copiare un array
```csharp
// copiare un array
int[] numeri2 = new int[numeri.Length]; // devo dichiarare l array di destinazione con la stessa lunghezza di quello di origine
Array.Copy(numeri, numeri2, numeri.Length);
// oppure
numeri.CopyTo(numeri2, 0) // copio in numeri2 il contenuto di numeri partendo dall elemento con indice 0
Console.WriteLine(string.Join(", ", numeri2)); // .Join unisce gli elementi di un array in una stringa separati da una virgola
```
## Cancellare un array
```csharp
// resettare il valore degli elementi dell array
Array.Clear(numeri2, 0, numeri2.Length); // resetta i valori partendo dall indice 0 fino alla lunghezza dell array
Console.WriteLine(string.Join(", ", numeri2)); // stampa 0, 0, 0, 0, 0
// oppure
numeri2 = new int[0]; // cancella l array
Console.WriteLine(string.Join(", ", numeri2)); // stampa 0
```
## Ordinare un array
```csharp
// ordinare un array
Array.Sort(numeri2); // sort ordina l array in ordine crescente
Console.WriteLine(string.Join(", ", numeri2)); // stampa 3, 5, 11, 12, 41
```
## Invertire un array
```csharp
// invertire un array
Array.Reverse(numeri2); // reverse inverte l array
Console.WriteLine(string.Join(", ", numeri2)); // stampa 41, 12, 11, 5, 3
```
## IndexOf
```csharp
// restituisce l indice di un elemento in un array
int index = Array.IndexOf(numeri2, 12); // restituisce l indice dell elemento 12
Console.WriteLine(index); // stampa 1
// se ci sono più elementi uguali restituisce l indice del primo
// se non ci sono occorrenze dell elemento cercato restituisce -1
```