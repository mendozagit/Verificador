﻿using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class CAduana
    {
        public int Id { get; set; }
        public string CAduana1 { get; set; }
        public string Descripción { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
    }
}
