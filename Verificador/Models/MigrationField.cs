using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class MigrationField
    {
        public int MigrationFieldId { get; set; }
        public int MigrationTableId { get; set; }
        public string Campo { get; set; }
        public string Expresion { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdateBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }

        public virtual MigrationTable MigrationTable { get; set; }
    }
}
