using Microsoft.AspNetCore.Mvc;

namespace ContactController.Controllers
{
    public class Contato : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
