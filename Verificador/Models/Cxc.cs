using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class Cxc
    {
        public Cxc()
        {
            Cxcp = new HashSet<Cxcp>();
            LxcDocument = new HashSet<LxcDocument>();
        }

        public int CxcId { get; set; }
        public string ClienteId { get; set; }
        public int VentaId { get; set; }
        public string TipoDocId { get; set; }
        public string EstadoDocId { get; set; }
        public string SerieDocId { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public DateTime FechaDocumento { get; set; }
        public string MonedaId { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Impuesto { get; set; }
        public decimal Total { get; set; }
        public decimal Saldo { get; set; }
        public string EstacionId { get; set; }
        public string Observacion { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public bool? Recalculada { get; set; }
        public int ListId { get; set; }

        public virtual Usuario CreatedByNavigation { get; set; }
        public virtual ICollection<Cxcp> Cxcp { get; set; }
        public virtual ICollection<LxcDocument> LxcDocument { get; set; }
    }
}
