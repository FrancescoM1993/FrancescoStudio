# FORMAT
Adattare il seguente metodo format per formattare le stringhe:
```csharp
string nome = "Nome";
int eta = 10;
string frase = string.Format("Il partecipante si chiama {0} e ha {1} anni.", nome, eta);
Console.WriteLine(frase); // output: Il partecipante si chiama Nome e ha 10 anni.
```
Ad una collezione di nomi ed età.

Otterro piu frasi ognuna riferita ad un elemento della collezione diverso

## Suggerimenti
- Esempio di collezione di nomi
```csharp
string [] nomi = { "Nome1", "Nome2", "Nome3" };
```
- Esempio di collezione di età
```csharp
int [] eta = { 10, 20, 30 };
```
- Uso il ciclo foreach (o for) per iterare su ogni elemento della collezione
```csharp
foreach (var nome in nomi)
{
    // codice da eseguire per ogni elemento della collezione
}
```
## Codice (solo commenti)
```csharp
// dichiarazione di una collezione di nomi

// dichiarazione di una collezione di età

// ciclo foreach per iterare su ogni elemento della collezione

// formattazione della stringa con il metodo string.Format

// stampa della stringa formattata ad ogni iterazione
```
## Codice completo
For
```csharp
string[] nomi = { "Nome1", "Nome2", "Nome3" }; // dichiarazione di una collezione di nomi
int[] eta = { 10, 20, 30 }; // dichiarazione di una collezione di età
for (int i = 0; i < nomi.Length; i++) // ciclo for per iterare su ogni elemento della collezione
{
    string frase = string.Format("Il partecipante si chiama {0} e ha {1} anni.", nomi[i], eta[i]);
    Console.WriteLine(frase); // stampa della stringa formattata ad ogni iterazione
}
```
Con una lista
```csharp
List<string> nomi = new List<string>() { "Nome1", "Nome2", "Nome3" }; // dichiarazione di una collezione di nomi
List<int> eta = new List<int>() { 10, 20, 30 }; // dichiarazione di una collezione di età
for (int i = 0; i < nomi.Count; i++) // ciclo for per iterare su ogni elemento della collezione
{
    string frase = string.Format("Il partecipante si chiama {0} e ha {1} anni.", nomi[i], eta[i]);
    Console.WriteLine(frase); // stampa della stringa formattata ad ogni iterazione
}
```
Foreach
```csharp
string[] nomi = { "Nome1", "Nome2", "Nome3" };
int[] eta   = { 10, 20, 30 };

int i = 0;
foreach (var nome in nomi)
{
    string frase = string.Format("Il partecipante si chiama {0} e ha {1} anni.", nome, eta[i]);
    Console.WriteLine(frase); // stampa della stringa formattata ad ogni iterazione
    i++;
}
```
# FORMAT (Versione 2)
In questa versione usiamo un dizionario invece di due collezioni separate
```csharp
Dictionary<string, int> partecipanti = new Dictionary<string, int>()
{
    { "Nome1", 10 },
    { "Nome2", 20 },
    { "Nome3", 30 }
};
foreach (var partecipante in partecipanti)
{
    string frase = string.Format("Il partecipante si chiama {0} e ha {1} anni.", partecipante.Key, partecipante.Value);
    Console.WriteLine(frase); // stampa della stringa formattata ad ogni iterazione
}
```