using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class CUsocfdi
    {
        public CUsocfdi()
        {
            Cliente = new HashSet<Cliente>();
            Venta = new HashSet<Venta>();
        }

        public string UsoCfdiid { get; set; }
        public string Descripcion { get; set; }
        public string Fisica { get; set; }
        public string Moral { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<Cliente> Cliente { get; set; }
        public virtual ICollection<Venta> Venta { get; set; }
    }
}
