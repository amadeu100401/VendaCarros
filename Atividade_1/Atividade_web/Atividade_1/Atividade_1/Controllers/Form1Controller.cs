using Atividade_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Atividade_1.Controllers
{
    public class Form1Controller : Controller
    {
        private readonly ILogger<Form1Controller> _logger;

        public Form1Controller(ILogger<Form1Controller> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
