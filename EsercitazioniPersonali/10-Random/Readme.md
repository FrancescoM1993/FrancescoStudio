# RANDOM

La classe random di csharp si occupa di generare numeri casuali.

Genera numeri in un intervallo semiaperto cioè se voglio generare i numeri fra 1 e 100 dovrò scrivere 1 e 101.
```csharp

Random numeroRandom = new Random(); // creo un oggetto random
int numero = numeroRandom.Next(1,101); // genero un numero casuale tra 1 e 100
Console.Writeline(numero); // stampo il numero
```
Se specifico un solo argomento,il numero generato sarà compreso tra 0 e il numero specificato
```csharp
int numero2 = numeroRandom.Next(100); // genero un numero casuale tra 0 e 99
Console.writeLine(numero2) // stampo il numero
```
Se voglio generare un numero casuale compreso tra 0 e 1 (escluso) posso usare il metodo NextDouble.
```csharp
double numero3 = numeroRandom.NextDouble(); //genero un numero casuale tra 0 e 1 inteso come 0.000000001
Console.Writeline(numero3); // stampo il numero
```

## Esercizio 1

Scrivere un programma che genera 10 numeri casuali compresi tra (1 e 100) e stampa a video solo i numeri divisibili 3 e 5.
```csharp
Random numeroRandom = Random();
for (int i = 0 i<10, i++)
{
    int numero = numeroRandom.Next(1,101); // genero un numero casuale tra 1 e 100
    if(numero % 3 == 0 || % 5 == 0)
    {
        Console.WriteLine(numero)
    }
}
```