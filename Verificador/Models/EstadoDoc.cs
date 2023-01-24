using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class EstadoDoc
    {
        public EstadoDoc()
        {
            Compra = new HashSet<Compra>();
            Cxp = new HashSet<Cxp>();
        }

        public string EstadoDocId { get; set; }
        public string Descripcion { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<Compra> Compra { get; set; }
        public virtual ICollection<Cxp> Cxp { get; set; }
    }
}
