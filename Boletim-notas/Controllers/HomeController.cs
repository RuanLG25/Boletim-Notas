using Microsoft.AspNetCore.Mvc;

namespace BoletimNotas.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Boletim()
        {
            ViewBag.Disciplinas = new List<string>
            {
                "Matemática",
                "Português",
                "História",
                "Geografia",
                "Quimica"
                };

            ViewBag.Notas = new List<double>
            {
                9.5,
                7.2,
                4.8,
                8.0,
                6.5
            };

            return View();
        }
    }
}