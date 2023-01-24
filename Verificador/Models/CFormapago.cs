﻿using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class CFormapago
    {
        public CFormapago()
        {
            Cliente = new HashSet<Cliente>();
        }

        public string FormaPagoId { get; set; }
        public string Descripcion { get; set; }
        public string Bancarizado { get; set; }
        public bool AfectaCorte { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<Cliente> Cliente { get; set; }
    }
}
