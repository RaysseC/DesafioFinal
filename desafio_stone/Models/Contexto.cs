using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace desafio_stone.Models
{
    public class Contexto : DbContext
    {
        public Contexto() : base("name=loja")
        {
        }

        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Estabelecimento> Estabelecimento { get; set; }
        public virtual DbSet<Pagamento> Pagamento { get; set; }

    }
}