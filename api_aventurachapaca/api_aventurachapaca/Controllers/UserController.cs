using Microsoft.AspNetCore.Mvc;

namespace api_aventurachapaca.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
