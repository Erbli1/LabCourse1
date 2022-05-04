using Microsoft.AspNetCore.Mvc;

namespace LabCourse1.Controllers
{
    public class LocationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
