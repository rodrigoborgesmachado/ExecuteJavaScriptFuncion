using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecuteJavaScriptFuncion.Util
{
    public static class Funcoes
    {
        public static string TrataRetornoJsonEmpresa(string jsonEmpresa)
        {
            string retorno = "{" + Environment.NewLine;
            int i = 0;
            while (!string.IsNullOrEmpty(jsonEmpresa))
            {
                jsonEmpresa = jsonEmpresa.Substring(jsonEmpresa.IndexOf("<div") + ("<div".Length));
                if (string.IsNullOrEmpty(jsonEmpresa))
                    break;

                if (i > 0)
                    retorno += "," + Environment.NewLine;
                else
                    i = 1;
                retorno += "\"";

                foreach (char a in jsonEmpresa.Substring(jsonEmpresa.IndexOf("id=\"") + ("id=\"".Length)))
                {

                    retorno += a;
                    if (a == '\"')
                    {
                        break;
                    }
                }
                jsonEmpresa = jsonEmpresa.Substring(jsonEmpresa.IndexOf("id=\"") + ("id=\"".Length));
                retorno += ":\"";

                if (string.IsNullOrEmpty(jsonEmpresa))
                    break;

                foreach (char a in jsonEmpresa.Substring(jsonEmpresa.IndexOf("value=\"") + ("value=\"".Length)))
                {

                    retorno += a;
                    if (a == '\"')
                    {
                        break;
                    }
                }
                retorno += "";
                jsonEmpresa = jsonEmpresa.Substring(jsonEmpresa.IndexOf("value=\"") + ("value=\"".Length));

                if (string.IsNullOrEmpty(jsonEmpresa))
                    break;

                if (jsonEmpresa.IndexOf("row small-collapse") == -1)
                    break;

                jsonEmpresa = jsonEmpresa.Substring(jsonEmpresa.IndexOf("row small-collapse") + ("row small-collapse".Length));
                if (string.IsNullOrEmpty(jsonEmpresa))
                    break;


            }
            retorno += Environment.NewLine + "}";

            return retorno;
        }

        public static string TrataRetornoJsonVeiculo(string jsonEmpresa)
        {
            string retorno = "{" + Environment.NewLine;
            int i = 0;
            while (!string.IsNullOrEmpty(jsonEmpresa))
            {
                jsonEmpresa = jsonEmpresa.Substring(jsonEmpresa.IndexOf("title=\"Marca\"") + ("title=\"Marca\"".Length));
                if (string.IsNullOrEmpty(jsonEmpresa))
                    break;

                if (i > 0)
                    retorno += "," + Environment.NewLine;
                else
                    i = 1;
                retorno += "\"";

                foreach (char a in jsonEmpresa.Substring(jsonEmpresa.IndexOf("id=\"") + ("id=\"".Length)))
                {

                    retorno += a;
                    if (a == '\"')
                    {
                        break;
                    }
                }
                jsonEmpresa = jsonEmpresa.Substring(jsonEmpresa.IndexOf("id=\"") + ("id=\"".Length));
                retorno += ":\"";

                if (string.IsNullOrEmpty(jsonEmpresa))
                    break;

                foreach (char a in jsonEmpresa.Substring(jsonEmpresa.IndexOf("value=\"") + ("value=\"".Length)))
                {

                    retorno += a;
                    if (a == '\"')
                    {
                        break;
                    }
                }
                retorno += "";
                jsonEmpresa = jsonEmpresa.Substring(jsonEmpresa.IndexOf("value=\"") + ("value=\"".Length));

                if (string.IsNullOrEmpty(jsonEmpresa))
                    break;

                if (jsonEmpresa.IndexOf("row small-collapse") == -1)
                    break;

                jsonEmpresa = jsonEmpresa.Substring(jsonEmpresa.IndexOf("row small-collapse") + ("row small-collapse".Length));
                if (string.IsNullOrEmpty(jsonEmpresa))
                    break;


            }
            retorno += Environment.NewLine + "}";

            return retorno;
        }
    }
}
