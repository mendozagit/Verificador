using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class CPatenteaduanal
    {
        public int Id { get; set; }
        public string CPatenteAduanal1 { get; set; }
        public string InicioDeVigencia { get; set; }
        public string FinDeVigencia { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
    }
}
