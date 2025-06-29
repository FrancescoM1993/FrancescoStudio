// Gestione eccezioni

// sto tentando di accedere a un file che non esiste

/*
try
{
    // il file deve essere nella stessa cartella del programma
    string contenuto = File.ReadAllText("file.txt");
    Console.WriteLine(contenuto);
}
catch (Exception e)
{
    Console.WriteLine("Il file non esiste");
    Console.WriteLine($"ERRORE NON TRATTATO: {e.Message}");
    Console.WriteLine($"CODICE ERRORE: {e.HResult}");
    return;
}

*/

// sto cercando di dividere un numero per zero

/*
try
{
    int zero = 0;
    int numero = 1 / zero; // il programma si blocca perche non si puo dividere per zero
}
catch (Exception e)
{
    Console.WriteLine("Divisione per zero");
    Console.WriteLine($"ERRORE NON TRATTATO: {e.Message}");
    Console.WriteLine($"CODICE ERRORE: {e.HResult}");
    return;
}
*/

// sto cercando di accedere ad un elemento di un array che non esiste

/*
int[] numeri = { 1, 2, 3 };

try
{
    Console.WriteLine(numeri[3]);
}
catch (Exception e)
{
    Console.WriteLine("Accesso a un elemento di un array che non esiste");
    Console.WriteLine($"ERRORE NON TRATTATO: {e.Message}");
    Console.WriteLine($"CODICE ERRORE: {e.HResult}");
    return;
}
*/

// sto cercando di accedere ad un oggetto null

/*
string nome = null;

try
{
    Console.WriteLine(nome.Length);
}
catch (Exception e)
{
    Console.WriteLine("Accesso a un oggetto nullo");
    Console.WriteLine($"ERRORE NON TRATTATO: {e.Message}");
    Console.WriteLine($"CODICE ERRORE: {e.HResult}");
    return;
}
*/

// non c'è abbastanza memoria disponibile

try
{
    int[] numeri = new int[int.MaxValue]; //2147483591
}
catch (Exception e)
{
    Console.WriteLine("Memoria non sufficente");
    Console.WriteLine($"ERRORE NON TRATTATO: {e.Message}");
    Console.WriteLine($"CODICE ERRORE: {e.HResult}");
    return;
}

// numero fuori dal range consentito

try
{
    int[] numeri = int.Parse("10000000000000"); // il metodo int.Parse() genera un'eccezione perche "1 000 000 000" troppo grande 
    // con il piu piccolo basta mettere il meno
}
catch (Exception e)
{
    Console.WriteLine("Numero fuori dal range");
    Console.WriteLine($"ERRORE NON TRATTATO: {e.Message}");
    Console.WriteLine($"CODICE ERRORE: {e.HResult}");
    return;
}

// esempio di un try catch finally con un files di testo che sia che avvenga o non avvenga la scrittura dev essere chiuso

try
{
    using (StreamWriter writer = new StreamWriter("file.txt"))
    {
        writer.WriteLine("Ciao Mondo");
    }
}
catch (Exception e)
{
    Console.WriteLine("Si è verificato un errore durante la scrittura del file");
    Console.WriteLine($"ERRORE NON TRATTATO: {e.Message}");
    Console.WriteLine($"CODICE ERRORE: {e.HResult}");
    return;
}
finally
{
    Console.WriteLine("Il file è stato chiuso");
}