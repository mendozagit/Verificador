using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class CImpuesto
    {
        public CImpuesto()
        {
            Impuesto = new HashSet<Impuesto>();
            VentapClaveImpuesto1Navigation = new HashSet<Ventap>();
            VentapClaveImpuesto2Navigation = new HashSet<Ventap>();
        }

        public string ImpuestoId { get; set; }
        public string Descripcion { get; set; }
        public string Retencion { get; set; }
        public string Traslado { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<Impuesto> Impuesto { get; set; }
        public virtual ICollection<Ventap> VentapClaveImpuesto1Navigation { get; set; }
        public virtual ICollection<Ventap> VentapClaveImpuesto2Navigation { get; set; }
    }
}
