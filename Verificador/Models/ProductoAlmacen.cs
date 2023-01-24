using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class ProductoAlmacen
    {
        public string ProductoId { get; set; }
        public string AlmacenId { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public decimal Stock { get; set; }
        public decimal StockReservado { get; set; }
        public decimal StockPromedio { get; set; }
        public decimal ValorStock { get; set; }
        public decimal UltimoCosto { get; set; }
        public DateTime? FechaUltimoCosto { get; set; }
        public DateTime? FechaValorizacion { get; set; }
        public decimal Minimo { get; set; }
        public decimal Maximo { get; set; }

        public virtual Almacen Almacen { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
