using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class Log
    {
        public int LogId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string LoggedUserId { get; set; }
        public string EstacionId { get; set; }
        public int VentaId { get; set; }
        public string JsonClienteInicial { get; set; }
        public string JsonClienteFianal { get; set; }
        public string JsonClientesMismaTarjeta { get; set; }
        public string JsonVentasInvolucradas { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
    }
}
