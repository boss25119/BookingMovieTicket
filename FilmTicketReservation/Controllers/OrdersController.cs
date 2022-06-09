using FilmTicketReservation.Data;
using FilmTicketReservation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace FilmTicketReservation.Controllers
{
    public class OrdersController : Controller
    {

        private readonly ApplicationDbContext _context;

        public OrdersController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Index()
        {
            var movies = from m in _context.Movies
                         select m;
            return View(movies);

        }

        public IActionResult Create()
        {
            List<Movie> list = new List<Movie>();
            var newList = list.Select(m => new Movie
            {
                Id = m.Id,
                Title = m.Title,
                Price = m.Price
            }).ToList();
            ViewBag.Movies = _context.Movies.Select(v => new SelectListItem
            {
                Text = v.Title,
                Value = v.Id.ToString(),

            });
            
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int? id, [Bind("MovieId, MovieTitle, MoviePrice")] OrderDetail orderDetail)
        {
            //var movie = _context.OrderDetails.Include(m => m.Movies).First();
            //var movieList = from m in _context.Movies
            //group m by m.Title;
            Movie movie = new Movie();
            movie.Title = orderDetail.MovieTitle;
            movie.Id = orderDetail.MovieId;
            movie.Price = orderDetail.MoviePrice;

            _context.Add(orderDetail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Views.Thankyou));
        }

        public IActionResult Thankyou()
        {
            return View();
        }








    }
       

}
