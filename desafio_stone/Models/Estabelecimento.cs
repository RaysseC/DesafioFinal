using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace desafio_stone.Models
{
    public class Estabelecimento
    {
        #region: Atributos da classe
        public int id_estabelecimento { get; set; }
        public string nome { get; set; }
        [StringLength(100)]
        public string cnpj { get; set; }
        [StringLength(14)]
        public string natureza_juridica { get; set; }
        [StringLength(100)]
        public string situacao { get; set; }
        [StringLength(14)]
        private List<Estabelecimento> lista { get; set; }
        private bool setNome = false;
        #endregion

        #region: Construtor
        public Estabelecimento()
        {
            this.setDefaultValues();
        }
        public void setDefaultValues()
        {
            this.id_estabelecimento = -1;
            this.nome = "";
            this.cnpj = "";
            this.natureza_juridica = "";
            this.situacao = "";
            this.lista = new List<Estabelecimento>();
        }
        #endregion

    }
}