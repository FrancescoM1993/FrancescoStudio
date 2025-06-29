﻿//TODO per il V2: Inserire poi i dati in un array e tramite random, randomizzare la posizione dei dati

// Inizializzazione Random
Random numeroRandom = new Random();

// Count per generare almeno una volta una maiuscola e una minuscola
int minCount = 0;
int maxCount = 0;

//Count per controllare quanti caratteri speciali e cifre sono state inserite
int charSpecCount = 0;
int cifreCount = 0;

//Numero massimo di caratteri
int maxChar = 0;

// Da prevedere poi l'uso di ToLower() o ToUpper() per non ripetere la stringa superiore/inferiore.
string[] maiuscole = ["A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"];

string[] minuscole = ["a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"];

// Alcuni caratteri speciali per test
string[] charSpec = ["!", "\"", "#", "$", "%", "&", "@"];

// Chiedi all'utente quanti caratteri vuole eseguire?
Console.WriteLine("Di quanti caratteri vuoi la tua Password?\nInserisci un valore superiore a 4\nInserisci 5 o 8 per rispettare la consegna");

// Trasforma in Int, utilizzare poi un TryParse
maxChar = int.Parse(Console.ReadLine());

// Controllo se la Password è di una lunghezza generabile.
while (maxChar <= 4)
{
    Console.WriteLine("Password troppo corta.Reinserisci numero caratteri");
    maxChar = int.Parse(Console.ReadLine());
}

// Chiedi all'utente quanti caratteri vuole eseguire?
Console.WriteLine("Quanti caratteri speciali vuoi inserire?\nInserisci un valore superiore a 0");
// Trasforma in Int, utilizzare poi un TryParse
charSpecCount = int.Parse(Console.ReadLine());

// Controllo se i caratteri speciali rispettano la lunghezza desiderata sennò richiedo.
while (charSpecCount < 1)
{
    Console.WriteLine("Deve essere presente almeno un carattere. Inserisci un numero superiore a 0");
    maxChar = int.Parse(Console.ReadLine());
}

// Chiedi all'utente quante cifre vuole inserire?
Console.WriteLine("Quante cifre vuoi inserire?\n Inserisci un valore superiore a 0");
cifreCount = int.Parse(Console.ReadLine());

// Controllo se le cifre rispettano la lunghezza desiderata sennò richiedo.
while (cifreCount < 1)
{
    Console.WriteLine("Deve essere presente almeno un numero. Inserisci un numero superiore a 0");
    cifreCount = int.Parse(Console.ReadLine());
}

// Controllo se l'utente non abbia richiesto più caratteri / numeri più di quanto ha disponibilità
if (maxChar - charSpecCount - cifreCount < 0)
{
    Console.WriteLine("Generazione Password Non possibile. Hai Richiesto troppi caratteri.");
}
else
{
    // Genera la parte inerente ai carattere minuscoli o maiuscoli
    for (int i = 0; i < maxChar - charSpecCount - cifreCount; i++)
    {
        // Indice per la scelta nell'array [Da modificare per prevedere un array unico con ToLower() o ToUpper()]
        int index = numeroRandom.Next(0, 26);

        // Genera casualmente se voglio fare minuscolo o maiuscolo
        int minMaxChoice = numeroRandom.Next(0, 2);

        // Se è uscito 0 e contemporaneamente il count del minuscolo è diverso da 0
        // Inizialmente sarà sempre uguale a 0 il count. Mi serve per generare subito una minuscola e rispettare i termini richiesti
        if (minMaxChoice == 0 && minCount != 0)
        {
            Console.WriteLine($"[M] Maiuscolo {maiuscole[index]}");
            maxCount++;
        }
        else
        {
            Console.WriteLine($"[m] Minuscolo {minuscole[index]}");
            minCount++;
        }
    }

    // Genero i caratteri speciali richiesti dall'utente
    for (int j = 0; j < charSpecCount; j++)
    {
        int indexCharSpec = numeroRandom.Next(0, 6);
        Console.WriteLine($"[?] Speciale {charSpec[indexCharSpec]}");
    }

    // Genero i numeri richiesti dall'utente
    for (int x = 0; x < cifreCount; x++)
    {
        int numRand = numeroRandom.Next(0, 10);
        Console.WriteLine($"[0] Numero {numRand}");
    }
}