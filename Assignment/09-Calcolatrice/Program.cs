bool continua = true; // variabile per controllare se l utente vuole continuare
while (continua)
{
    // chiedo all utente il primo numero
    Console.WriteLine("Inserisci il primo numero:");
    int primoNumero = int.Parse(Console.ReadLine()); // acquisisco l input dell utente e lo converto in un numero intero

    // chiedo all utente il secondo numero
    Console.WriteLine("Inserisci il secondo numero:");
    int secondoNumero = int.Parse(Console.ReadLine());

    // chiedo all utente l operazione da eseguire
    Console.WriteLine("Inserisci l'operazione da eseguire (+, -, *, /):");
    string operazione = Console.ReadLine();

    // verifico che l operazione sia valida
    if (operazione != "+" && operazione != "-" && operazione != "*" && operazione != "/")
    {
        Console.WriteLine("Operazione non valida.");
    }
    else
    {
        // se l operazione scelta dall utente è divisione
        // se il secondo numero è 0
        if (operazione == "/" && secondoNumero == 0)
        {
            // allora stampo un messaggio di errore
            Console.WriteLine("Errore: Divisione per zero non consentita.");
        }
        else
        {
            // altrimenti eseguo l operazione
            int risultato = 0;
            switch (operazione)
            {
                case "+":
                    risultato = primoNumero + secondoNumero;
                    break;
                case "-":
                    risultato = primoNumero - secondoNumero;
                    break;
                case "*":
                    risultato = primoNumero * secondoNumero;
                    break;
                case "/":
                    risultato = primoNumero / secondoNumero;
                    break;
                default:
                    Console.WriteLine("Operazione non valida.");
                    break;
            }
            // stampo il risultato
            Console.WriteLine($"Il risultato è: {risultato}");
        }
    }

    // chiedo all utente se vuole eseguire un altra operazione
    Console.WriteLine("Vuoi eseguire un'altra operazione? (si/no)");
    string risposta = Console.ReadLine();
    
    // se l utente risponde "si"
    if (risposta.ToLower() == "si")
    {
        continua = true; // continuo il ciclo
    }
    else
    {
        continua = false; // esco dal ciclo
        Console.WriteLine("Grazie per aver usato la calcolatrice!");
    }
}
```
## Suggerimenti per le funzioni
- Esempio di funzione per la somma
```csharp
int Somma(int a, int b)
{
    return a + b; // restituisco la somma dei due numeri
}
```
# Codice completo (con funzioni)
```csharp
// Calcolatrice

bool continua = true; // variabile per controllare se l'utente vuole continuare

while (continua)
{
    // chiedo all'utente il primo numero
    Console.WriteLine("Inserisci il primo numero:");
    int primoNumero = int.Parse(Console.ReadLine()); // acquisisco l'input dell'utente e lo converto in un numero intero

    // chiedo all'utente il secondo numero
    Console.WriteLine("Inserisci il secondo numero:");
    int secondoNumero = int.Parse(Console.ReadLine());

    // chiedo all'utente l'operazione da eseguire
    Console.WriteLine("Inserisci l'operazione da eseguire (+, -, *, /):");
    string operazione = Console.ReadLine();

    // verifico che l'operazione sia valida
    if (operazione != "+" && operazione != "-" && operazione != "*" && operazione != "/")
    {
        Console.WriteLine("Operazione non valida.");
    }
    else
    {
        // se l'operazione scelta dall'utente è divisione
        if (operazione == "/" && secondoNumero == 0)
        {
            // allora stampo un messaggio di errore
            Console.WriteLine("Errore: Divisione per zero non consentita.");
        }
        else
        {
            // altrimenti eseguo l'operazione
            int risultato = 0;
            switch (operazione)
            {
                case "+":
                    risultato = Somma(primoNumero, secondoNumero);
                    break;
                case "-":
                    risultato = Sottrai(primoNumero, secondoNumero);
                    break;
                case "*":
                    risultato = Moltiplica(primoNumero, secondoNumero);
                    break;
                case "/":
                    risultato = Dividi(primoNumero, secondoNumero);
                    break;
                default:
                    Console.WriteLine("Operazione non valida.");
                    break;
            }
            // stampo il risultato
            Console.WriteLine($"Il risultato è: {risultato}");
        }
    }

    // chiedo all'utente se vuole eseguire un'altra operazione
    Console.WriteLine("Vuoi eseguire un'altra operazione? (si/no)");
    string risposta = Console.ReadLine();
    
    // se l'utente risponde "si"
    if (risposta.ToLower() == "si")
    {
        continua = true; // continuo il ciclo
    }
    else
    {
        continua = false; // esco dal ciclo
    }
}
// Funzioni per le operazioni
int Somma(int a, int b)
{
    return a + b; // restituisco la somma dei due numeri
}
int Sottrai(int a, int b)
{
    return a - b; // restituisco la differenza dei due numeri
}
int Moltiplica(int a, int b)
{
    return a * b; // restituisco il prodotto dei due numeri
}
int Dividi(int a, int b)
{
    if (b == 0)
    {
        Console.WriteLine("Errore: Divisione per zero non consentita.");
        return 0; // restituisco 0 in caso di divisione per zero
    }
    return a / b; // restituisco il quoziente dei due numeri
}