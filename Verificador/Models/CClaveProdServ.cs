using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class CClaveProdServ
    {
        public string ClaveProdServId { get; set; }
        public string Nombre { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
    }
}
