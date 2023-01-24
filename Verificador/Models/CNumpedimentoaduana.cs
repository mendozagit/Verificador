using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class CNumpedimentoaduana
    {
        public string CAduana { get; set; }
        public string Patente { get; set; }
        public string Ejercicio { get; set; }
        public string Cantidad { get; set; }
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
