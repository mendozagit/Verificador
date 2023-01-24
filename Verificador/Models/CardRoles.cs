using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class CardRoles
    {
        public CardRoles()
        {
            CardTransactions = new HashSet<CardTransactions>();
            Cliente = new HashSet<Cliente>();
        }

        public int CardRoleId { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string Description { get; set; }

        public virtual ICollection<CardTransactions> CardTransactions { get; set; }
        public virtual ICollection<Cliente> Cliente { get; set; }
    }
}
