using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class Devolucion
    {
        public Devolucion()
        {
            Devolucionp = new HashSet<Devolucionp>();
        }

        public int DevolucionId { get; set; }
        public string ConceptoMovInvId { get; set; }
        public string EstadoDocId { get; set; }
        public string ProveedorId { get; set; }
        public string Documento { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Impuesto { get; set; }
        public decimal Total { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }

        public virtual Usuario CreatedByNavigation { get; set; }
        public virtual ICollection<Devolucionp> Devolucionp { get; set; }
    }
}
