using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class Ubicacion
    {
        public Ubicacion()
        {
            InverseUbicacionSuperior = new HashSet<Ubicacion>();
            ProductoUbicacion = new HashSet<ProductoUbicacion>();
        }

        public string UbicacionId { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string Descripcion { get; set; }
        public bool NivelAsociacion { get; set; }
        public string UbicacionSuperiorId { get; set; }
        public string Camino { get; set; }

        public virtual Ubicacion UbicacionSuperior { get; set; }
        public virtual ICollection<Ubicacion> InverseUbicacionSuperior { get; set; }
        public virtual ICollection<ProductoUbicacion> ProductoUbicacion { get; set; }
    }
}
