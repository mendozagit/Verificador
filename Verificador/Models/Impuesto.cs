﻿using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class Impuesto
    {
        public Impuesto()
        {
            ProductoImpuesto1 = new HashSet<Producto>();
            ProductoImpuesto2 = new HashSet<Producto>();
            ProductoImpuesto3 = new HashSet<Producto>();
        }

        public string ImpuestoId { get; set; }
        public decimal Tasa { get; set; }
        public bool IsDeleted { get; set; }
        public string CImpuesto { get; set; }

        public virtual CImpuesto CImpuestoNavigation { get; set; }
        public virtual ICollection<Producto> ProductoImpuesto1 { get; set; }
        public virtual ICollection<Producto> ProductoImpuesto2 { get; set; }
        public virtual ICollection<Producto> ProductoImpuesto3 { get; set; }
    }
}
