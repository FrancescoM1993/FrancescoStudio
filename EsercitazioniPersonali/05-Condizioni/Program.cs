//CONDIZIONI

// Le condizioni o istruzioni condizionali sono utilizzate per eseguire un blocco di codice solo se una condizione è vera.
// In C# le condizioni sono scritte in vari modi,ma i più comuni sono:

// - if
// - else
// - else if
// - switch

/*
    if (condizione)
    {
        // codice da eseguire se la condizione è vera
    }
    
*/

// ESEMPIO DI USO DI IF

int a = 10;
int b = 20;
if (a > b)
{
    // codice da eseguire se la condizione è vera
    Console.WriteLine($"{a} è maggiore di {b}");
    
}
else
{
    // codice da eseguire se la condizione è falsa
    // else significa "altrimenti"
    Console.WriteLine($"{a} non è maggiore di {b}");
}   

// ESEMPIO DI USO DI ELSE IF

int c = 10;
int d = 5;
if (c > d)
{
    // codice da eseguire se la condizione è vera
    Console.WriteLine($"{c} è maggiore di {d}");
}
else if (c < d)
{
    // codice da eseguire se la condizione è falsa
    Console.WriteLine($"{c} è minore di {d}");
}
else
{
    // codice da eseguire se la condizione è falsa
    Console.WriteLine($"{c} è uguale a {d}");
}   

// ESEMPIO DI USO DI SWITCH

// CON INT

int e = 10;
switch (e)
{
    case 1:
        Console.WriteLine("Il numero è 1");
        break; // break serve per uscire dallo switch
               // senza il break il programma continua a leggere i case successivi
               // e quindi stampa anche "Il numero è 2" e "Il numero è 3"
    case 2:
        Console.WriteLine("Il numero è 2");
        break;
    case 3:
        Console.WriteLine("Il numero è 3");
        break;
    default:
        Console.WriteLine("Il numero non è 1, 2 o 3");
        break;
}   

// CON STRING

string f = "Pausa";
switch (f)
{
    case "Pausa":
        Console.WriteLine("Il valore è pausa");
        break; // break serve per uscire dallo switch
               // senza il break il programma continua a leggere i case successivi
               // e quindi stampa anche "Il numero è 2" e "Il numero è 3"
    case "pranzo":
        Console.WriteLine("Il valore è pranzo");
        break;
    case "cena":
        Console.WriteLine("Il valore è cena");
        break;
    default:
        Console.WriteLine("Il valore non è pausa, pranzo o cena");
        break;
}   

// ESEMPIO DI USO DI SWITCH CON BOOLEANO

bool g = true;
switch (g)
{
    case true:
        Console.WriteLine("Il valore è vero");
        break; 
     case false:
        Console.WriteLine("Il valore è falso");
        break;
    
}
