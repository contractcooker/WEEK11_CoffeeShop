using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View("RegisterIndex");
        }

        //public IActionResult Register(string fname, string lname, string email, string password)
        //{
        //    ViewData["name"] = fname + " " + lname;
        //    ViewData["email"] = email;
        //    ViewData["password"] = password;
        //    return View();
        //}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegistrationForm form)
        {
            if (ModelState.IsValid)
            {
                return View(form);
            }
            else
            {
                ViewData["errorMsg"] = "Your form had errors. Please correct and re-submit.";
                return View("RegisterIndex", form);
            }
        }
    }
}