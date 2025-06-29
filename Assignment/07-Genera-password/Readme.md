# Generatore di password

## Obiettivo

 Programma in C# che genera una password sicura basata sui seguenti criteri:

  La lunghezza della password deve essere compresa tra 5 ed 8 caratteri (scelta dall'utente).
- La password deve contenere almeno:
- 1 lettera maiuscola
- 1 lettera minuscola
- 1 numero
- 1 carattere speciale (es: @, #, !, ecc.).
- La password generata non deve contenere spazi.

## Suggerimenti
- Usa la classe Random per generare caratteri casuali.
- Puoi creare gruppi di caratteri (lettere maiuscole, minuscole, numeri e caratteri speciali) e selezionare casualmente un carattere da ciascun gruppo.
- L'utente deve poter scegliere la lunghexzza della password, che deve essere compresa tra 5 e 8 caratteri.

## Codice completo

```csharp
Console.Write("Inserisci la lunghezza della password (tra 5 e 8): ");
if (!int.TryParse(Console.ReadLine(), out int lunghezza) || lunghezza < 5 || lunghezza > 8)
{
    Console.WriteLine("Lunghezza non valida."); // Se l'input non è valido, esce dal programma
    return;
}

string caratteri = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789@#*!$%&";

Random random = new Random();

char[] password = new char[lunghezza]; // Inizializzo un array di caratteri della lunghezza specificata
password[0] = caratteri[random.Next(26)]; // Aggiungi una lettera maiuscola alla password
password[1] = caratteri[random.Next(26, 52)]; // Aggiungi una lettera minuscola alla password
password[2] = caratteri[random.Next(52, 62)]; // Aggiungi un numero alla password
password[3] = caratteri[random.Next(62, caratteri.Length)]; // Aggiungi un carattere speciale alla password

for (int i = 4; i < lunghezza; i++) // Riempi il resto della password
{
    password[i] = caratteri[random.Next(caratteri.Length)]; // Aggiungi caratteri casuali alla password fino a raggiungere la lunghezza richiesta
}

// OPZIONALE: Mischia i caratteri
// Mischia i caratteri
for (int i = password.Length - 1; i > 0; i--)  // faccio -- perchè voglio partire dall'ultimo carattere pero potrei partire anche dal primo
{
    (password[i], password[random.Next(i + 1)]) = (password[random.Next(i + 1)], password[i]); // Mischia i caratteri della password
}

Console.WriteLine($"La tua password generata è: {new string(password)}");
```