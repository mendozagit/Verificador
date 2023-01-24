using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class SatFile
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string Base64File { get; set; }
        public string Type { get; set; }
        public string FileNumber { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string CompanyName { get; set; }
        public int EmpresaId { get; set; }
        public string FileClass { get; set; }

        public virtual Empresa Empresa { get; set; }
    }
}
