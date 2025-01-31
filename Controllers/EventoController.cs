using AgendamentosSalas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AgendamentosSalas.Controllers
{
    public class EventoController : Controller
    {
        public ActionResult Index()
        {
            // Preenche as listas para as opções de Local, Sala e Período
            ViewBag.Locais = new SelectList(new List<string>
            {
                "Complexo IMAP Barigui",
                "Edifício Delta 10o Andar",
                "EAD - Estúdio e Zoom",
                "Zoom - Gabinete"
            });

            ViewBag.Salas = new SelectList(new List<string>
            {
                "Todas as salas",
                "IMAP Barigui - Salão de Atos",
                "IMAP Barigui - Salão Barigui",
                "IMAP Barigui - Sala Jatobá",
                "IMAP Barigui - Praça Central",
                "IMAP Barigui - Pátio Externo",
                "IMAP Barigui - Sala Imbuia",
                "IMAP Barigui - Sala Worktiba",
                "IMAP Barigui - Sala do Lago",
                "IMAP Barigui - Laboratório Curitiba Solar"
            });

            ViewBag.Periodos = new SelectList(new List<string>
            {
                "Todo o período",
                "Manhã",
                "Tarde",
                "Noite"
            });

            var model = new EventoModel
            {
                Local = "Complexo IMAP Barigui",
                Sala = "Todas as salas",
                Periodo = "Todo o período"
            };

            return View(model);
        }

        // Ação para processar a busca
        [HttpPost]
        public ActionResult Buscar(EventoModel model)
        {
            // Aqui você pode buscar os eventos de acordo com os critérios do modelo.
            return View("ResultadoBusca", model); // A exibição de resultados seria aqui
        }
    }
}

}
