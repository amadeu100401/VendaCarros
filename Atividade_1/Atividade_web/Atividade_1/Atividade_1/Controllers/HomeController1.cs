using Microsoft.AspNetCore.Mvc;

namespace Atividade_1.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
