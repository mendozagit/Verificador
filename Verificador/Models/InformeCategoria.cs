using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class InformeCategoria
    {
        public InformeCategoria()
        {
            Informe = new HashSet<Informe>();
        }

        public int InformeCategoriaId { get; set; }
        public string Nombre { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<Informe> Informe { get; set; }
    }
}
