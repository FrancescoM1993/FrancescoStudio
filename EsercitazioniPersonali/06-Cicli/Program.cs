// CICLI

/*
I cicli sono una struttura di controllo che permette di eseguire un blocco di codice più volte, a seconda di una condizione. 
In Python esistono diversi tipi di cicli, tra cui il ciclo for e il ciclo while.
Ci sono anche il `foreach` e il `do while`

Ciclo `for`
Il ciclo for viene utilizzato per iterare su una sequenza (come una lista, una tupla o una stringa) o su un intervallo di numeri.




for variabile in sequenza:
     codice da eseguire
    
Esempio
*/

for i in range(5):
    print(i)   //Stampa i numeri da 0 a 4    

for (int i = 0; i < 5; i++) ; // i e una variabile di controllo
    {
        Console.WriteLine(i); // Stampa i numeri da 0 a 4
    }


// Ciclo `while`
//Il ciclo while viene utilizzato per eseguire un blocco di codice finche una condizione è vera. La subtassi è la seguente:


while(condizione)
{
    // codice da eseguire
}

// Esempio

int i = 0; // inizializza la variabile i a 0
while (i < 5) // finche i è minore di 5
{
    Console.WriteLine(i); // Stampa i numeri da 0 a 4
    i++;
}
 
// Esempio while con true


while (true) // Ciclo infinito
{
    Console.WriteLine("Ciclo infinito"); // Stampa "Ciclo infinito"
    break; // Esce dal ciclo
}

int k = 4;

while (true) // Ciclo infinito
{
    Console.WriteLine("Ciclo infinito"); 
    if (k == 5) // Se k è uguale a 5
    {
        break; // Esce dal ciclo
    }
    
    k++; // Incrementa k di 1 (qua lo fa due volte) k4 poi somma e va k5
    //k--; // Decrementa k di 1 (qua va all'infinito)
}  
/*
 Ciclo `foreach`
Il ciclo foreach viene utilizzato per iterare su una collezione (come un array o una lista) senza dover utilizzare un indice.
*/

foreach (tipo variabile in collezione)
{
    // codice da eseguire
}

//Esempio

string[] nomi = { "Mario", "Luigi", "Peach" }; // Array di stringhe
foreach (string nome in nomi) // Itera su ogni elemento dell'array
{
    Console.WriteLine(nome); // Stampa il nome
}
// altro esempio
{
    if (nome == "Mario") // Se il nome è "Mario"
    {
        Console.WriteLine("Nome trovato"); // Stampa nome trovato
        break; // Esce dal ciclo
    }
    else
    {
        Console.WriteLine("Nome non trovato"); 
    }
    
}

