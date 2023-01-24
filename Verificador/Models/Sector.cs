using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class Sector
    {
        public Sector()
        {
            Usuario = new HashSet<Usuario>();
        }

        public string SectorId { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string Nombre { get; set; }
        public string CentroCostoId { get; set; }
        public string AlmacenId { get; set; }

        public virtual Almacen Almacen { get; set; }
        public virtual CentroCosto CentroCosto { get; set; }
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
