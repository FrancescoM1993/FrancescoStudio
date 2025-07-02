// Libro
public class Libro
{
    // Proprietà (da public fino al Titolo)
    public string Titolo { get; set; }
    public int AnnoPubblicazione { get; set; }
    public string Genere { get; set; }
    public bool Letto { get; set; }

    // Costruttore di default (senza parametri)
    public Libro ()
    {
        // Inizializza i valori di default
        Titolo = "Sconosciuto";
        AnnoPubblicazione = 2000;
        Genere = "N/A";
        Letto = false;
    }
    
    // Costruttore (parte dalle graffe)
    public Libro(string titolo, int annoPubblicazione, string genere, bool letto)
    {
        // Qui inizializzo le proprietà con i valori passati
        Titolo = titolo;
        AnnoPubblicazione = annoPubblicazione;
        Genere = genere;
        Letto = letto;
    }
}
