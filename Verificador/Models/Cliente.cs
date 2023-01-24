using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            CardTransactions = new HashSet<CardTransactions>();
            Lxc = new HashSet<Lxc>();
            Punto = new HashSet<Punto>();
            Venta = new HashSet<Venta>();
        }

        public string ClienteId { get; set; }
        public string Rfc { get; set; }
        public bool IsDeleted { get; set; }
        public string Negocio { get; set; }
        public string RazonSocial { get; set; }
        public string Contancto { get; set; }
        public string Direccion { get; set; }
        public string Cp { get; set; }
        public string Municipio { get; set; }
        public string Localidad { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public int DiasCredito { get; set; }
        public decimal LimiteCredito { get; set; }
        public decimal Saldo { get; set; }
        public string Colonia { get; set; }
        public string Correo { get; set; }
        public string MetodoPagoId { get; set; }
        public string FormaPagoId { get; set; }
        public int? PrecioDefault { get; set; }
        public bool TieneLicencia { get; set; }
        public string UsoCfdiid { get; set; }
        public bool? EsCxc { get; set; }
        public bool TieneMonedero { get; set; }
        public string NoTarjetaPuntos { get; set; }
        public decimal DineroElectronico { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public int? BancoChid { get; set; }
        public int? BancoTdcid { get; set; }
        public int? BancoTddid { get; set; }
        public int? BancoTefid { get; set; }
        public string CuentaOrdCh { get; set; }
        public string CuentaOrdTdc { get; set; }
        public string CuentaOrdTdd { get; set; }
        public string CuentaOrdTef { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public string RegimenFiscal { get; set; }
        public string RegimenFiscalId { get; set; }
        public string CardId { get; set; }
        public string CardRoleDescription { get; set; }
        public int CardRoleId { get; set; }

        public virtual Banco BancoCh { get; set; }
        public virtual Banco BancoTdc { get; set; }
        public virtual Banco BancoTdd { get; set; }
        public virtual Banco BancoTef { get; set; }
        public virtual Cards Card { get; set; }
        public virtual CardRoles CardRole { get; set; }
        public virtual CFormapago FormaPago { get; set; }
        public virtual CMetodopago MetodoPago { get; set; }
        public virtual CUsocfdi UsoCfdi { get; set; }
        public virtual ICollection<CardTransactions> CardTransactions { get; set; }
        public virtual ICollection<Lxc> Lxc { get; set; }
        public virtual ICollection<Punto> Punto { get; set; }
        public virtual ICollection<Venta> Venta { get; set; }
    }
}
