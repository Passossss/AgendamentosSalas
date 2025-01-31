namespace AgendamentosSalas.Controllers;

using Microsoft.AspNetCore.Mvc;

    public class AgendamentosController : Controller
{
        public IActionResult Index()
        {
            return View();
        }
    }

