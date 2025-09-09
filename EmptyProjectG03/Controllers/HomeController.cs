using EmptyProjectG03.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmptyProjectG03.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ///return View("hamada", new Movie());// => View Named As Hamada With Model
            ///return View("Hamada");// => View Named As Hamada
            ///return View(new Movie());// view named as Index With Model
            ///return View();// view named as Index
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
