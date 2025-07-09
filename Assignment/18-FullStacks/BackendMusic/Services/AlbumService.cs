using Newtonsoft.Json;

    public class AlbumService
    {
    private readonly string _percorsoAlbumFile;
    private readonly List<Album> _Album = new();

        public AlbumService(string percorsoAlbumFile)
    {
        _percorsoAlbumFile = percorsoAlbumFile;
    }

        public override string ToString()
        {
            return $"a";
        }

        public List<Album> CaricaAlbum()
        {

            if (!File.Exists(_percorsoAlbumFile))
            {
                throw new FileNotFoundException("File non trovato", _percorsoAlbumFile);
            }

            var contenuto = File.ReadAllText(_percorsoAlbumFile);

            var elenco = JsonConvert.DeserializeObject<List<Album>>(contenuto);
            Console.WriteLine("deserializzazione eseguita");

            if (elenco == null)
            {
                throw new JsonException("Deserializzazione tornata null");
            }
            
            return elenco;
        }


    }



