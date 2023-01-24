using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class Cp
    {
        public int CpId { get; set; }
        public string Codigo { get; set; }
        public int? MunicipioId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }

        public virtual Municipio Municipio { get; set; }
    }
}
