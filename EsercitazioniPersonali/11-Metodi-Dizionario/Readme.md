# METODI DIZIONARIO

i metodi disponibili per manipolare i dizionari sono:

- Add
- ContainsKey
- ContainsValue
- Remove
- TryGetValue
- Clear

In un dizionario le chiavi sono uniche e non possono essere duplicate. I valori possono essere duplicati.

# Add
Aggiunge un elemento al dizionario. Se la chiave esiste già, il valore viene aggiornato.
```csharp
// dichiaro un dizionario int string

Dictionary<int, string> dizionario = new Dictionary<int, string>()
{
    {1, "Uno"},
    {2, "Due"},
    {3, "Tre"}
};

// aggiungo un elemento al dizionario

dizionario.Add(4, "Quattro");

// se la chiave esiste già, il valore viene aggiornato

dizionario.Add(1, "Uno Aggiornato"); // lancia un'eccezione
```
# ContainsKey
Verifica se una chiave esiste nel dizionario.

// verifico se in dizionario esiste la chiave 1

bool esisteChiave = dizionario.CointainsKey(1); // true

// verifico se in dizionario esiste la chiave 5

bool esisteChiave5 = dizionario.CointainsKey(5); // false

# ContainsValue
Verifica se un valore esiste nel dizionario.

// verifico se in dizionario esiste il valore "Uno"

bool esisteValore = dizionario.ContainsValue("Uno Aggiornato"); // true

// verifico se in dizionario esiste il valore "Cinque"

bool esisteValoreCinque = dizionario.ContainsValue("Cinque"); // false

# Remove
Rimuove un elemento dal dizionario in base alla chiave.Se la chiave non esiste, non viene fatto nulla

// rimuovo l'elemento con chiave 2

dizionario.Remove(2); // rimuove l'elemento con chiave 2

// rimuovo l'elemento con chiave 5 (non esiste)

dizionario.Remove(5); // non fa nulla

# TryGetValue
Prova a ottenere il valore associato a una chiave. Se la chiave esiste, restituisce true e il valore, altrimenti restituisce false e un valore predefinito.

// provo a ottenere il valore associato alla chiave 1

```csharp
if (dizionario.TryGetValue(1, out string valore1))
{
    Console.WriteLine($"Valore associato alla chiave 1: {valore1}"); // "Uno Aggiornato"
}
else
{
    Console.WriteLine("Chiave 1 non trovata");
}
```
# Clear
Rimuove tutti gli elementi dal dizionario.

// rimuovo tutti gli elementi dal dizionario

dizionario.Clear(); // dizionario ora è vuoto

## Dizionario di liste
Un dizionario può contenere come valori anche altre strutture di dati,come ad esempio una lista
```csharp
// dichiaro un dizionario int List<string>
Dictionary<int, List<string>> dizionarioListe = new Dictionary<int, List<string>>()
{
    {1, new List<string> {"nome","prezzo","quantità"}},
    {2, new List<string> {"nome"}},
    {3, new List<string> {"nome","prezzo",""}}
};
// aggiugno un elemento alla lista associata alla chiave 1

dizionarioListe[1].Add("quantita");

// posso aggiungere un elemento alla chiave 4
dizionarioListe.Add(4, new List<string> {"nome","prezzo","quantità"});

// stampo il dizionario
foreach (var kvp in dizionarioListe) // kvp sta per "key-value pair" ma posso mettere qualsiasi nome
{
    Console.WriteLine($"Chiave: {kvp.Key}, Valori: {string.Join(", ", kvp.Value)}");
}
// Output:
// Chiave: 1, Valori: nome, prezzo, quantità, quantita
// Chiave: 2, Valori: nome
// Chiave: 3, Valori: nome, prezzo,
// Chiave: 4, Valori: nome, prezzo, quantità
```
- Posso stampare un elemento specifico della lista associata a una chiave
```csharp
// stampo il primo elemento della lista associata alla chiave 1
Console.Writeline(dizionarioListe[1][0]); // output: nome
// posso stampare anche il secondo elemento della lista associata alla chiave 1
Console.Writeline(dizionarioListe.keys.ElementAt(1));  // output: 2 il (1) indica l'indice della chiave, non il valore
// posso stampare il valore della seconda coppia
Console.Writeline(string.Join(", ", dizionarioListe.Values.ElementAt(0))); // output: nome, prezzo, quantità, quantita
```


