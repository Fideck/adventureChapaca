using Microsoft.AspNetCore.Mvc;

namespace api_aventurachapaca.Controllers
{
    public class TourController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
