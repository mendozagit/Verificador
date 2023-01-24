using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class Lote
    {
        public Lote()
        {
            LoteVentap = new HashSet<LoteVentap>();
        }

        public int LoteId { get; set; }
        public int CompraId { get; set; }
        public string NoLote { get; set; }
        public string ProductoId { get; set; }
        public decimal StockInicial { get; set; }
        public decimal StockRestante { get; set; }
        public DateTime Caducidad { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int ReferenciaInt { get; set; }
        public string ReferenciaString { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }

        public virtual Producto Producto { get; set; }
        public virtual ICollection<LoteVentap> LoteVentap { get; set; }
    }
}
