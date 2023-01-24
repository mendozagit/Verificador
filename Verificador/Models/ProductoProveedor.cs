using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class ProductoProveedor
    {
        public string ProductoId { get; set; }
        public string ProveedorId { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string CodigoProveedor { get; set; }

        public virtual Producto Producto { get; set; }
        public virtual Proveedor Proveedor { get; set; }
    }
}
