using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class Cxcp
    {
        public Cxcp()
        {
            Cxcdr = new HashSet<Cxcdr>();
        }

        public int CxcpId { get; set; }
        public int CxcId { get; set; }
        public string ClienteId { get; set; }
        public string DebitoCredito { get; set; }
        public decimal Monto { get; set; }
        public string ReferenciaBancaria { get; set; }
        public DateTime FechaPago { get; set; }
        public string FormaPago { get; set; }
        public string Moneda { get; set; }
        public decimal? TipoCambiop { get; set; }
        public string NumOperacion { get; set; }
        public string NomBancoOrdExtranjero { get; set; }
        public string RfcCtaOrd { get; set; }
        public string CtaOrdenante { get; set; }
        public string RfcCtaBen { get; set; }
        public string CtaBeneficiario { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string EstacionId { get; set; }
        public bool Ndocumentos { get; set; }
        public string Observacion { get; set; }
        public int NoRef { get; set; }
        public string CadenaOriginal { get; set; }
        public string EstatusSat { get; set; }
        public DateTime? FechaTimbrado { get; set; }
        public string NoCertificado { get; set; }
        public string RutaXml { get; set; }
        public string SelloCfdi { get; set; }
        public string SelloSat { get; set; }
        public string UuId { get; set; }
        public string Xml { get; set; }
        public string AmbienteWs { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public int ListId { get; set; }
        public int CxcpIdSustitucion { get; set; }
        public string MotivoCancelacionId { get; set; }
        public string UuidSustitucion { get; set; }
        public decimal Proporcion { get; set; }

        public virtual Cxc Cxc { get; set; }
        public virtual MotivoCancelacion MotivoCancelacion { get; set; }
        public virtual ICollection<Cxcdr> Cxcdr { get; set; }
    }
}
