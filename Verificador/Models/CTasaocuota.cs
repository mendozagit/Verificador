using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class CTasaocuota
    {
        public int Id { get; set; }
        public string RangoOfijo { get; set; }
        public string ValorMínimo { get; set; }
        public string ValorMáximo { get; set; }
        public string Impuesto { get; set; }
        public string Factor { get; set; }
        public string Traslado { get; set; }
        public string Retención { get; set; }
        public string FechaInicioDeVigencia { get; set; }
        public string FechaFinDeVigencia { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
    }
}
