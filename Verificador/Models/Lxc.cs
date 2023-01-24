using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class Lxc
    {
        public Lxc()
        {
            LxcDocument = new HashSet<LxcDocument>();
        }

        public int LxcId { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string Description { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string PaymentWayCode { get; set; }
        public string PaymentWay { get; set; }
        public string PaymentCurrencyId { get; set; }
        public string PaymentCurrency { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal PaymentSubTotal { get; set; }
        public decimal PaymentTaxes { get; set; }
        public decimal PaymentTotal { get; set; }
        public string StatusId { get; set; }
        public decimal Balance { get; set; }
        public decimal RealPayment { get; set; }
        public string AmbienteWs { get; set; }
        public string CadenaOriginal { get; set; }
        public string EstatusSat { get; set; }
        public DateTime? FechaTimbrado { get; set; }
        public string ListType { get; set; }
        public string NoCertificado { get; set; }
        public string RutaXml { get; set; }
        public string SelloCfdi { get; set; }
        public string SelloSat { get; set; }
        public string UuId { get; set; }
        public string Xml { get; set; }
        public int NoRef { get; set; }
        public int LxcIdSustitucion { get; set; }
        public string MotivoCancelacionId { get; set; }
        public string UuidSustitucion { get; set; }

        public virtual Cliente Customer { get; set; }
        public virtual MotivoCancelacion MotivoCancelacion { get; set; }
        public virtual ICollection<LxcDocument> LxcDocument { get; set; }
    }
}
