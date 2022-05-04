using LabCourse1.Models;
using Microsoft.AspNetCore.Mvc;

namespace LabCourse1.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProcessLogin(UserModel userModel)
        {
            if (userModel.UserName == "Erblin Gashi" && userModel.Password == "12345")
            { 
                return View("LoginSuccess", userModel);
            }
            else
            {
                return View("LoginFailed", userModel);
            }

            if (userModel.UserName == "Orhan Bajraktari" && userModel.Password == "12345")
            {
                return View("LoginSuccess", userModel);
            }
            else
            {
                return View("LoginFailed", userModel);
            }
        }
    }
}
