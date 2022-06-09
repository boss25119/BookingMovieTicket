namespace FilmTicketReservation.Models
{
    public class OrderDetail
    {
        public int? Id { get; set; }
        public int MovieId { get; set; }
        public string MovieTitle { get; set; }
        public decimal MoviePrice { get; set; }
        public int Quantity { get; set; }


        public IEnumerable<Movie> Movies;

        public Movie Movie { get; set; }
       
    }
}
