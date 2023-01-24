using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class CardTransactions
    {
        public int CardTransactionId { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string CardId { get; set; }
        public int CardRoleId { get; set; }
        public int ActionFlag { get; set; }
        public decimal BonusRate { get; set; }
        public decimal Ammount { get; set; }
        public int VentaId { get; set; }
        public string ClienteId { get; set; }

        public virtual Cards Card { get; set; }
        public virtual CardRoles CardRole { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Venta Venta { get; set; }
    }
}
