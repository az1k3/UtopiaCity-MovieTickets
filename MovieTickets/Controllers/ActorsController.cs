using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace MovieTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _context;

        public ActorsController(AppDbContext context)
        {
            _context = context;
        }

        //TODO: Need to fix ActorViewModel
        public IActionResult Index()
        {
            var allActors = _context.Actors.ToList();
            return View(allActors);
        }
    }
}
