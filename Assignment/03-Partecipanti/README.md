#   ELENCO PARTECIPANTI

- Programma che chiede all'utente di inserire il nome di una serie di partecipanti fino a quando non scriverà "fine".
- Quando l'utente scrive "fine", il programma stampa l'elenco dei partecipanti.

## Suggerimenti

- Utilizzare una lista per memorizzare i nomi dei partecipanti.
- Utilizzare un ciclo `while` per continuare a chiedere i nomi fino a quando non viene inserito "fine".
- Utilizzare il metodo `Add` della lista per aggiungere i nomi alla lista.
- Utilizzare un ciclo `foreach` per stampare i nomi dei partecipanti alla fine.

> TODO: Assicurati di gestire correttamente il caso in cui l'utente non inserisca alcun nome.

## Esempio di codice

// Inizializza una lista di stringhe per memorizzare i nomi dei partecipanti


// Inizializza una variabile per memorizzare il nome dell'utente

// Inizializza un ciclo while per chiedere i nomi dei partecipanti

// Chiedi all'utente di inserire un nome

// Aggiungi il nome alla lista dei partecipanti

// Se l'inserimento dell'utente è "fine", esci dal ciclo

// Stampa l'elenco dei partecipanti

### Esempio di codice (completo)
```csharp
partecipanti = new List<string>(); // Inizializza una lista di stringhe per memorizzare i nomi
string nome; // Inizializza una variabile per il nome che l utente inserirà
while (true) // Inizia un ciclo while
{
    Console.WriteLine("Inserisci il nome del partecipante (o scrivi 'fine' per terminare):"); // Chiedi all utente di inserire un nome
    nome = Console.ReadLine(); // Acquisisci l input dell utente
    if (nome.ToLower() == "fine") // Se l inserimento dell utente è "fine", esci dal ciclo
    {
        break; // Esci dal ciclo
    }
    partecipanti.Add(nome); // Aggiungi il nome alla lista
}
// Stampa l elenco dei partecipanti
Console.WriteLine("Elenco dei partecipanti:");
foreach (string partecipante in partecipanti) // Per ogni partecipante nella lista
{
    Console.WriteLine(partecipante); // Stampa il nome del partecipante
}
```

#   ELENCO PARTECIPANTI (Versione 2)

In questa versione vengono create due liste che rappresentano due squadre.
- La prima lista cpntiene i nomi dei partecipanti della prima squadra
- La seconda lista contiene i nomi dei partecipanti della seconda squadra.Ogni volta che l'utente inserisce un nome, il programma chiede a quale squadra appartiene e lo aggiungere il partecipante

## Suggerimenti
- Utilizzare due liste per memorizzare i nomi dei partecipanti delle due squadre.
- Utilizzare dei nomi significativi per le liste.

## Esempio di codice (solo commenti)
// Inizializza due liste di stringhe per memorizzare i nomi dei partecipanti delle due squadre
// Inizializza una variabile per memorizzare il nome dell'utente

// Inizializza un ciclo while per chiedere i nomi dei partecipanti

// Chiedi all'utente di inserire un nome

// Chiedi all'utente a quale squadra appartiene il partecipante

// Aggiungi il nome alla lista della squadra corrispondente

// Se l'inserimento dell'utente è "fine", esci dal ciclo

// Stampa l'elenco dei partecipanti di entrambe le squadre

### Esempio di codice (completo)
```csharp
List<string> squadra1 = new List<string>(); // Inizializza una lista di stringhe per memorizzare i nomi dei partecipanti della prima squadra

List<string> squadra2 = new List<string>(); // Inizializza una lista di stringhe per memorizzare i nomi dei partecipanti della seconda squadra
string nome; // Inizializza una variabile per il nome che l utente inserirà
while (true) // Inizia un ciclo while
{
    Console.WriteLine("Inserisci il nome del partecipante (o scrivi 'fine' per terminare):"); // Chiedi all utente di inserire un nome
    nome = Console.ReadLine(); // Acquisisci l input dell utente
    if (nome.ToLower() == "fine") // Se l inserimento dell'utente è "fine", esci dal ciclo
    {
        break; // Esci dal ciclo
    }
    Console.WriteLine("A quale squadra appartiene? (1 o 2)"); // Chiedi all utente a quale squadra appartiene il partecipante
    string squadra = Console.ReadLine(); // Acquisisci l input dell utente
    if (squadra == "1") // Se la squadra è 1
    {
        squadra1.Add(nome); // Aggiungi il nome alla lista della prima squadra
    }
    else if (squadra == "2") // Se la squadra è 2
    {
        squadra2.Add(nome); // Aggiungi il nome alla lista della seconda squadra
    }
}
// Stampa l elenco dei partecipanti di entrambe le squadre
Console.WriteLine("Elenco dei partecipanti della squadra 1:"); // Stampa l elenco dei partecipanti della prima squadra
foreach (string partecipante in squadra1) // Per ogni partecipante nella lista della prima squadra
{
    Console.WriteLine(partecipante); // Stampa il nome del partecipante
}
Console.WriteLine("Elenco dei partecipanti della squadra 2:"); // Stampa l elenco dei partecipanti della seconda squadra
foreach (string partecipante in squadra2) // Per ogni partecipante nella lista della seconda squadra
{
    Console.WriteLine(partecipante); // Stampa il nome del partecipante
}
```

