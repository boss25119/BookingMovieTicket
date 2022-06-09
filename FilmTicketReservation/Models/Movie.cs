using System.ComponentModel.DataAnnotations;

namespace FilmTicketReservation.Models
{
    public class Movie
    {   
        [Key]
        public int Id { get; set; }
        [Required]
        public string ImgUrl { get; set; }
        public string Title { get; set; }
        public string Character { get; set; }
        public DateTime ShowTime { get; set; } = DateTime.Now;
        public string Description { get; set; }
        public decimal Rating { get; set; }
        public decimal Price { get; set; }
    }
}
