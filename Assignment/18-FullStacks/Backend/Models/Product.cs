namespace Backend.Models
{
    public class Product //public indica che la classe è accessibile a tutto il programma
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantita { get; set; }
    }
}