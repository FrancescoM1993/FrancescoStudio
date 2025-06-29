/*

string[] nomi = { "Fra", "Luca", "Federica", "Giulia", "Marco" };
int[] eta = { 20, 24, 28, 22, 30 };

int i = 0;



foreach (string Partecipante in nomi)
{
    string frase = string.Format("Il partecipante si chiama {0} e ha {1} anni", nomi[i], eta[i]);
    Console.WriteLine(frase);
    i++;
}
*/
/*
for (int i = 0; i < nomi.Length; i++)
{
    string frase = string.Format("Il partecipante si chiama {0} e ha {1} anni", nomi[i], eta[i]);
    Console.WriteLine(frase);
}
*/

Dictionary<string, int> partecipanti = new Dictionary<string, int>()
{
    { "Nome1", 10 },
    { "Nome2", 20 },
    { "Nome3", 30 },
    { "Nome4", 40 }

};
foreach (var partecipante in partecipanti)
{
    string frase = string.Format("Il partecipante si chiama {0} e ha {1} anni.", partecipante.Key, partecipante.Value);
    Console.WriteLine(frase);
}




 