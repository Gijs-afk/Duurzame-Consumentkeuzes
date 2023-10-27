using Duurzame_Consumentkeuzes.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Serilog;

namespace Duurzame_Consumentkeuzes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _dotEnv;

        public HomeController(ILogger<HomeController> logger, IConfiguration dotEnv)
        {
            _logger = logger;
            _dotEnv = dotEnv;
        }

        public IActionResult Index()
        {
            var variabele = _dotEnv["TEST"];
            Log.Information(variabele);
            return View();
        }

        public IActionResult Privacy()
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