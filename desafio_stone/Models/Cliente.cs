using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace desafio_stone.Models
{
    public class Cliente
    {
        #region: Atributos da classe
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [StringLength(30)]
        public string nome { get; set; }
        [StringLength(13)]
        public string cpf { get; set; }
        [StringLength(10)]
        public string data_de_nascimento { get; set; }
        [StringLength(14)]
        public string numero_do_cartao { get; set; }
        public List<Pagamento> pagamentos { get; set; }
        #endregion

        #region: Construtor
        public Cliente()
        {
            this.setDefaultValues();
        }
        public void setDefaultValues()
        {
            this.id = -1;
            this.nome = "";
            this.cpf = "";
            this.data_de_nascimento = "";
            this.numero_do_cartao = "";
            this.pagamentos = new List<Pagamento>();
          #endregion
        }
    }
}