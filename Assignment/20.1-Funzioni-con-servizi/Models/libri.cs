public class Libro
{
    public string Titolo { get; }
    public int AnnoPubblicazione { get; }
    public string Genere { get; }
    public bool Letto { get; }

    public Libro(string titolo, int annoPubblicazione, string genere, bool letto)
    {
        Titolo = titolo;
        AnnoPubblicazione = annoPubblicazione;
        Genere = genere;
        Letto = letto;
    }
}
