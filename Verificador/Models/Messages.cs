using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class Messages
    {
        public Messages()
        {
            MessageUsers = new HashSet<MessageUsers>();
        }

        public int MessageId { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string Base64Rtf { get; set; }
        public string DataSource { get; set; }

        public virtual ICollection<MessageUsers> MessageUsers { get; set; }
    }
}
