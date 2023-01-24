using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class Cards
    {
        public Cards()
        {
            CardDeletionHistories = new HashSet<CardDeletionHistories>();
            CardTransactions = new HashSet<CardTransactions>();
            Cliente = new HashSet<Cliente>();
        }

        public string CardId { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public decimal BonusRate { get; set; }
        public decimal Balance { get; set; }
        public bool IsActive { get; set; }
        public bool IsAssigned { get; set; }
        public string Description { get; set; }
        public DateTime? Lastcharge { get; set; }
        public DateTime? LastDeposit { get; set; }
        public DateTime? LastDeletion { get; set; }

        public virtual ICollection<CardDeletionHistories> CardDeletionHistories { get; set; }
        public virtual ICollection<CardTransactions> CardTransactions { get; set; }
        public virtual ICollection<Cliente> Cliente { get; set; }
    }
}
