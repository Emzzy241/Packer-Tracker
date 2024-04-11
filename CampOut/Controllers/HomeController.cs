using Microsoft.AspNetCore.Mvc;
using CampOut.Models;

namespace CampOut.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}