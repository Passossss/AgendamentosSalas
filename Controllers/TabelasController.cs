using Microsoft.AspNetCore.Mvc;

namespace AgendamentosSalas.Controllers
{
    public class TabelasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
