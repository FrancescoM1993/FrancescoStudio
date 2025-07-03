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
