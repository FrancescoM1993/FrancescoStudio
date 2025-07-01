//Calcolatrice
while (true)
{
    Console.WriteLine("Ciao Benvenuto");

    Console.WriteLine("Quale primo numero vuoi inserire?");
    int Numero1 = int.Parse(Console.ReadLine());
    // chiedo all'utente di inserire il primo numero
    Console.WriteLine("Quale secondo numero vuoi inserire?");
    int Numero2 = int.Parse(Console.ReadLine());
    // chiedo all'utente di inserire il secondo numero
    Console.WriteLine("Quale operazione vuoi eseguire? (+, -, x, /)");
    string Operazione = Console.ReadLine();
    // chiedo all'utente di inserire l'operazione da eseguire

    // if(Operazione != "+" && Operazione != "-" && Operazione != "x" && Operazione != "/")
    // Console.WriteLine("Operazione non valida"); questa riga non serve più perché l'abbiamo già gestita con il default del case in basso

    switch (Operazione)
    {
        case "+":
            // eseguo la somma
            int prodotto = Numero1 + Numero2;
            Console.WriteLine($"Il risultato della somma è {prodotto}");
            break;
        case "-":
            // eseguo la sottrazione
            int differenza = Numero1 - Numero2;
            Console.WriteLine($"Il risultato della sottrazione è {differenza}");
            break;
        case "x":
            // eseguo la moltiplicazione
            int moltiplicazione = Numero1 * Numero2;
            Console.WriteLine($"Il risultato della moltiplicazione è {moltiplicazione}");
            break;
        case "/":
            // verifico se il secondo numero è uguale a 0 o meno di 0
            if (Numero2 == 0)
            {
                // stampo un messaggio di errore
                Console.WriteLine("Errore: divisione per zero");
            }
            else if (Numero2 < 0)
            {
                // stampo un messaggio di errore
                Console.WriteLine("Errore: divisione per numero negativo");
            }
            else if (Numero2 > 0)
            {
                // eseguo la divisione
                int divisione = Numero1 / Numero2;
                Console.WriteLine($"Il risultato della divisione è {divisione}");
            }
            break;
        default:
            // stampo un messaggio di errore
            Console.WriteLine("Operazione non valida");
            break;
    }

    Console.WriteLine("Esci dal ciclo premendo (n)");
    string risposta = Console.ReadLine();
    if (risposta.ToLower() == "n")
    {
        Console.WriteLine("Grazie per aver usato la calcolatrice");
        break; 
    }

}

/*
Console.WriteLine("Ciao Benvenuto");

Console.WriteLine("Quale primo numero vuoi inserire?");
int Numero1 = int.Parse (Console.ReadLine());
// chiedo all'utente di inserire il primo numero
Console.WriteLine("Quale secondo numero vuoi inserire?");
int Numero2 = int.Parse (Console.ReadLine());
// chiedo all'utente di inserire il secondo numero
Console.WriteLine("Quale operazione vuoi eseguire? (+, -, x, /)");
string Operazione = Console.ReadLine();
// chiedo all'utente di inserire l'operazione da eseguire

// if(Operazione != "+" && Operazione != "-" && Operazione != "x" && Operazione != "/")
// Console.WriteLine("Operazione non valida"); questa riga non serve più perché l'abbiamo già gestita con il default del case in basso

switch (Operazione)
{
    case "+":
        // eseguo la somma
        int prodotto = Numero1 + Numero2;
        Console.WriteLine($"Il risultato della somma è {prodotto}");
        break;
    case "-":
        // eseguo la sottrazione
        int differenza = Numero1 - Numero2;
        Console.WriteLine($"Il risultato della sottrazione è {differenza}");
        break;
    case "x":
        // eseguo la moltiplicazione
        int moltiplicazione = Numero1 * Numero2;
        Console.WriteLine($"Il risultato della moltiplicazione è {moltiplicazione}");
        break;
    case "/":
        // verifico se il secondo numero è uguale a 0 o meno di 0
        if (Numero2 == 0)
        {
            // stampo un messaggio di errore
            Console.WriteLine("Errore: divisione per zero");
        }
        else if (Numero2 < 0)
        {
            // stampo un messaggio di errore
            Console.WriteLine("Errore: divisione per numero negativo");
        }
        else if (Numero2 > 0)
        {
            // eseguo la divisione
            int divisione = Numero1 / Numero2;
            Console.WriteLine($"Il risultato della divisione è {divisione}");
        }
        break;
    default:
        // stampo un messaggio di errore
        Console.WriteLine("Operazione non valida");
        break;



}

*/

