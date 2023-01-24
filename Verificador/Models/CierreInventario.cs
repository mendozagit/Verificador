using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class CierreInventario
    {
        public CierreInventario()
        {
            CierreInventariop = new HashSet<CierreInventariop>();
        }

        public int CierreInventarioId { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }
        public DateTime FechaProgramacion { get; set; }
        public bool Etapa1Generada { get; set; }
        public bool Etapa2Generada { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string EstacionId { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }

        public virtual Usuario CreatedByNavigation { get; set; }
        public virtual Estacion Estacion { get; set; }
        public virtual ICollection<CierreInventariop> CierreInventariop { get; set; }
    }
}
