using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class ConceptoIngreso
    {
        public ConceptoIngreso()
        {
            Flujo = new HashSet<Flujo>();
        }

        public string ConceptoIngresoId { get; set; }
        public string Descripcion { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<Flujo> Flujo { get; set; }
    }
}
