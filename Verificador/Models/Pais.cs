using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class Pais
    {
        public Pais()
        {
            Estado = new HashSet<Estado>();
        }

        public int PaisId { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }

        public virtual ICollection<Estado> Estado { get; set; }
    }
}
