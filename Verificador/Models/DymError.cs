using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class DymError
    {
        public int DymErrorId { get; set; }
        public string Message { get; set; }
        public string ToString { get; set; }
        public string VentaId { get; set; }
        public string LoggedUser { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
    }
}
