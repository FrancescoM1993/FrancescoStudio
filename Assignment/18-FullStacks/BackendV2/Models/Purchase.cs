namespace Backend.Models
{
    public class Purchase //public indica che la classe è accessibile a tutto il programma
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}