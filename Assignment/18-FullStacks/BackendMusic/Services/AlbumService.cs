using Newtonsoft.Json;

public class AlbumService
{
    private readonly string _percorsoAlbumFile;
    private readonly List<Album> _album = new();

    public AlbumService(string percorsoAlbumFile = "Json/1.json")
    {
        _percorsoAlbumFile = percorsoAlbumFile;
    }

    public void CaricaAlbum()
    {

        if (!File.Exists(_percorsoAlbumFile))
        {
            throw new FileNotFoundException("File non trovato", _percorsoAlbumFile);
        }

        else
        {
            Deserializza();
        }
    }

    public List<Album> Deserializza()
    {
        var contenuto = File.ReadAllText(_percorsoAlbumFile);

        var elenco = JsonConvert.DeserializeObject<List<Album>>(contenuto);

        if (elenco == null)
        {
            throw new JsonException("Deserializzazione tornata null");
        }

        return elenco;
    }

    public List<Album> Deserializza(string FileName)
    {
        var contenuto = File.ReadAllText($"Json/{FileName}.json");

        var elenco = JsonConvert.DeserializeObject<List<Album>>(contenuto);

        if (elenco == null)
        {
            throw new JsonException("Deserializzazione tornata null");
        }

        return elenco;
    }
    public List<Album> GetAll()
    {
        List<Album> result = new List<Album>();
        foreach (var album in _album)
        {
            result.Add(album);
        }
        return result;
    }

    public List<Album> GetByName(string FileName)
    {
        List<Album> result = new List<Album>();
        foreach (var album in _album)
        {
            result.Add(album);
        }
        return result;
    }
    public bool Delete(string FileName)
    {
        FileName = $"Json/{FileName}.json";
        if (!File.Exists(FileName))
        {
            return false;
        }
        File.Delete(FileName);
        return true;
    }

    public Album Aggiungi(Album newAlbum, string FileName)
    {
        newAlbum.Titolo = FileName;
        _album.Add(newAlbum);

        return newAlbum;
    }
}






