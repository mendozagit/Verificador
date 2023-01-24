﻿using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class UnidadMedida
    {
        public UnidadMedida()
        {
            Producto = new HashSet<Producto>();
        }

        public string UnidadMedidaId { get; set; }
        public string Nombre { get; set; }
        public string UnidadSat { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<Producto> Producto { get; set; }
    }
}
