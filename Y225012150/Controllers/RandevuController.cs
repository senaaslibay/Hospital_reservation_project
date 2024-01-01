using Microsoft.AspNetCore.Mvc;
using Y225012150.Models;

namespace Y225012150.Controllers
{
    public class RandevuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RandevuCreate()
        {
            RandevuFiller filler = new RandevuFiller();
            return View();
        }
    }
}
