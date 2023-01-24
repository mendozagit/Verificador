using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class Sucursal
    {
        public Sucursal()
        {
            TraspasoSucursalDestino = new HashSet<Traspaso>();
            TraspasoSucursalOrigen = new HashSet<Traspaso>();
        }

        public int SucursalId { get; set; }
        public string Nombre { get; set; }
        public string Serie { get; set; }
        public bool Deleted { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<Traspaso> TraspasoSucursalDestino { get; set; }
        public virtual ICollection<Traspaso> TraspasoSucursalOrigen { get; set; }
    }
}
