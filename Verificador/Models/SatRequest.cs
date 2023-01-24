using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class SatRequest
    {
        public int SatRequestId { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string RawRequest { get; set; }
        public string Step { get; set; }
        public int SatOrderId { get; set; }

        public virtual SatOrder SatOrder { get; set; }
    }
}
