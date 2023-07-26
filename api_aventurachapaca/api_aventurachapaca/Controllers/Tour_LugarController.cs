using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_aventurachapaca.Controllers
{
    public class Tour_LugarController : Controller
    {
        // GET: Tour_LugarController
        public ActionResult Index()
        {
            return View();
        }

        // GET: Tour_LugarController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Tour_LugarController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tour_LugarController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Tour_LugarController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Tour_LugarController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Tour_LugarController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Tour_LugarController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
