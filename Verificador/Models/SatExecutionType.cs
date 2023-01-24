using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class SatExecutionType
    {
        public SatExecutionType()
        {
            SatOrder = new HashSet<SatOrder>();
        }

        public string SatExecutionTypeId { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string Message { get; set; }

        public virtual ICollection<SatOrder> SatOrder { get; set; }
    }
}
