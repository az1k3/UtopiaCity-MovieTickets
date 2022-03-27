using Microsoft.AspNetCore.Mvc;

namespace MovieTickets.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
