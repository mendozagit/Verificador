﻿using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class Reporte
    {
        public int ReporteId { get; set; }
        public string Nombre { get; set; }
        public string SecuenciaCifrado { get; set; }
        public string Sql { get; set; }
        public string Rtf { get; set; }
        public string Codigo { get; set; }
        public bool Parametrizado { get; set; }
        public bool DelSistema { get; set; }
        public string Descripcion { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
    }
}
