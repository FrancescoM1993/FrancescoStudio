# METODI LISTA

I metodi disponibili per le liste sono:

- Add -> con gli array non esiste si usa solo l'operatore di assegnazione += [i]
- Count -> con gli array non esiste perché è lenghth
- AddRange
- Contains
- IndexOf
- Sort
- Remove
- RemoveAt
- ToArray
- TrimExcess
- Clear

## Add

Se la lista è già piena,viene automaticamente ridimensionata per accogliere il nuovo elemento.

```csharp
// creazione di una lista di interi vuota
List<int> numeri = new List<int>();
// aggiunta di 20 elementi alla lista
for (int i = 0; i < 20; i++)
{
    numeri.Add(i);
}
// creazione di una lista già piena
List<int> numeri2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
```

## Count 

Il metodo Count restituisce il numero di elementi presenti nella lista.

```csharp   
numeri.Count // Stampa 10
Console.WriteLine(numeri.Count); // Stampa 10 
```
## AddRange

Il metodo AddRange consente di aggiungere più elementi alla lista in un'unica operazione.

```csharp
numeri.AddRange(new int[] { 11, 12, 13, 14, 15 });
Console.WriteLine(numeri.Count); // Stampa 15
```
Permette di aggiungere anche un'altra lista.

```csharp
numeri.AddRange(numeri2);
Console.WriteLine(numeri.Count); // Stampa 25
```
## Contains
Il metodo Contains permette di verificare se un elemento è presente nella lista. (restituisce un booleano).

```csharp
Console.WriteLine(numeri.Contains(5)); // Stampa True 
Console.WriteLine(numeri.Contains(30)); // Stampa False
```
## IndexOf
Il metodo IndexOf restituisce l'indice della prima occorrenza di un elemento nella lista. Se l'elemento non è presente, restituisce -1(importante).

```csharp
Console.WriteLine(numeri.IndexOf(5)); // Stampa 5
Console.WriteLine(numeri.IndexOf(30)); // Stampa -1
```
## Sort
Il metodo Sort ordina gli elementi della lista in ordine crescente. 
```csharp
numeri.Sort();
Console.WriteLine(numeri[0] // Stampa 1
Console.WriteLine(numeri[numeri.Count - 1]) // Stampa 25
```
## Remove
Il metodo Remove permette di rimuovere un elemento dalla lista (restituisce un booleano) 

Console.Writeline(numeri.Remove(5)); // true
Console.Writeline(numeri.Remove(30)); // false
Console.Writeline(numeri.Count); // 24

## Removeat

Il metodo RemoveAt permette di rimuovere un elemento dalla lista in base all'indice
```csharp
numeri.RemoveAt(0); // rimuove il primo elemento (1)
Console.Writeline(numeri[0]), // 2
Console.Writeline(numeri.Count); // 23
```

## Trimexcess

Il metodo TrimExcess permette di ridurre la capacità della lista alla dimensione attuale
```csharp
numeri.Trimexcess();
Console.WriteLine(numeri.Capacity) // 23
```
## Toarray

Il metodo ToArray permette di convertire la lista in un array
```csharp
int[] arrayNumer = numeri.ToArray();
Console.Writeline(arrayNumeri.Lenght); // 23
```
## Clear

Il metodo Clear permetti di rimuovere tutti gli elementi dalla lista

numeri.Clear();
Console.WriteLine(numeri.count); // 0