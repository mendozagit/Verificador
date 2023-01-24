using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class Role
    {
        public Role()
        {
            RolePermiso = new HashSet<RolePermiso>();
            UsuarioRole = new HashSet<UsuarioRole>();
        }

        public string RoleId { get; set; }
        public string Descripcion { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<RolePermiso> RolePermiso { get; set; }
        public virtual ICollection<UsuarioRole> UsuarioRole { get; set; }
    }
}
