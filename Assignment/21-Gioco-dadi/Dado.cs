public class Dado
{
    private static readonly Random _random = new Random();

    public int NumeroFacce { get; set; }

    /// <summary>
    /// Classe che rappresenta un dado con un numero variabile di facce.
    /// </summary>
    /// <param name="numeroFacce">
    /// Il numero di facce del dado. Deve essere un numero intero positivo.
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Viene lanciata se il numero di facce è minore di 4 o maggiore di 20.
    /// </exception>
    /// <example>
    /// Esempio di utilizzo:
    /// <code>
    /// int x = 8; // numero di facce del dado
    /// Dado dado = new Dado(x);
    /// </code>
    /// </example>

    public Dado(int numeroFacce = 6)
    {
        if (numeroFacce < 4 || numeroFacce > 20)
        {
            throw new ArgumentOutOfRangeException(nameof(numeroFacce), "Il numero di facce deve essere compreso tra 4 e 20.");
        }

        NumeroFacce = numeroFacce;
    }

    /// <summary>
    /// Lancia il dado e restituisce un valore casuale tra 1 e NumeroFacce (inclusi)
    /// </summary>
    /// <returns>
    /// Risultato del lancio.
    /// </returns>
    /// <example>
    /// Esempio di utilizzo:
    /// <code>
    /// int risultato = dado.Lancia();
    /// </code>
    /// </example>

    public int Lancia()
    {
        return _random.Next(1, NumeroFacce + 1);
    }

    public override string ToString()
    {
        return $"Lanciato Dado a {NumeroFacce} facce";
    }

    /// <summary>
    /// Lancia il dado un numero specificato di volte e restituisce una lista con i risultati.
    /// </summary>
    /// <param name="numeroLanci"></param>
    /// <returns>il risultato di ogni lancio come lista di interi</returns>
    /// <example>
    /// Esempio di utilizzo:
    /// <code>
    /// List<int> risultati = dado.LanciaMultiplo(10);
    /// </code>
    /// </example>

    public List<int> LanciaMultiplo(int numeroLanci = 5)
    {
        // creo una lista vuota di interi per memorizzare i risultati dei lanci
        List<int> risultati = new List<int>();

        // ciclo per il numero di lanci specificato
        for (int i = 0; i < numeroLanci; i++)
        {
            // genero un numero casuale tra 1 e NumeroFacce (inclusi)
            // e lo aggiungo alla lista dei risultati
            risultati.Add(_random.Next(1, NumeroFacce + 1));
        }
        return risultati;
    }

    /// <summary>
    /// Rilancia i dadi specificati da indici in una lista di risultati precedenti.
    /// </summary>
    /// <param name="risultatiPrecedenti"></param>
    /// <param name="indiciDaRilanciare"></param>
    /// <returns>una lista con i risultati aggiornati</returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    /// <example>
    /// Esempio di utilizzo:
    /// <code>
    /// var risultati = dado.LanciaMultiplo();
    /// var indiciDaRilanciare = new List<int> { 0, 2, 4 }; // indici dei lanci da rilanciare
    /// var risultatiRilanciati = dado.Rilancia(risultati, indiciDaRilanciare);
    /// </code>
    /// </example>

    public List<int> Rilancia(List<int> risultatiPrecedenti, IEnumerable<int> indiciDaRilanciare)
    {
        var risultati = risultatiPrecedenti.ToList();

        foreach (var idx in indiciDaRilanciare)
        {
            // Controlla se l'indice è valido
            // Se l'indice è fuori dall'intervallo, lancia un'eccezione
            // per evitare errori di accesso alla lista
            if (idx < 0 || idx >= risultati.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(indiciDaRilanciare), $"Indice {idx} fuori dall'intervallo [0..{risultati.Count - 1}]");
            }
            risultati[idx] = Lancia();
        }
        return risultati;
    }

    /// <summary>
    /// Calcola le statistiche dei lanci del dado, restituendo un dizionario
    /// con il conteggio dei risultati per ogni faccia del dado.
    /// </summary>
    /// <param name="numeroLanci">Il numero di lanci da effettuare per le statistiche.</param>
    /// <returns>
    /// Un dizionario che mappa ogni faccia del dado al numero di volte in cui
    /// è stata ottenuta in un certo numero di lanci.
    /// </returns>
    /// <example>
    /// Esempio di utilizzo:
    /// <code>
    /// var statistiche = dado.StatisticheLanci(1000);
    /// </code>
    /// </example>

    public Dictionary<int, int> StatisticheLanci(int numeroLanci = 500)
    {
        var counts = new Dictionary<int, int>();

        for (int faccia = 1; faccia <= NumeroFacce; faccia++)
        {
            counts[faccia] = 0;
        }

        for (int i = 0; i < numeroLanci; i++)
        {
            int risultato = Lancia();
            counts[risultato]++;

        }
        // Restituisce il dizionario con le statistiche dei lanci
        return counts;
    }
}