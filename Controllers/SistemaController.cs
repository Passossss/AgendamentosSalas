using AgendamentosSalas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Rotativa.AspNetCore;
using System.Collections.Generic;

namespace AgendamentosSalas.Controllers
{
    public class SistemaController : Controller
    {
        public ActionResult Index()
        {
            // Preenche as listas para as opções de Local, Sala e Período
            var locais = new List<SelectListItem>
            {
                new SelectListItem { Text = "Complexo IMAP Barigui", Value = "Complexo IMAP Barigui" },
                new SelectListItem { Text = "Edifício Delta 10o Andar", Value = "Edifício Delta 10o Andar" },
                new SelectListItem { Text = "EAD - Estúdio e Zoom", Value = "EAD - Estúdio e Zoom" },
                new SelectListItem { Text = "Zoom - Gabinete", Value = "Zoom - Gabinete" }
            };

            var salas = new List<SelectListItem>
            {
                new SelectListItem { Text = "Todas as salas", Value = "Todas as salas" },
                new SelectListItem { Text = "IMAP Barigui - Salão de Atos", Value = "IMAP Barigui - Salão de Atos" },
                new SelectListItem { Text = "IMAP Barigui - Salão Barigui", Value = "IMAP Barigui - Salão Barigui" },
                new SelectListItem { Text = "IMAP Barigui - Sala Jatobá", Value = "IMAP Barigui - Sala Jatobá" },
                new SelectListItem { Text = "IMAP Barigui - Praça Central", Value = "IMAP Barigui - Praça Central" },
                new SelectListItem { Text = "IMAP Barigui - Pátio Externo", Value = "IMAP Barigui - Pátio Externo" },
                new SelectListItem { Text = "IMAP Barigui - Sala Imbuia", Value = "IMAP Barigui - Sala Imbuia" },
                new SelectListItem { Text = "IMAP Barigui - Sala Worktiba", Value = "IMAP Barigui - Sala Worktiba" },
                new SelectListItem { Text = "IMAP Barigui - Sala do Lago", Value = "IMAP Barigui - Sala do Lago" },
                new SelectListItem { Text = "IMAP Barigui - Laboratório Curitiba Solar", Value = "IMAP Barigui - Laboratório Curitiba Solar" }
            };

            var periodos = new List<SelectListItem>
            {
                new SelectListItem { Text = "Todo o período", Value = "Todo o período" },
                new SelectListItem { Text = "Manhã", Value = "Manhã" },
                new SelectListItem { Text = "Tarde", Value = "Tarde" },
                new SelectListItem { Text = "Noite", Value = "Noite" }
            };

            // Atribuindo as listas para o ViewBag
            ViewBag.Locais = locais;
            ViewBag.Salas = salas;
            ViewBag.Periodos = periodos;

            // Inicializando o modelo
            var model = new EventoModel
            {
                Local = "Complexo IMAP Barigui",
                Sala = "Todas as salas",
                Periodo = "Todo o período"
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Buscar(EventoModel model)
        {
            // Aqui você pode buscar os eventos de acordo com os critérios do modelo
            return View("ResultadoBusca", model); // A exibição de resultados seria aqui
        }
        public IActionResult GerarRelatorioPdf(EventoModel model)
        {
            // Aqui você pode passar o modelo preenchido para a view
            return new ViewAsPdf("Relatorio", model)
            {
                FileName = "RelatorioEventos.pdf" // Nome do arquivo gerado
            };
        }
    }
}
