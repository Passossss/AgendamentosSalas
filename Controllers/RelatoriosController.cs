using Microsoft.AspNetCore.Mvc;

namespace AgendamentosSalas.Controllers
{
    public class RelatoriosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
