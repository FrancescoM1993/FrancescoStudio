# METODI STRINGA

I tipi di dato stringa hanno dei metodi che permettoni di eseguire operazioni su di essi (manipolazioni) o di ottenere informazioni.

// lenght
// prende la lunghezza della stringa

```csharp
string nome = "Nome1";
int lunghezza = nome.Length;
Console.WriteLine(lunghezza); // output: 5
``` 
// isnullorwhitespace
// verifica se la stringa è null o contiene solo spazi bianchi

```csharp
string nome = "Nome1";
Console.WriteLine(string.IsNullOrWhiteSpace(nome)); // output: false
``` 
// isnullorempty
// verifica se la stringa è null o vuota

```csharp   
Console.WriteLine(string.IsNullOrEmpty(nome)); // output: false
``` 
// tolower
// converte la stringa in minuscolo

```csharp   
Console.WriteLine(nome.ToLower()); // output: nome1
``` 
// toupper
// converte la stringa in maiuscolo

```csharp   
Console.WriteLine(nome.ToUpper()); // output: NOME1
``` 
// trim
// rimuove gli spazi bianchi all'inizio e alla fine della stringa

```csharp   
Console.WriteLine(nome.Trim()); // output: Nome1
```
// split
// divide la stringa in un array di stringhe in base a un delimitatore

```csharp
string nome = "Nome1 Nome2 Nome3";
string[] nomiarray = nome.Split(", ");
foreach (string n in nomiarray)
{
    Console.WriteLine(n);
} // output: Nome1 Nome2 Nome3
```
// join
// unisce un array di stringhe in una sola stringa usando un delimitatore

```csharp   
string[] nomiarray = { "Nome1", "Nome2", "Nome3" };
string nomiUniti = string.Join(", ", nomiarray);
Console.WriteLine(nomiUniti);  // output: Nome1, Nome2, Nome3
``` 

// replace
// sostituisce una parte della stringa con un'altra stringa

```csharp
string sostituzione = nome.replace("Nome1", "Cognome");
Console.WriteLine(sostituzione); // output: Cognome
// oppure
Console.WriteLine(nome.Replace("Nome1", "Nome2")); // output: Nome2 
```
// substring
// restituisce una parte della stringa a partire da un indice

```csharp
Console.WriteLine(nome.Substring(0, 2)); // output: No // (lo 0 da dove parte dal nome e il 2 è la lunghezza)
```
// contains
// verifica se la stringa contiene una sottostringa

```csharp
Console.WriteLine(nome.Contains("nom")); // output: true // contiene "nom" quindi mi trova nome1 della stringa e cognome
```
// startswith
// verifica se la stringa inizia con una sottostringa

```csharp
Console.WriteLine(nome.StartsWith("nom")); // output: true // inizia con "nom" quindi mi trova nome1 della stringa
```
// endswith
// verifica se la stringa finisce con una sottostringa

```csharp
Console.WriteLine(nome.EndsWith("ome")); // output: true // finisce con "me" quindi mi trova nome della stringa e cognome
```
// tostring
// converte un tipo di dato in una stringa

```csharp
int numero = 10;
string numeroStringa = numero.ToString();
Console.WriteLine(numeroStringa); // output: 10
``` 
// parse
// converte una stringa in un tipo di dato

```csharp
string numeroDaConvertireParse = "10";
int numeroConvertitoParse = int.Parse(numeroDaConvertireParse);
Console.WriteLine(numeroConvertitoTryParse); // output: 10
```
// tryparse
// converte una stringa in un tipo di dato e restituisce un valore booleano che indica se la conversione è riuscita o meno

```csharp
string numeroDaConvertireTryParse = "10";
int numeroConvertitoTryParse;
bool risultato = int.TryParse(numeroDaConvertireTryParse, out numeroConvertitoTryParse);
Console.WriteLine(conversione); // output: true
Console.WriteLine(numeroConvertitoTryParse); // output: 10
```
// double
// converte una stringa in un double

```csharp
string numeroDaConvertireTryParse = "10,40";
double numeroConvertitoTryParse;
bool risultato = double.TryParse(numeroDaConvertireTryParse, out numeroConvertitoTryParse);
Console.WriteLine(conversione); // output: true
Console.WriteLine(numeroConvertitoTryParse); // output: 10.40
```

// convert
// converte un tipo di dato in un altro tipo di dato

```csharp
int numeroDaConvertire = 10;
string numeroConvertito = Convert.ToString(numeroDaConvertire);
Console.WriteLine(numeroConvertito); // output: 10
```
// oppure (se la conversione non è possibile viene generata un'eccezione di tipo InvalidCastException ed il programma si blocca)
```csharp
string numeroDaConvertire = "10";
int numeroConvertito = Convert.ToInt32(numeroDaConvertire); // toInt32 capienza toInt64 ancora piu grande toInt16 piu piccolo ecc
Console.WriteLine(numeroConvertito); // output: 10
```
// format
// formatta una stringa usando dei segnaposto con degli indici

```csharp
string nome = "Nome";
int eta = 10;
string frase = string.Format("Il partecipante si chiama {0} e ha {1} anni", nome, eta);
Console.WriteLine(frase); // output: Il partecipante si chiama Nome e ha 10 anni
```
# FORMAY (Versione 2)
In questa versione usiamo un dizionario invece di due collezioni separate
```csharp
Dictionary<string, string> dizionario = new Dictionary<string, string>();
dizionario.Add("Nome", "Nome");
dizionario.Add("Eta", "10");
string frase = string.Format("Il partecipante si chiama {Nome} e ha {Eta} anni", dizionario);
Console.WriteLine(frase); // output: Il partecipante si chiama Nome e ha 10 anni
``` 
