using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class LxcDocument
    {
        public int LxcDocumentId { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int LxcId { get; set; }
        public int CxcId { get; set; }
        public int SaleId { get; set; }
        public int ReferenceNumber { get; set; }
        public string DocumentType { get; set; }
        public string StatusId { get; set; }
        public string DocumentOrigin { get; set; }
        public DateTime DateOriginDocument { get; set; }
        public DateTime DateCxc { get; set; }
        public DateTime DocumentExpirationDate { get; set; }
        public decimal DocumentSubTotal { get; set; }
        public decimal DocumentTaxes { get; set; }
        public decimal DocumentTotal { get; set; }
        public decimal DocumentBalance { get; set; }

        public virtual Cxc Cxc { get; set; }
        public virtual Lxc Lxc { get; set; }
        public virtual Venta Sale { get; set; }
    }
}
