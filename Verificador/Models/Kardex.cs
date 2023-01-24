using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class Kardex
    {
        public int KardexId { get; set; }
        public string ConceptoMovInvId { get; set; }
        public string ProductoId { get; set; }
        public int ReferenciaId { get; set; }
        public int ReferenciapId { get; set; }
        public string UsuarioId { get; set; }
        public string Estacionid { get; set; }
        public string ClienteId { get; set; }
        public string ProveedorId { get; set; }
        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Anio { get; set; }
        public string Descripcion { get; set; }
        public decimal Min { get; set; }
        public decimal Max { get; set; }
        public decimal Costo { get; set; }
        public decimal CantEntrada { get; set; }
        public decimal VlEntrada { get; set; }
        public decimal CantSalida { get; set; }
        public decimal VlSalida { get; set; }
        public decimal StockRestante { get; set; }
        public decimal CantGlobal { get; set; }
        public decimal VlGlobal { get; set; }
        public bool TieneLote { get; set; }
        public string NoLote { get; set; }
        public DateTime Caducidad { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
    }
}
