using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class Job
    {
        public int JobId { get; set; }
        public string ComandoSql { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime FechaEjecucion { get; set; }
        public string Nombre { get; set; }
        public string Rtf { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public int AfectedRows { get; set; }
        public bool Repetir { get; set; }
        public bool Runned { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
    }
}
