using Microsoft.AspNetCore.Mvc;

namespace MediatrTest.Controllers
{
    public class LegoanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
