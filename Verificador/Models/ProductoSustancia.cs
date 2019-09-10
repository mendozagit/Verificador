using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class ProductoSustancia
    {
        public string ProductoId { get; set; }
        public string SustanciaId { get; set; }
        public string Contenido { get; set; }

        public virtual Producto Producto { get; set; }
        public virtual Sustancia Sustancia { get; set; }
    }
}
