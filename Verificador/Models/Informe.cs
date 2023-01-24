using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class Informe
    {
        public Informe()
        {
            InformeConfiguracion = new HashSet<InformeConfiguracion>();
            InformeParametro = new HashSet<InformeParametro>();
        }

        public string InformeId { get; set; }
        public string Descripcion { get; set; }
        public string Guid { get; set; }
        public string Codigo { get; set; }
        public bool Sistema { get; set; }
        public int InformeCateforiaId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }

        public virtual InformeCategoria InformeCateforia { get; set; }
        public virtual ICollection<InformeConfiguracion> InformeConfiguracion { get; set; }
        public virtual ICollection<InformeParametro> InformeParametro { get; set; }
    }
}
