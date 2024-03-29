﻿using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class Configuracion
    {
        public int Id { get; set; }
        public string RutaFormatoTicket { get; set; }
        public string RutaFormatoFactura { get; set; }
        public string RutaFormatoCorte { get; set; }
        public string RutaCortes { get; set; }
        public string RutaComprobantes { get; set; }
        public string RutaPlantillas { get; set; }
        public string RutaCer { get; set; }
        public string RutaKey { get; set; }
        public string RutaCadenaOriginal { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
    }
}
