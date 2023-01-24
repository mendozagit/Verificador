using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class Almacen
    {
        public Almacen()
        {
            ProductoAlmacen = new HashSet<ProductoAlmacen>();
            Sector = new HashSet<Sector>();
        }

        public string AlmacenId { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string Nombre { get; set; }
        public string CentroCostoId { get; set; }
        public string CompradorStandardId { get; set; }
        public bool PermiteStockNegativo { get; set; }
        public bool PermiteDigitacion { get; set; }
        public bool PermiteOrdenCompra { get; set; }
        public bool GeneraReqAutomatica { get; set; }
        public bool Propio { get; set; }
        public bool? PermiteGenerarPrestamos { get; set; }
        public bool? PermiteRequisitarMaterialNoLiberado { get; set; }
        public string Observacion { get; set; }

        public virtual CentroCosto CentroCosto { get; set; }
        public virtual Usuario CompradorStandard { get; set; }
        public virtual ICollection<ProductoAlmacen> ProductoAlmacen { get; set; }
        public virtual ICollection<Sector> Sector { get; set; }
    }
}
