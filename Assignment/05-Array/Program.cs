/*
int[] eta = { 26, 12, 3, 33, 8 };
int somma = 0;
int sottrazione = 0;


Console.WriteLine("Inserisci la lunghezza dell'array: ");
int lunghezza = int.Parse(Console.ReadLine());
int[] eta = new int[lunghezza];
int[] eta2 = new int[eta.Length];

for (int i = 0; i < eta.Length; i++)
{
    Console.WriteLine($"Inserisci il numero {i + 1}: ");
    eta[i] = int.Parse(Console.ReadLine());
}
// Stampa dell'array

/*
Array.Sort(eta);
Console.WriteLine(string.Join(", ", eta)); 
Array.Reverse(eta);
Console.WriteLine(string.Join(", ", eta));
Array.Copy(eta, eta2, eta.Length); 
*/
/*
for (int i = 0; i < eta.Length; i++)
{
    somma += eta[i];

}
Console.WriteLine($"La somma degli elementi dell'array è: {somma}"); 

for (int i = 0; i < eta2.Length; i++)
{
    sottrazione -= eta2[i];
}

Console.WriteLine($"La sottrazione degli elementi dell'array è: {sottrazione}");


Console.WriteLine("La lista contiene i seguenti numeri pari: ");

List<int> newNum = new List<int>();

for (int i = 0; i < eta.Length; i++)
{
    if (eta[i] % 2 == 0)
    {

        newNum.Add(eta[i]);
    }
}

Console.WriteLine(string.Join(", ", newNum));

Array.Copy(eta, eta2, eta.Length);
List<int> newNum2 = new List<int>();
Console.WriteLine("La lista contiene i seguenti numeri dispari: "); 

for (int i = 0; i < eta.Length; i++)
{
    if (eta[i] % 2 != 0)
    {
        newNum2.Add(eta[i]);
    }
}

Console.WriteLine(string.Join(", ", newNum2));
*/
/*
int[] eta = { 26, 12, 3, 33, 8 };
int valoreDaCercare = 3;
int posizioneTrovata = -1;


for (int i = 0; i < eta.Length; i++)
{
    if (eta[i] == valoreDaCercare)
    {
        posizioneTrovata = i;
        break;
    }
}


if (posizioneTrovata != -1)

{
    Console.WriteLine($"Il numero {valoreDaCercare} è presente nell'array alla posizione {posizioneTrovata}.");
}
else 
{
    Console.WriteLine($"Il numero {valoreDaCercare} non è presente nell'array.");
}
*/

Console.Write("Inserisci il numero di elementi per l'array: ");
int numeroElementi = int.Parse(Console.ReadLine());
int[] numeri = new int[numeroElementi];

for (int i = 0; i < numeroElementi; i++)
{
    Console.Write($"Inserisci il numero {i + 1}: ");
    numeri[i] = int.Parse(Console.ReadLine());
}

Console.Write("Inserisci il numero da cercare nell'array: ");
int numeroDaCercare = int.Parse(Console.ReadLine());

bool trovato = false;

foreach (int numero in numeri)
{
    if (numero == numeroDaCercare)
    {
        Console.WriteLine($"Trovato in posizione {Array.IndexOf(numeri, numero)}");
        trovato = true;
        break;
    }
}

if (!trovato)
{
    Console.WriteLine("Numero non trovato nell'array.");
}
