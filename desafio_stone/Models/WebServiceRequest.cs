using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.IO;
using System.Web;

namespace desafio_stone.Models
{
    public class WebServiceRequest
    {
        #region: Variáveis
        public string method = "GET";
        public string servidor = "";
        public string mensagemSistema = "";
        #endregion

        #region: Construtor
        public WebServiceRequest()
        {

        }
        
        public WebServiceRequest(string servidor, string method)
        {
            this.servidor = servidor;
            this.method = method;
        }
        #endregion

        #region: Operações
        public string RequestDadosWeb()
        {
            WebRequest context;
            WebResponse contents = null;
            string resposta = "";
            StreamReader objSR = null;
           
            try
            { 
                context = HttpWebRequest.Create(servidor);
                context.Method = this.method;
                context.ContentType = "application/x-www-form-urlencoded\r\n";

                contents = context.GetResponse();
                try
                {
                    objSR = new StreamReader(contents.GetResponseStream());
                    resposta = objSR.ReadToEnd();
                }
                catch (Exception ex)
                {
                    mensagemSistema = ex.ToString();
                }
            }
            catch (Exception ex)
            {
                mensagemSistema = ex.ToString();
            }
            finally
            {
                try
                {
                    //objSR.Close();
                }
                catch (Exception ex)
                {
                    mensagemSistema = ex.ToString();
                }
                try
                {
                    contents.Close();
                    mensagemSistema = "";
                }
                catch (Exception e)
                {
                    mensagemSistema = e.ToString();
                }
            }
            return resposta;
        }
        #endregion
    }
}