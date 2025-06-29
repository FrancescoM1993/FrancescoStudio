# GESTIONE DATE     
Le date dipendono dalla localizzazione del sistema operativo,quindi è importante considerare il fuso orario e le impostazioni locali quando si lavora con le date in C#.
```csharp
DateTime birthDate = new DateTime(1990, 1, 1); // Inserisci la tua data
// il costruttore di Datetime accetta tre parametri: anno, mese e giorno
Console.WriteLine($"Sei nato il {birthDate}") // Stampa la data di nascita

DateTime today = DateTime.Today; // Oggi
Console.WriteLine($"Oggi è {oggi}"); // Stampa la data odierna 
Console.WriteLine($"Oggi è {oggi.ToShortDateString()}"); // Stampa la data odierna in formato breve
Console.WriteLine($"Oggi è {oggi.ToLongDateString()}"); // Stampa la data odierna in formato lunga
Console.WriteLine($"Oggi è {oggi.ToLongDateString(""dd/MM/yyyy")};

//dd rappresenta il giorno inteso come numero a due cifre, MM il mese a due cifre e yyyy L anno a 4 cifre
//M il mese a una cifra //d il giorno a una cifra //y l anno a una cifra
// dddd il giorno della settimaa a Lungo // ddd il giorno corto
// MMMM il mese a lungo // MMM il mese in breve
// yyyy l anno a quattro cifre, // yy l anno a due cifre

Console.WriteLine($"Il giorno della settimana e: {birthDate.Dayofweek}")

```