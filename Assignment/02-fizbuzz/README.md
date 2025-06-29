# FIZZBUZZ

il FizzBuzz è un problema comune di programmazione che viene spesso utilizzato nelle interviste tecniche. Il compito è:

- stampare i numeri da 1 a 100, ma:
- per i multipli di 3 stampare "Fizz" invece del numero
- per i multipli di 5 stampare "Buzz"
- per i multipli di 3 e 5 stampare "FizzBuzz" invece del numero

## Suggerimenti
- Utilizza un ciclo `for` per iterare da 1 a 100.
- Utilizza l'operatore modulo `%` per verificare se un numero è multiplo di 3 o 5.
- Utilizzare un'istruzione `if` per controllare le condizioni e stampare il risultato corretto.
- Assicurati di stampare il numero se non è un multiplo di 3 o 5.

## Esempio di codice (solo commenti)

// Inizializza un ciclo for da 1 a 100

// Controlla se il numero è divisibile per 3 e 5
// Se sì, stampa "FizzBuzz"

// Controlla se il numero è divisibile per 3
// Se sì, stampa "Fizz"

// Controlla se il numero è divisibile per 5
// Se sì, stampa "Buzz"

// Altrimenti, stampa il numero

### Esempio di codice (completo)
```csharp
// Inizializza un ciclo da 1 a 100
for (int i = 1; i <= 100; i++)
{
    // Controlla se i è un multiplo di 3 e 5
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    // Controlla se i è un multiplo di 3
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    // Controlla se i è un multiplo di 5
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    // Se non è un multiplo di nessuno dei due, stampa il numero
    else
    {
        Console.WriteLine(i);
    }
}
```

# FIZZBUZZ (Versione 2)
Implementaziione della prima versione del programma FizzBuzz:
- il programma chiede all'utente di inserire il numero ( quindi un numero qualsiasi ) 
- Il programma scrive se il numero è Fizz,Buzz o FizzBuzz
## Suggerimenti
- Utilizza un ciclo `while` per continuare a chiedere all'utente di inserire un numero fino a quando non decide di terminare.
- Utilizza i metodi di console per acquisire l'input dell'utente.