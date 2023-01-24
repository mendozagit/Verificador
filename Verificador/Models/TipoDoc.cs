using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class TipoDoc
    {
        public TipoDoc()
        {
            Compra = new HashSet<Compra>();
            Cxp = new HashSet<Cxp>();
            Venta = new HashSet<Venta>();
        }

        public string TipoDocId { get; set; }
        public string Descripcion { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<Compra> Compra { get; set; }
        public virtual ICollection<Cxp> Cxp { get; set; }
        public virtual ICollection<Venta> Venta { get; set; }
    }
}
