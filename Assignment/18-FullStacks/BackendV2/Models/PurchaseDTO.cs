namespace Backend.Models
{
    public class PurchaseDTO //public indica che la classe è accessibile a tutto il programma
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}