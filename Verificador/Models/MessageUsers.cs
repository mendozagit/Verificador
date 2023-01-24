using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class MessageUsers
    {
        public string UsuarioId { get; set; }
        public int MessageId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public bool? IsReaded { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }

        public virtual Messages Message { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
