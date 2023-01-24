using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class CardDeletionHistories
    {
        public int CardDeletionHistoryId { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string CardId { get; set; }
        public decimal Ammount { get; set; }
        public bool? WasActiveAtTime { get; set; }

        public virtual Cards Card { get; set; }
    }
}
