using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class MotivoCancelacion
    {
        public MotivoCancelacion()
        {
            Cxcp = new HashSet<Cxcp>();
            Lxc = new HashSet<Lxc>();
            Venta = new HashSet<Venta>();
        }

        public string MotivoCancelacionId { get; set; }
        public string Descripcion { get; set; }
        public string TipDelDesarrollador { get; set; }
        public string Orientacion { get; set; }

        public virtual ICollection<Cxcp> Cxcp { get; set; }
        public virtual ICollection<Lxc> Lxc { get; set; }
        public virtual ICollection<Venta> Venta { get; set; }
    }
}
