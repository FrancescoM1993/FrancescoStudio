/*
string nome = "Nome1";
int lunghezza = nome.Length;
Console.WriteLine(lunghezza);



string nome = "Nome1";
Console.WriteLine(string.IsNullOrWhiteSpace(nome)); // output: false

Console.WriteLine(nome.ToLower()); // output: nome1

Console.WriteLine(nome.ToUpper()); // output: NOME1
*/

string nome = "Nome1";
/*
string sostituzione = nome.Replace("Nome1", "Cognome");
Console.WriteLine(sostituzione); // output: Cognome1
*/
Console.WriteLine(nome.Replace("Nome1", "Nome2"));

Console.WriteLine(nome.Substring(0, 2));