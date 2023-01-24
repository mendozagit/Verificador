using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class CierreInventariop
    {
        public int CierreInventariopId { get; set; }
        public int CierreInventarioId { get; set; }
        public string ProductoId { get; set; }
        public string Descripcion { get; set; }
        public decimal InvInicial { get; set; }
        public decimal Entradas { get; set; }
        public decimal Salidas { get; set; }
        public decimal InvFinal { get; set; }
        public decimal Stock { get; set; }
        public decimal UltimoCosto { get; set; }
        public decimal PrevioVta { get; set; }
        public decimal ValorCosto { get; set; }
        public decimal ValorVenta { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }

        public virtual CierreInventario CierreInventario { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
