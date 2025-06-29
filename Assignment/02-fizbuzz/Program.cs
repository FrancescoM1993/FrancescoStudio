
//for (int i = 0; i < 101; i++)

// il programma chiede all utente di inserire il numero qualsiasi

Console.WriteLine("Inserisci un numero qualsiasi");
int i = int.Parse(Console.ReadLine());

// il programma scrive solo il numero scelto dall utente
Console.WriteLine($"Hai scelto il numero {i}");
/*
for (int i = 0; i < numero; i++)
    {
        if (i % 3 == 0 && i % 5 == 0)
        {
            Console.WriteLine("FizzBuzz");
        }
        else if (i % 3 == 0 && i % 5 != 0)
        {
            Console.WriteLine("Fizz");
        }
        else if (i % 5 == 0 && i % 3 != 0)
        {
            Console.WriteLine("Buzz");
        }
        else
        {
            Console.WriteLine(i);
        }
    }
*/

//Utilizza un ciclo `while` per continuare a chiedere all'utente di inserire un numero fino a quando non decide di fermarsi
while (true)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
        break;
    }
    else if (i % 3 == 0 && i % 5 != 0)
    {
        Console.WriteLine("Fizz");
        break;
    }
    else if (i % 5 == 0 && i % 3 != 0)
    {
        Console.WriteLine("Buzz");
        break;
    }
    else
    {
        Console.WriteLine(i);
        break;
    }
    // chiedi all'utente se vuole continuare
    Console.WriteLine("Vuoi continuare? (y/n)");
    string risposta = Console.ReadLine();
    if (risposta.ToLower() != "y")
    {
        // se l'utente non vuole continuare, esci dal ciclo
        Console.WriteLine("Grazie per aver giocato!");
        break;
    }
    else
    {
        // altrimenti chiedi un nuovo numero
        Console.WriteLine("Inserisci un numero qualsiasi");
        i = int.Parse(Console.ReadLine());
    }

}
    




