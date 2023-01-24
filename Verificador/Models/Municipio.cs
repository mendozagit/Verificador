using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class Municipio
    {
        public Municipio()
        {
            Cp = new HashSet<Cp>();
        }

        public int MucipioId { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public int? EstadoId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }

        public virtual Estado Estado { get; set; }
        public virtual ICollection<Cp> Cp { get; set; }
    }
}
