using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class Actualizacion
    {
        public int ActualizacionId { get; set; }
        public string Version { get; set; }
        public string ScriptSql { get; set; }
        public bool BatchExitoso { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Applied { get; set; }
        public string Appliedby { get; set; }
        public DateTime AppliedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
    }
}
