using Microsoft.AspNetCore.Mvc;

namespace LabCourse1.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name="Erblin", int secretNumber=99)
        {
            ViewBag.Name = name;
            ViewBag.SecretNumber = secretNumber;
            return View();
        }
    }
}
