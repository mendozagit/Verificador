using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class Comprap
    {
        public int ComprapId { get; set; }
        public int CompraId { get; set; }
        public string ProductoId { get; set; }
        public string Descripcion { get; set; }
        public string LaboratorioId { get; set; }
        public string LaboratorioName { get; set; }
        public decimal Stock { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioCaja { get; set; }
        public decimal Descuento { get; set; }
        public string Lote { get; set; }
        public DateTime? Caducidad { get; set; }
        public int NImpuestos { get; set; }
        public decimal Impuesto1 { get; set; }
        public decimal Impuesto2 { get; set; }
        public decimal ImporteImpuesto1 { get; set; }
        public decimal ImporteImpuesto2 { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Total { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public decimal Precio1 { get; set; }
        public decimal Precio2 { get; set; }
        public decimal Utilidad1 { get; set; }
        public decimal Utilidad2 { get; set; }
        public int? SatXmlItemId { get; set; }
        public decimal PrecioSalida1 { get; set; }
        public decimal PrecioSalida2 { get; set; }

        public virtual Compra Compra { get; set; }
    }
}
