using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Almacen = new HashSet<Almacen>();
            CambiosPrecio = new HashSet<CambiosPrecio>();
            CierreInventario = new HashSet<CierreInventario>();
            Compra = new HashSet<Compra>();
            Corte = new HashSet<Corte>();
            Cxc = new HashSet<Cxc>();
            Cxcdr = new HashSet<Cxcdr>();
            Cxp = new HashSet<Cxp>();
            Devolucion = new HashSet<Devolucion>();
            Flujo = new HashSet<Flujo>();
            Inventario = new HashSet<Inventario>();
            MessageUsers = new HashSet<MessageUsers>();
            MovInv = new HashSet<MovInv>();
            Traspaso = new HashSet<Traspaso>();
            UsuarioRole = new HashSet<UsuarioRole>();
            Venta = new HashSet<Venta>();
        }

        public string UsuarioId { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Area { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsDeleted { get; set; }
        public string EstacionId { get; set; }
        public bool Facturar { get; set; }
        public bool Reportear { get; set; }
        public bool Auditor { get; set; }
        public bool Militarizado { get; set; }
        public bool? PuendeLanzarPdv { get; set; }
        public bool? PuedeGestionarCxc { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public string SectorId { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public bool? AllowPurchasesFromXml { get; set; }
        public bool? AllowsElectronicWalletManagement { get; set; }

        public virtual Sector Sector { get; set; }
        public virtual ICollection<Almacen> Almacen { get; set; }
        public virtual ICollection<CambiosPrecio> CambiosPrecio { get; set; }
        public virtual ICollection<CierreInventario> CierreInventario { get; set; }
        public virtual ICollection<Compra> Compra { get; set; }
        public virtual ICollection<Corte> Corte { get; set; }
        public virtual ICollection<Cxc> Cxc { get; set; }
        public virtual ICollection<Cxcdr> Cxcdr { get; set; }
        public virtual ICollection<Cxp> Cxp { get; set; }
        public virtual ICollection<Devolucion> Devolucion { get; set; }
        public virtual ICollection<Flujo> Flujo { get; set; }
        public virtual ICollection<Inventario> Inventario { get; set; }
        public virtual ICollection<MessageUsers> MessageUsers { get; set; }
        public virtual ICollection<MovInv> MovInv { get; set; }
        public virtual ICollection<Traspaso> Traspaso { get; set; }
        public virtual ICollection<UsuarioRole> UsuarioRole { get; set; }
        public virtual ICollection<Venta> Venta { get; set; }
    }
}
