using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class SatXmlItem
    {
        public int SatXmlItemId { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int SatXmlId { get; set; }
        public string TaProductCode { get; set; }
        public string NoIdentification { get; set; }
        public string TaUnitCode { get; set; }
        public string Unit { get; set; }
        public decimal Quantity { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Amount { get; set; }
        public decimal Discount { get; set; }

        public virtual SatXml SatXml { get; set; }
    }
}
