using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace desafio_stone.Models
{
    public class Pagamento : Estabelecimento
    {
        #region: Atributos da classe
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_pagamento { get; set; }
        [StringLength(40)]
        public String valor { get; set; }
        [StringLength(10)]
        public String data { get; set; }
        [StringLength(40)]
        public int id_cliente { get; set; }
        private List<Pagamento> lista { get; set; }
        #endregion

        #region: Construtor
        public Pagamento()
        {
            this.setDefault();
        }
        public void setDefault()
        {
            this.id_pagamento = -1;
            this.valor = 0;
            this.data = "";
            this.id_cliente = 0;
            this.lista = new List<Pagamento>();
        }
        #endregion
    }
}