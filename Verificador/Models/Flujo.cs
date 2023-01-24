using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class Flujo
    {
        public int FlujoId { get; set; }
        public string ConceptoId { get; set; }
        public string EstacionId { get; set; }
        public string ConceptoPagoId { get; set; }
        public int Referencia { get; set; }
        public string Referenciap { get; set; }
        public string Es { get; set; }
        public decimal Importe { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public bool AfectaCorte { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ConceptoIngreso Concepto { get; set; }
        public virtual Usuario CreatedByNavigation { get; set; }
        public virtual Estacion Estacion { get; set; }
    }
}
