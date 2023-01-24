using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class VentapImpuesto
    {
        public int VentapImpuestoId { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int VentapId { get; set; }
        public string ImpuestoId { get; set; }
        public decimal Base { get; set; }
        public string Impuesto { get; set; }
        public string TipoFactor { get; set; }
        public decimal TasaOcuota { get; set; }
        public decimal Importe { get; set; }
        public int VentaId { get; set; }

        public virtual Ventap Ventap { get; set; }
    }
}
