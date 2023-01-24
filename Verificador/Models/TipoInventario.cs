using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class TipoInventario
    {
        public TipoInventario()
        {
            Inventario = new HashSet<Inventario>();
        }

        public int TipoInventarioId { get; set; }
        public string Descripcion { get; set; }
        public bool Bloquea { get; set; }
        public bool ResetStock { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<Inventario> Inventario { get; set; }
    }
}
