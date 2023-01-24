using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class ConceptoMovInv
    {
        public ConceptoMovInv()
        {
            MovInv = new HashSet<MovInv>();
        }

        public string ConceptoMovInvId { get; set; }
        public string Descripcion { get; set; }
        public bool IsDeleted { get; set; }
        public string Es { get; set; }
        public int Afectacion { get; set; }
        public bool Digitacion { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public int OrdenPresentacion { get; set; }

        public virtual ICollection<MovInv> MovInv { get; set; }
    }
}
