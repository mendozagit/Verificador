using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class SatResponse
    {
        public SatResponse()
        {
            SatPackage = new HashSet<SatPackage>();
        }

        public int SatResponseId { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int SatRequestId { get; set; }
        public int SatOrderId { get; set; }
        public string ResponseStatusCode { get; set; }
        public string ResponseStatusMessage { get; set; }
        public string Step { get; set; }
        public string RawRequest { get; set; }
        public string RawResponse { get; set; }
        public string Token { get; set; }
        public string RequestUuid { get; set; }
        public string Situation { get; set; }
        public string CodeStatusRequest { get; set; }
        public string QtyCfdi { get; set; }

        public virtual SatOrder SatOrder { get; set; }
        public virtual ICollection<SatPackage> SatPackage { get; set; }
    }
}
