using desafio_stone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using Nancy.ModelBinding;

namespace desafio_stone
{
    public class indexmodule : NancyModule
    {
        Contexto contexto = new Contexto();
        public indexmodule() : base("/loja")  
      {
            #region : Cadastrar Cliente
            Post["/incluirCliente"] = _ =>
            {
                var cliente = this.Bind<Cliente>();
                contexto.Cliente.Add(cliente);
                contexto.SaveChanges();
                return HttpStatusCode.OK;
            };
            #endregion

            #region: Listar Clientes
            Get["/listarClientes"] = x =>
            {
                var clientes = contexto.Cliente.ToList();
                return Response.AsJson(clientes);
            };
            #endregion

            #region: Consultar Cliente
            Get["consultarCliente/{id:int}"] = parameters =>
            {
                int id = parameters.id;
                var cliente = contexto.Cliente.FirstOrDefault(x => x.id == id);
                var pagamentos = contexto.Cliente.FirstOrDefault(x => x.id == id);
                return Response.AsJson(cliente);
            };
            #endregion

            #region: Listar Estabelecimentos
            Get["/listarEstabelecimentos"] = x =>
            {
                var estabelecimentos = contexto.Estabelecimento.ToList();
                return Response.AsJson(estabelecimentos);
            };
            #endregion

            #region: Consultar Estabelecimento
            Get["/consultarEstabelecimento/{id:int}"] = parameters =>
            {
                int id = parameters.id;
                var cliente = contexto.Cliente.FirstOrDefault(x => x.id == id);
                var pagamentos = contexto.Cliente.FirstOrDefault(x => x.id == id);
                return Response.AsJson(cliente);
            };
            #endregion

            #region:Cadastrar Estabelecimento
            Post["/incluirEstabelecimento"] = _ =>
            {
                var estabelecimento = this.Bind<Estabelecimento>();
                contexto.Estabelecimento.Add(estabelecimento);
                contexto.SaveChanges();
                return HttpStatusCode.OK;
            };
            #endregion

            #region: Efetuar Pagamento
            Post["/incluirPagamento"] = _ =>
            {
                var estabelecimento = this.Bind<Estabelecimento>();
                contexto.Estabelecimento.Add(estabelecimento);
                contexto.SaveChanges();
                return HttpStatusCode.OK;
            };
            #endregion


        }
        private String WSestabelecimento(String cnpj)
        {
            string servidor = "https://www.receitaws.com.br/v1/cnpj/" + cnpj;
            string method = "GET";
            WebServiceRequest s = new WebServiceRequest(servidor, method);
            Estabelecimento est = new Estabelecimento();


            return s.RequestDadosWeb();
        }
    }
}