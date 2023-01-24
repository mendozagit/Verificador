using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class Venta
    {
        public Venta()
        {
            CardTransactions = new HashSet<CardTransactions>();
            LoteVentap = new HashSet<LoteVentap>();
            LxcDocument = new HashSet<LxcDocument>();
            Punto = new HashSet<Punto>();
            VentaImpuesto = new HashSet<VentaImpuesto>();
            Ventap = new HashSet<Ventap>();
        }

        public int VentaId { get; set; }
        public int? NoRef { get; set; }
        public string TipoDocId { get; set; }
        public string TipoComprobante { get; set; }
        public DateTime? FechaDoc { get; set; }
        public string ClienteId { get; set; }
        public int? NoPrecio { get; set; }
        public string EstadoDocId { get; set; }
        public string MonedaId { get; set; }
        public string DatosCliente { get; set; }
        public bool EnFactCierre { get; set; }
        public bool? Anulada { get; set; }
        public bool EsConversiondeTaF { get; set; }
        public int? VentaOrigen { get; set; }
        public int? CxcId { get; set; }
        public string EstatusSat { get; set; }
        public string ConceptoPago1 { get; set; }
        public string ConceptoPago2 { get; set; }
        public string ConceptoPago3 { get; set; }
        public string FormaPago1 { get; set; }
        public string FormaPago2 { get; set; }
        public string FormaPago3 { get; set; }
        public string EstacionId { get; set; }
        public bool Cortada { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public decimal Pago1 { get; set; }
        public decimal Pago2 { get; set; }
        public decimal Pago3 { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Impuesto { get; set; }
        public decimal Total { get; set; }
        public decimal? Descuento { get; set; }
        public decimal DescXpuntos { get; set; }
        public decimal Cambio { get; set; }
        public bool PuntosAplicados { get; set; }
        public string TotalConLetra { get; set; }
        public bool? EsCxc { get; set; }
        public bool EsFacturaGlobal { get; set; }
        public string MetodoPago { get; set; }
        public string UsoCfdi { get; set; }
        public decimal? Unidades { get; set; }
        public string UuId { get; set; }
        public string RutaXml { get; set; }
        public string NoCertificado { get; set; }
        public string CadenaOriginal { get; set; }
        public string SelloCfdi { get; set; }
        public string SelloSat { get; set; }
        public DateTime? FechaSistema { get; set; }
        public DateTime? FechaTimbrado { get; set; }
        public string Xml { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public byte[] ArchivoSoporteDocumental { get; set; }
        public string ExtensionArchivoSoporteDocumental { get; set; }
        public string MotivoCancelacionId { get; set; }
        public string UuidSustitucion { get; set; }
        public int VentaIdSustitucion { get; set; }
        public short Anio { get; set; }
        public string Mes { get; set; }
        public string Periodicidad { get; set; }
        public decimal SubTotalEsperado { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Usuario CreatedByNavigation { get; set; }
        public virtual Estacion Estacion { get; set; }
        public virtual MotivoCancelacion MotivoCancelacion { get; set; }
        public virtual TipoDoc TipoDoc { get; set; }
        public virtual CUsocfdi UsoCfdiNavigation { get; set; }
        public virtual ICollection<CardTransactions> CardTransactions { get; set; }
        public virtual ICollection<LoteVentap> LoteVentap { get; set; }
        public virtual ICollection<LxcDocument> LxcDocument { get; set; }
        public virtual ICollection<Punto> Punto { get; set; }
        public virtual ICollection<VentaImpuesto> VentaImpuesto { get; set; }
        public virtual ICollection<Ventap> Ventap { get; set; }
    }
}
