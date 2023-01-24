using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class LoteVentap
    {
        public int LotepId { get; set; }
        public int LoteId { get; set; }
        public string ProductoId { get; set; }
        public int VentaId { get; set; }
        public decimal Cantidad { get; set; }
        public string NoLote { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }

        public virtual Lote Lote { get; set; }
        public virtual Venta Venta { get; set; }
    }
}
