using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class Empresa
    {
        public Empresa()
        {
            SatFile = new HashSet<SatFile>();
        }

        public int EmpresaId { get; set; }
        public string Nombre { get; set; }
        public string RazonSocial { get; set; }
        public string Rfc { get; set; }
        public string RegimenFiscalId { get; set; }
        public string RegimenFiscal { get; set; }
        public string Domicilio { get; set; }
        public string Cp { get; set; }
        public string RutaCer { get; set; }
        public string RutaKey { get; set; }
        public string ClavePrivada { get; set; }
        public string RutaFormatoTicket { get; set; }
        public string RutaFormatoFactura { get; set; }
        public string RutaFormatoCorte { get; set; }
        public string RutaCadenaOriginal { get; set; }
        public string DirectorioComprobantes { get; set; }
        public string DirectorioTickets { get; set; }
        public string DirectorioCortes { get; set; }
        public bool? IsDeleted { get; set; }
        public string UserWstimbrado { get; set; }
        public string PassWstimbrado { get; set; }
        public string DirectorioTrabajo { get; set; }
        public string DirectorioTraspasos { get; set; }
        public string DirectorioImg { get; set; }
        public string RutaPlantillaDetalleTraspaso { get; set; }
        public string DirectorioReportes { get; set; }
        public string DirectorioOpenSslBin { get; set; }
        public string RutaArchivoPfx { get; set; }
        public bool TimbradoTest { get; set; }
        public string FormatoParaTickets { get; set; }
        public string FormatoParaFacturas { get; set; }
        public string FormatoCortes { get; set; }
        public string FormatoCierres { get; set; }
        public string FormatoClientesXpuntos { get; set; }
        public string FormatoComprasXperido { get; set; }
        public string FormatoProdsXcompra { get; set; }
        public string FormatoMovsInv { get; set; }
        public string FormatoStockXprods { get; set; }
        public string FormatoInventarioAut { get; set; }
        public string FormatoComprasVsventas { get; set; }
        public string FormatoCatProds { get; set; }
        public string FormatoProdsXprecios { get; set; }
        public string FormatoProveed { get; set; }
        public string FormatoVentasAcosto { get; set; }
        public string FormatoVentasXpuntos { get; set; }
        public string FormatoVentasXperiodo { get; set; }
        public string FormatoVentasXperiodoDet { get; set; }
        public string FormatoEntradaXcompra { get; set; }
        public string DirectorioDevCom { get; set; }
        public string MicroPvdb { get; set; }
        public bool GuardarDescStd { get; set; }
        public string DirectorioInverarios { get; set; }
        public string SmtpClient { get; set; }
        public string Puerto { get; set; }
        public string PassEnvioCorreos { get; set; }
        public string AsuntoStd { get; set; }
        public string MensajeStd { get; set; }
        public string CorreoEnvios { get; set; }
        public string IpServer { get; set; }
        public int Timbres { get; set; }
        public int LongitudBusqueda { get; set; }
        public int RangoVistaReimpresiones { get; set; }
        public int? BancoId { get; set; }
        public string CuentaBeneficiaria { get; set; }
        public string FormaPagoCxcid { get; set; }
        public bool? ValidarFormasPagoBancarizadas { get; set; }
        public string DirectorioComp { get; set; }
        public string DirectorioAbonos { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public int DaysToVerifyCert { get; set; }
        public bool? LiquidarLxcValorSup { get; set; }
        public decimal InvervalDownloader { get; set; }
        public decimal InvervalSatComunications { get; set; }
        public bool? LaunchXmlDownloader { get; set; }
        public string PackageDirectory { get; set; }
        public bool? XmlDownloaderConfigured { get; set; }
        public decimal DaysSatComunications { get; set; }
        public bool? UseClassicPurchaseForm { get; set; }
        public bool? UseRoundingForce { get; set; }
        public bool? RunTemporalTask { get; set; }
        public bool? UseClassicTransferForm { get; set; }
        public bool? RequireAuthorizationCheck { get; set; }
        public string RequireAuthorizationUserIdTextbox { get; set; }
        public string RequireAuthorizationUserTextbox { get; set; }
        public DateTime LastDeletionDate { get; set; }
        public DateTime NextDeleteDate { get; set; }
        public decimal RateToPoints { get; set; }
        public bool? UsePointsSubsystem { get; set; }
        public bool? AskToUseEwalletBalanceAutomatically { get; set; }
        public string JobsMachineName { get; set; }
        public decimal DaysToSendNotifications { get; set; }
        public bool? SalePaidWithPointsGeneratesPoints { get; set; }

        public virtual Banco Banco { get; set; }
        public virtual CRegimenfiscal RegimenFiscalNavigation { get; set; }
        public virtual ICollection<SatFile> SatFile { get; set; }
    }
}
