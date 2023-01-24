using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class InformeParametro
    {
        public int ParametroId { get; set; }
        public string InformeId { get; set; }
        public string Nombre { get; set; }
        public string Estandar { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }

        public virtual Informe Informe { get; set; }
    }
}
