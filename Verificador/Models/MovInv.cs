using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class MovInv
    {
        public int MovInvId { get; set; }
        public DateTime FechaOperacion { get; set; }
        public string ConceptoMovsInvId { get; set; }
        public string ProductoId { get; set; }
        public string CreatedBy { get; set; }
        public string ProveedorId { get; set; }
        public string ClienteId { get; set; }
        public string EstacionId { get; set; }
        public int ReferenciaId { get; set; }
        public int ReferenciapId { get; set; }
        public string Es { get; set; }
        public decimal Cantidad { get; set; }
        public decimal UltimoCosto { get; set; }
        public decimal Costopp { get; set; }
        public decimal Valor { get; set; }
        public decimal StockAlMomento { get; set; }
        public decimal PrecioVta { get; set; }
        public int Afectacion { get; set; }
        public bool IsDeleted { get; set; }
        public bool TieneLote { get; set; }
        public string NoLote { get; set; }
        public DateTime Caducidad { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ConceptoMovInv ConceptoMovsInv { get; set; }
        public virtual Usuario CreatedByNavigation { get; set; }
    }
}
