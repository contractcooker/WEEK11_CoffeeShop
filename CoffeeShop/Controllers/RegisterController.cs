using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View("RegisterIndex");
        }
        [HttpPost]
        public IActionResult Register(string fname, string lname, string email, string password)
        {
            ViewData["name"] = fname + " " + lname;
            ViewData["email"] = email;
            ViewData["password"] = password;
            return View();
        }
    }
}