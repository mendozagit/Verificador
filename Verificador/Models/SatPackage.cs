using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class SatPackage
    {
        public SatPackage()
        {
            SatXml = new HashSet<SatXml>();
        }

        public int SatPackageId { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string PackageUuid { get; set; }
        public string PackageBase64 { get; set; }
        public int SatResponseId { get; set; }

        public virtual SatResponse SatResponse { get; set; }
        public virtual ICollection<SatXml> SatXml { get; set; }
    }
}
