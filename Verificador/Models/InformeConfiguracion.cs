using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class InformeConfiguracion
    {
        public int InformeConfiguracionId { get; set; }
        public string InformeId { get; set; }
        public bool Compra { get; set; }
        public bool Corte { get; set; }
        public bool Ticket { get; set; }
        public bool Factura { get; set; }
        public bool DevCom { get; set; }
        public string Regla { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool Inventario { get; set; }
        public bool CierresInv { get; set; }
        public bool? Traspaso { get; set; }
        public bool? Complemento { get; set; }
        public bool? Abono { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public bool? Lxc { get; set; }

        public virtual Informe Informe { get; set; }
    }
}
