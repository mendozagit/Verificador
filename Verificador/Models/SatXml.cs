using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class SatXml
    {
        public SatXml()
        {
            SatXmlItem = new HashSet<SatXmlItem>();
        }

        public int SatXmlId { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int SatPackageId { get; set; }
        public string XmlBase64 { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string InvoiceSeries { get; set; }
        public string InvoiceNumber { get; set; }
        public string InvoiceType { get; set; }
        public decimal InvoiceSubTotal { get; set; }
        public decimal InvoiceTotal { get; set; }
        public string InvoiceSupplier { get; set; }
        public string InvoiceSupplierRfc { get; set; }
        public string InvoiceCustomer { get; set; }
        public string InvoiceCustomerRfc { get; set; }
        public string InvoiceUuid { get; set; }

        public virtual SatPackage SatPackage { get; set; }
        public virtual ICollection<SatXmlItem> SatXmlItem { get; set; }
    }
}
