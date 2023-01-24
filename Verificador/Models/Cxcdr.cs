using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class Cxcdr
    {
        public int CxcdrId { get; set; }
        public int CxcpId { get; set; }
        public string IdDocumento { get; set; }
        public string Serie { get; set; }
        public string Folio { get; set; }
        public string MonedaDr { get; set; }
        public decimal? TipoCambioDr { get; set; }
        public string MetodoPagoDr { get; set; }
        public int NumParcialidad { get; set; }
        public decimal ImporteSaldoAnt { get; set; }
        public decimal ImportePagado { get; set; }
        public decimal ImporteSaldoInsoluto { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string EstacionId { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }

        public virtual Usuario CreatedByNavigation { get; set; }
        public virtual Cxcp Cxcp { get; set; }
    }
}
