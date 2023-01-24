using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class CentroCosto
    {
        public CentroCosto()
        {
            Almacen = new HashSet<Almacen>();
            Sector = new HashSet<Sector>();
        }

        public string CentroCostoId { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual ICollection<Almacen> Almacen { get; set; }
        public virtual ICollection<Sector> Sector { get; set; }
    }
}
