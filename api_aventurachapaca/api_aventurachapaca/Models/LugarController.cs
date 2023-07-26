using Microsoft.AspNetCore.Mvc;

namespace api_aventurachapaca.Models
{
    public class LugarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
