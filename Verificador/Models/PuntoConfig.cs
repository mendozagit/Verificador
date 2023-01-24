using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class PuntoConfig
    {
        public int PuntosConfigId { get; set; }
        public decimal TasaDescuento { get; set; }
        public int DiasReset { get; set; }
        public bool IsDeleted { get; set; }
        public bool Vigente { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
    }
}
