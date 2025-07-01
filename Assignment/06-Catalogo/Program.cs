Dictionary<int, List<string>> catalogo = new Dictionary<int, List<string>>();
int idProdotto = 0;
double prezzoProdotto;

while (true)
{
    Console.WriteLine("Scegli un'opzione:");
    Console.WriteLine("1. Aggiungi un prodotto");
    Console.WriteLine("2. Rimuovi un prodotto");
    Console.WriteLine("3. Visualizza tutti i prodotti");
    Console.WriteLine("4. Esci");

    string scelta = Console.ReadLine();

    switch (scelta)
    {
        case "1":

            Console.WriteLine("Inserisci il nome del prodotto da aggiungere:");
            string nomeProdotto = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nomeProdotto))
            {
                Console.WriteLine("Il nome del prodotto non può essere vuoto.");
                break;
            }

            Console.WriteLine("Inserisci la descrizione del prodotto:");
            string descrizioneProdotto = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(descrizioneProdotto))
            {
                Console.WriteLine("La descrizione del prodotto non può essere vuota.");
                break;
            }

            Console.WriteLine("Inserisci il prezzo del prodotto:");
            
            prezzoProdotto = double.Parse(Console.ReadLine());

            if (prezzoProdotto <= 0)
            {
                Console.WriteLine("Prezzo non valido. Deve essere un numero decimale positivo.");
                prezzoProdotto = double.Parse(Console.ReadLine());
            }
            string prezzoProdottoString = prezzoProdotto.ToString();
            catalogo.Add(idProdotto, new List<string> {nomeProdotto,prezzoProdottoString,descrizioneProdotto});
            idProdotto++;
            break;

        case "2":

            Console.WriteLine("Inserisci l'ID del prodotto da rimuovere:");
            if (int.TryParse(Console.ReadLine(), out int idDaRimuovere) && catalogo.Remove(idDaRimuovere))
            {
                Console.WriteLine($"Prodotto con ID {idDaRimuovere} rimosso.");
            }
            else
            {
                Console.WriteLine($"Nessun prodotto trovato con ID {idDaRimuovere}.");
            }
            break;

        case "3":

            if (catalogo.Count == 0)
            {
                Console.WriteLine("Nessun prodotto disponibile.");
            }
            else
            {
                Console.WriteLine("Elenco dei prodotti:");
                foreach (var kvp in catalogo)
                {
                    Console.WriteLine($"ID: {kvp.Key} Nome:{string.Join("_",kvp.Value)}");   
                }
            }
            break;
        case "4":
            {
                Console.WriteLine("Uscita dal programma.");
                return;
            }
    }
}
    
