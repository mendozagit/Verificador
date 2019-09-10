using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class CMetodopago
    {
        public CMetodopago()
        {
            Cliente = new HashSet<Cliente>();
        }

        public string MetodoPagoId { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Cliente> Cliente { get; set; }
    }
}
