using FilmTicketReservation.Data;
using Microsoft.AspNetCore.Mvc;

namespace FilmTicketReservation.Models
{
    [BindProperties(SupportsGet = true)]
    public class CheckOut
    {
        public int Id { get; set; }
        public string MovieTitle { get; set; }
        public decimal MoviePrice { get; set; }
    }
}

