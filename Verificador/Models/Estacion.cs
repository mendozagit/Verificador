﻿using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class Estacion
    {
        public Estacion()
        {
            Compra = new HashSet<Compra>();
            Corte = new HashSet<Corte>();
            Venta = new HashSet<Venta>();
        }

        public string EstacionId { get; set; }
        public string Nombre { get; set; }
        public bool IsDeleted { get; set; }
        public string ImpresoraT { get; set; }
        public string ImpresoraF { get; set; }
        public string ImpresoraNc { get; set; }
        public int DefaultAlmacenId { get; set; }
        public bool VenderSinStock { get; set; }
        public bool SolicitarFmpago { get; set; }
        public bool CanjearPuntosAuto { get; set; }
        public bool SumarUnidadesPdv { get; set; }
        public int TantosT { get; set; }
        public int TantosF { get; set; }
        public int TantosNc { get; set; }

        public virtual ICollection<Compra> Compra { get; set; }
        public virtual ICollection<Corte> Corte { get; set; }
        public virtual ICollection<Venta> Venta { get; set; }
    }
}
