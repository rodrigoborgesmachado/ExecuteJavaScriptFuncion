using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ExecuteJavaScriptFuncion.Util
{
    public class WebTest
    {
        private static bool EnviaPessoaJsonPost(string url, string json)
        {
            bool retorno = true;
            try
            {
                var httpRequest = (HttpWebRequest)WebRequest.Create(url);
                httpRequest.Method = "POST";

                httpRequest.ContentType = "application/json";

                var data = json;

                using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
                {
                    streamWriter.Write(data);
                }

                var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                retorno = false;
            }

            return retorno;
        }

        public static bool EnviaPessoaInserir(string json)
        {
            bool retorno = true;
            try
            {
                return EnviaPessoaJsonPost("http://teste.sunsalesystem.com.br/api/fordev/pessoa/inserir", json);
            }
            catch (Exception e)
            {
                retorno = false;
            }

            return retorno;
        }

        public static bool EnviaEmpresaInserir(string json)
        {
            bool retorno = true;
            try
            {
                return EnviaPessoaJsonPost("http://teste.sunsalesystem.com.br/api/fordev/empresa/inserir", json);
            }
            catch (Exception e)
            {
                retorno = false;
            }

            return retorno;
        }

        public static bool EnviaVeiculoInserir(string json)
        {
            bool retorno = true;
            try
            {
                return EnviaPessoaJsonPost("http://teste.sunsalesystem.com.br/api/fordev/veiculo/inserir", json);
            }
            catch (Exception e)
            {
                retorno = false;
            }

            return retorno;
        }
    }
}
