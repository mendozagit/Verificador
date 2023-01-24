using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class SatOrder
    {
        public SatOrder()
        {
            SatRequest = new HashSet<SatRequest>();
            SatResponse = new HashSet<SatResponse>();
        }

        public int SatOrderId { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime NextExecutionTime { get; set; }
        public DateTime? ExecutedAt { get; set; }
        public string CreatedIn { get; set; }
        public string ExecutedIn { get; set; }
        public bool IsRunning { get; set; }
        public string RequestUuid { get; set; }
        public string Situation { get; set; }
        public string Comments { get; set; }
        public string EmitterTin { get; set; }
        public string ReceiverTin { get; set; }
        public string RequesterTin { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string SatExecutionTypeId { get; set; }

        public virtual SatExecutionType SatExecutionType { get; set; }
        public virtual ICollection<SatRequest> SatRequest { get; set; }
        public virtual ICollection<SatResponse> SatResponse { get; set; }
    }
}
