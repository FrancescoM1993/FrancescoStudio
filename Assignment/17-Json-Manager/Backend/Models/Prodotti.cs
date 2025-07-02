namespace Backend.Models;

public class Prodotti
{
    public string? Codice { get; set; }
    public string? Nome { get; set; }
    public bool Disponibile { get; set; }
    public int Quantita { get; set; }
    public List<string>? Categorie { get; set; }
    public Posizione? Posizione { get; set; }
}




