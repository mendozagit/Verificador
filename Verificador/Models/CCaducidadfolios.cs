using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class CCaducidadfolios
    {
        public int Id { get; set; }
        public int DiasCaducidad { get; set; }
        public int PorcentajeCaducidad { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
    }
}
