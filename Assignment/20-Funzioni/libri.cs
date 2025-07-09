/*
public class Automobile
{
    public string? Marca { get; set; }
    public int? AnnoImmatricolazione { get; set; }
    public string? Modello { get; set; }
    public bool AssicurazioneAttiva { get; set; }

    public Automobile()
    {
        Marca = "Sconosciuto";
        AnnoImmatricolazione = 2000;
        Modello = "N/A";
        AssicurazioneAttiva = false;
    }

    public Automobile(string marca, int annoImmatricolazione, string modello, bool assicurazioneAttiva)
    {

        Marca = marca;
        AnnoImmatricolazione = annoImmatricolazione;
        Modello = modello;
        AssicurazioneAttiva = assicurazioneAttiva;
    }
}

*/

// Classe Libro per gestire i dati dei libri
// contiene titolo, anno di pubblicazione, genere e se è stato letto
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
