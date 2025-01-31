using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace AgendamentosSalas.Models
{
    public class EventoModel
    {
        public string Evento { get; set; }
        public string Local { get; set; }
        public string Sala { get; set; }
        public string Periodo { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DataInicial { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DataFinal { get; set; }
    }
}
