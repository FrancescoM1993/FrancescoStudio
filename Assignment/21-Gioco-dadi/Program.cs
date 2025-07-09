﻿
// creo un oggetto dado con 6 facce
var d6 = new Dado();
Console.WriteLine(d6.Lancia());
// Console.WriteLine(d6);
Console.WriteLine(d6.ToString()); // rappresento il dado con il ToString()

// creo un dado con 20 facce
var d20 = new Dado(20);
Console.WriteLine(d20.Lancia());
// Console.WriteLine(d20);
Console.WriteLine(d20.ToString());

// lancio il dado multiplo con valori di default
var risultati = d20.LanciaMultiplo();
// stampo i risultati
Console.WriteLine("Risultati dei lanci multipli:");
foreach (var risultato in risultati)
{
    Console.WriteLine(risultato);
}

// lancio il dado multiplo con un numero specificato di lanci
var risultatiPersonalizzati = d20.LanciaMultiplo(3);
// stampo i risultati personalizzati
Console.WriteLine("Risultati dei lanci multipli personalizzati:");
foreach (var risultato in risultatiPersonalizzati)
{
    Console.WriteLine(risultato);
}

// lancio il dado multiplo con valori di default
var risultatid6 = d6.LanciaMultiplo();
// stampo i risultati
Console.WriteLine("Risultati dei lanci multipli:");
foreach (var risultato in risultatid6)
{
    Console.WriteLine(risultato);
}

var risultati5Dadi = d6.LanciaMultiplo();
// stampo i risultati dei 5 dadi
Console.WriteLine("Risultati dei 5 dadi lanciati:");
foreach (var risultato in risultati5Dadi)
{
    Console.WriteLine(risultato);
}
var indiciDaRilanciare = new List<int> { 0, 2, 4 }; // indici dei lanci da rilanciare
var risultatiRilanciati = d6.Rilancia(risultati5Dadi, indiciDaRilanciare);
Console.WriteLine("Risultati dopo il rilancio:");
foreach (var risultato in risultatiRilanciati)
{
    Console.WriteLine(risultato);
}

var frequenze = d6.StatisticheLanci(1000);
Console.WriteLine("Statistiche dei lanci:");
foreach (var kvp in frequenze)
{
    Console.WriteLine($"Numero {kvp.Key}: {kvp.Value} volte");
}

var d17 = new Dado(17);
d17.LanciaMultiplo(2);
Console.WriteLine(d17.ToString());