using BackendMusic.Utils;
public class Canzone : IIdentifiable
{
    public int Id { get; set; }
    public string Titolo { get; set; }
    public string Durata { get; set; }
    public string Artista { get; set; }
}