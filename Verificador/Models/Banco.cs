using System;
using System.Collections.Generic;

namespace Verificador.Models
{
    public partial class Banco
    {
        public Banco()
        {
            ClienteBancoCh = new HashSet<Cliente>();
            ClienteBancoTdc = new HashSet<Cliente>();
            ClienteBancoTdd = new HashSet<Cliente>();
            ClienteBancoTef = new HashSet<Cliente>();
            Empresa = new HashSet<Empresa>();
        }

        public int BancoId { get; set; }
        public string NombreComercial { get; set; }
        public string RazonSocial { get; set; }
        public string Rfc { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<Cliente> ClienteBancoCh { get; set; }
        public virtual ICollection<Cliente> ClienteBancoTdc { get; set; }
        public virtual ICollection<Cliente> ClienteBancoTdd { get; set; }
        public virtual ICollection<Cliente> ClienteBancoTef { get; set; }
        public virtual ICollection<Empresa> Empresa { get; set; }
    }
}
