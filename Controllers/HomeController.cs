using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ValidacionEnvioFormulario.Models;

namespace ValidacionEnvioFormulario.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }



        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult FormularioUsuario()
        {
            return View();
        }

        public IActionResult ProcesaFormulario(User user)
    {
        if (!ModelState.IsValid)
        {
            return View("ProcesaFormulario", user);
        }
        TempData["IsSuccessful"] = true;
        Console.WriteLine($"Nombre del usuario: {user.Nombre}");
        return RedirectToAction("Result");
    }

    [HttpGet]
    public IActionResult Result()
    {
        if (TempData.ContainsKey("IsSuccessful") && (bool)TempData["IsSuccessful"])
        {
            ViewData["IsSuccessful"] = true;
            
        }
        else
        {
            ViewData["IsSuccessful"] = false;
        }
        return View("Result");
    }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
