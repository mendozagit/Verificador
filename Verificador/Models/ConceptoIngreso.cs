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
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<Flujo> Flujo { get; set; }
    }
}
