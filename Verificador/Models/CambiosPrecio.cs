using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class CambiosPrecio
    {
        public int CambioPrecioId { get; set; }
        public string ProductoId { get; set; }
        public decimal PrecioCompraViejo { get; set; }
        public decimal PrecioCompraNuevo { get; set; }
        public decimal? Precio1Viejo { get; set; }
        public decimal? Precio2Viejo { get; set; }
        public decimal? Precio3Viejo { get; set; }
        public decimal? Precio4Viejo { get; set; }
        public decimal? Precio1Nuevo { get; set; }
        public decimal? Precio2Nuevo { get; set; }
        public decimal? Precio3Nuevo { get; set; }
        public decimal? Precio4Nuevo { get; set; }
        public decimal? Utilidad1Viejo { get; set; }
        public decimal? Utilidad2Viejo { get; set; }
        public decimal? Utilidad3Viejo { get; set; }
        public decimal? Utilidad4Viejo { get; set; }
        public decimal? Utilidad1Nuevo { get; set; }
        public decimal? Utilidad2Nuevo { get; set; }
        public decimal? Utilidad3Nuevo { get; set; }
        public decimal? Utilidad4Nuevo { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string Estado { get; set; }
        public int CompraId { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public bool? GridEntradaXcompra { get; set; }
        public string Observacion { get; set; }
        public decimal PrecioCajaNuevo { get; set; }
        public decimal PrecioCajaViejo { get; set; }

        public virtual Usuario CreatedByNavigation { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
