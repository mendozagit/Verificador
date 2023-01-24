using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class ProductoSustancia
    {
        public string ProductoId { get; set; }
        public string SustanciaId { get; set; }
        public string Contenido { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }

        public virtual Producto Producto { get; set; }
        public virtual Sustancia Sustancia { get; set; }
    }
}
