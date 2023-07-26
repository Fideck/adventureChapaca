using Microsoft.AspNetCore.Mvc;

namespace api_aventurachapaca.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
