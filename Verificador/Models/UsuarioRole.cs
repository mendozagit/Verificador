using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class UsuarioRole
    {
        public string UsuarioId { get; set; }
        public string RoleId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }

        public virtual Role Role { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
