using BackendMusic.Utils;
namespace BackendMusic.Models
{
    public class Utente : IIdentifiable
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public InformazioniUtente informazioniUtente { get; set; }
    }
}