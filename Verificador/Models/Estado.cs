using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class Estado
    {
        public Estado()
        {
            Municipio = new HashSet<Municipio>();
        }

        public int EstadoId { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public int? PaisId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }

        public virtual Pais Pais { get; set; }
        public virtual ICollection<Municipio> Municipio { get; set; }
    }
}
