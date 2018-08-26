namespace Vidly2.DTOs
{
    public class RentalDto
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }

        public int MovieId { get; set; }
        public string MovieName { get; set; }

        public string DateRented { get; set; }
    }
}