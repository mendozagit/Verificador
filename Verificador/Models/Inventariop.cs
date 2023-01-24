using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class Inventariop
    {
        public int InventariopId { get; set; }
        public int InventarioId { get; set; }
        public string ProductoId { get; set; }
        public string Descripcion { get; set; }
        public decimal ExistenciaTeorica { get; set; }
        public decimal ExistenciaFisica { get; set; }
        public decimal Diferencia { get; set; }
        public int? MovInvId { get; set; }
        public int? LoteId { get; set; }
        public decimal CostoParcial { get; set; }
        public decimal Costo { get; set; }
        public DateTime Caducidad { get; set; }
        public string NoLote { get; set; }
        public string ResponsableAdicion { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }

        public virtual Inventario Inventario { get; set; }
    }
}
