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

        public static string TrataRetornoJsonContaBancaria(string htmlContaBancaria)
        {
            if (string.IsNullOrEmpty(htmlContaBancaria)) return string.Empty;

            string retorno = "{" + Environment.NewLine;
            string breaker = string.Empty;
            string temp = string.Empty;

            breaker = "<div id=\"conta_corrente\" onclick=\"fourdevs.selectText(this)\" class=\"output-txt output-txt-active\">";
            htmlContaBancaria = htmlContaBancaria.Substring(htmlContaBancaria.IndexOf(breaker) + (breaker.Length));
            
            breaker = "<span class=\"clipboard-copy\"></span>";
            temp = htmlContaBancaria.Substring(0, htmlContaBancaria.IndexOf(breaker));

            retorno += $"    \"ContaCorrente\":\"{temp}\",";

            htmlContaBancaria = htmlContaBancaria.Substring(htmlContaBancaria.IndexOf(breaker) + (breaker.Length));

            breaker = "<div id=\"agencia\" onclick=\"fourdevs.selectText(this)\" class=\"output-txt output-txt-active\">";
            htmlContaBancaria = htmlContaBancaria.Substring(htmlContaBancaria.IndexOf(breaker) + (breaker.Length));

            breaker = "<span class=\"clipboard-copy\"></span>";
            temp = htmlContaBancaria.Substring(0, htmlContaBancaria.IndexOf(breaker));

            retorno += $"    \"Agencia\":\"{temp}\",";

            htmlContaBancaria = htmlContaBancaria.Substring(htmlContaBancaria.IndexOf(breaker) + (breaker.Length));

            breaker = "<div id=\"banco\" onclick=\"fourdevs.selectText(this)\" class=\"output-txt output-txt-active\">";
            htmlContaBancaria = htmlContaBancaria.Substring(htmlContaBancaria.IndexOf(breaker) + (breaker.Length));

            breaker = "<span class=\"clipboard-copy\"></span>";
            temp = htmlContaBancaria.Substring(0, htmlContaBancaria.IndexOf(breaker));

            retorno += $"    \"Banco\":\"{temp}\",";

            htmlContaBancaria = htmlContaBancaria.Substring(htmlContaBancaria.IndexOf(breaker) + (breaker.Length));

            breaker = "<div id=\"cidade\" onclick=\"fourdevs.selectText(this)\" class=\"output-txt output-txt-active\">";
            htmlContaBancaria = htmlContaBancaria.Substring(htmlContaBancaria.IndexOf(breaker) + (breaker.Length));

            breaker = "<span class=\"clipboard-copy\"></span>";
            temp = htmlContaBancaria.Substring(0, htmlContaBancaria.IndexOf(breaker));

            retorno += $"    \"Cidade\":\"{temp}\",";

            htmlContaBancaria = htmlContaBancaria.Substring(htmlContaBancaria.IndexOf(breaker) + (breaker.Length));

            breaker = "<div id=\"estado\" onclick=\"fourdevs.selectText(this)\" class=\"output-txt output-txt-active\">";
            htmlContaBancaria = htmlContaBancaria.Substring(htmlContaBancaria.IndexOf(breaker) + (breaker.Length));

            breaker = "<span class=\"clipboard-copy\"></span>";
            temp = htmlContaBancaria.Substring(0, htmlContaBancaria.IndexOf(breaker));

            retorno += $"    \"Estado\":\"{temp}\"";

            retorno += Environment.NewLine + "}";

            return retorno;
        }

        public static string TrataRetornoJsonCartaoCredito(string htmlContaBancaria)
        {
            if (string.IsNullOrEmpty(htmlContaBancaria)) return string.Empty;

            string retorno = "{" + Environment.NewLine;
            string breaker = string.Empty;
            string temp = string.Empty;

            breaker = "<div id=\"cartao_numero\" onclick=\"fourdevs.selectText(this)\" class=\"output-txt output-txt-active\">";
            htmlContaBancaria = htmlContaBancaria.Substring(htmlContaBancaria.IndexOf(breaker) + (breaker.Length));

            breaker = "<span class=\"clipboard-copy\"></span>";
            temp = htmlContaBancaria.Substring(0, htmlContaBancaria.IndexOf(breaker));

            retorno += $"    \"NumeroCartao\":\"{temp}\",";

            htmlContaBancaria = htmlContaBancaria.Substring(htmlContaBancaria.IndexOf(breaker) + (breaker.Length));

            breaker = "<div id=\"data_validade\" onclick=\"fourdevs.selectText(this)\" class=\"output-txt output-txt-active\">";
            htmlContaBancaria = htmlContaBancaria.Substring(htmlContaBancaria.IndexOf(breaker) + (breaker.Length));

            breaker = "<span class=\"clipboard-copy\"></span>";
            temp = htmlContaBancaria.Substring(0, htmlContaBancaria.IndexOf(breaker));

            retorno += $"    \"DataValidade\":\"{temp}\",";

            htmlContaBancaria = htmlContaBancaria.Substring(htmlContaBancaria.IndexOf(breaker) + (breaker.Length));

            breaker = "<div id=\"codigo_seguranca\" onclick=\"fourdevs.selectText(this)\" class=\"output-txt output-txt-active\">";
            htmlContaBancaria = htmlContaBancaria.Substring(htmlContaBancaria.IndexOf(breaker) + (breaker.Length));

            breaker = "<span class=\"clipboard-copy\"></span>";
            temp = htmlContaBancaria.Substring(0, htmlContaBancaria.IndexOf(breaker));

            retorno += $"    \"Cvc\":\"{temp}\",";

            retorno += Environment.NewLine + "}";

            return retorno;
        }

        public static string TrataVerbos(string html)
        {
            string retorno = string.Empty;
            List<string> lista = html.Split(new[] { "</a>" }, StringSplitOptions.RemoveEmptyEntries).ToList();

            int contador = 0;
            foreach (string texto in lista)
            {
                contador++;
                if (contador + 1 == lista.Count)
                    break;

                List<string> lista2 = texto.Split('>').ToList();
                retorno += lista2[3] + Environment.NewLine;
            }

            return retorno;
        }

        public static string TrataConjugacao(string verbo, string html)
        {
            string retorno = string.Empty;
            List<string> lista = html.Split(new[] { "<span><span><span>" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            lista.RemoveAt(0);

            string linhaEu = string.Empty;
            string linhaTu = string.Empty;
            string linhaEle = string.Empty;
            string linhaNos = string.Empty;
            string linhaVos = string.Empty;
            string linhaEles = string.Empty;

            int contador = 0;
            foreach (string texto in lista)
            {
                contador++;
                List<string> lista3 = texto.Split(new[] { "</span></span>" }, StringSplitOptions.RemoveEmptyEntries).ToList();

                linhaEu   += (contador == 1 ? lista3[0].Substring(0,  lista3[0].IndexOf("</span>")) : string.Empty) + ";" + lista3[0].Substring(lista3[0].IndexOf("\">") + 2);
                linhaTu   += (contador == 1 ? lista3[1].Substring(16, lista3[1].Substring(16).IndexOf("</span>")) : string.Empty) + ";" + lista3[1].Substring(lista3[1].IndexOf("\">") + 2);
                linhaEle  += (contador == 1 ? lista3[2].Substring(16, lista3[2].Substring(16).IndexOf("</span>")) : string.Empty) + ";" + lista3[2].Substring(lista3[2].IndexOf("\">") + 2);
                linhaNos  += (contador == 1 ? lista3[3].Substring(16, lista3[3].Substring(16).IndexOf("</span>")) : string.Empty) + ";" + lista3[3].Substring(lista3[3].IndexOf("\">") + 2);
                linhaVos  += (contador == 1 ? lista3[4].Substring(16, lista3[4].Substring(16).IndexOf("</span>")) : string.Empty) + ";" + lista3[4].Substring(lista3[4].IndexOf("\">") + 2);
                linhaEles += (contador == 1 ? lista3[5].Substring(16, lista3[5].Substring(16).IndexOf("</span>")) : string.Empty) + ";" + lista3[5].Substring(lista3[5].IndexOf("\">") + 2);
            }

            List<string> listaEu   = linhaEu.Split(';').ToList();
            List<string> listaTu   = linhaTu.Split(';').ToList();
            List<string> listaEle  = linhaEle.Split(';').ToList();
            List<string> listaNos  = linhaNos.Split(';').ToList();
            List<string> listaVos  = linhaVos.Split(';').ToList();
            List<string> listaEles = linhaEles.Split(';').ToList();

            retorno += "{";
            retorno += $"    \"Verbo\":\"{verbo}\",";
            retorno += $"    \"Pronome\":\"{listaEu[0]}\",";
            retorno += $"    \"Presente\":\"{listaEu[1]}\",";
            retorno += $"    \"PreteritoImperfeito\":\"{listaEu[2]}\",";
            retorno += $"    \"PreteritoPerfeito\":\"{listaEu[3]}\",";
            retorno += $"    \"PreteritoMaisQuePerfeito\":\"{listaEu[4]}\",";
            retorno += $"    \"FuturoDoPresente\":\"{listaEu[5]}\",";
            retorno += $"    \"FuturoDoPreterito\":\"{listaEu[6]}\"";
            retorno += "}" + Environment.NewLine;

            retorno += "{";
            retorno += $"    \"Verbo\":\"{verbo}\",";
            retorno += $"    \"Pronome\":\"{listaTu[0]}\",";
            retorno += $"    \"Presente\":\"{listaTu[1]}\",";
            retorno += $"    \"PreteritoImperfeito\":\"{listaTu[2]}\",";
            retorno += $"    \"PreteritoPerfeito\":\"{listaTu[3]}\",";
            retorno += $"    \"PreteritoMaisQuePerfeito\":\"{listaTu[4]}\",";
            retorno += $"    \"FuturoDoPresente\":\"{listaTu[5]}\",";
            retorno += $"    \"FuturoDoPreterito\":\"{listaTu[6]}\"";
            retorno += "}" + Environment.NewLine;

            retorno += "{";
            retorno += $"    \"Verbo\":\"{verbo}\",";
            retorno += $"    \"Pronome\":\"{listaEle[0]}\",";
            retorno += $"    \"Presente\":\"{listaEle[1]}\",";
            retorno += $"    \"PreteritoImperfeito\":\"{listaEle[2]}\",";
            retorno += $"    \"PreteritoPerfeito\":\"{listaEle[3]}\",";
            retorno += $"    \"PreteritoMaisQuePerfeito\":\"{listaEle[4]}\",";
            retorno += $"    \"FuturoDoPresente\":\"{listaEle[5]}\",";
            retorno += $"    \"FuturoDoPreterito\":\"{listaEle[6]}\"";
            retorno += "}" + Environment.NewLine;

            retorno += "{";
            retorno += $"    \"Verbo\":\"{verbo}\",";
            retorno += $"    \"Pronome\":\"{listaNos[0]}\",";
            retorno += $"    \"Presente\":\"{listaNos[1]}\",";
            retorno += $"    \"PreteritoImperfeito\":\"{listaNos[2]}\",";
            retorno += $"    \"PreteritoPerfeito\":\"{listaNos[3]}\",";
            retorno += $"    \"PreteritoMaisQuePerfeito\":\"{listaNos[4]}\",";
            retorno += $"    \"FuturoDoPresente\":\"{listaNos[5]}\",";
            retorno += $"    \"FuturoDoPreterito\":\"{listaNos[6]}\"";
            retorno += "}" + Environment.NewLine;

            retorno += "{";
            retorno += $"    \"Verbo\":\"{verbo}\",";
            retorno += $"    \"Pronome\":\"{listaVos[0]}\",";
            retorno += $"    \"Presente\":\"{listaVos[1]}\",";
            retorno += $"    \"PreteritoImperfeito\":\"{listaVos[2]}\",";
            retorno += $"    \"PreteritoPerfeito\":\"{listaVos[3]}\",";
            retorno += $"    \"PreteritoMaisQuePerfeito\":\"{listaVos[4]}\",";
            retorno += $"    \"FuturoDoPresente\":\"{listaVos[5]}\",";
            retorno += $"    \"FuturoDoPreterito\":\"{listaVos[6]}\"";
            retorno += "}" + Environment.NewLine;

            retorno += "{";
            retorno += $"    \"Verbo\":\"{verbo}\",";
            retorno += $"    \"Pronome\":\"{listaEles[0]}\",";
            retorno += $"    \"Presente\":\"{listaEles[1]}\",";
            retorno += $"    \"PreteritoImperfeito\":\"{listaEles[2]}\",";
            retorno += $"    \"PreteritoPerfeito\":\"{listaEles[3]}\",";
            retorno += $"    \"PreteritoMaisQuePerfeito\":\"{listaEles[4]}\",";
            retorno += $"    \"FuturoDoPresente\":\"{listaEles[5]}\",";
            retorno += $"    \"FuturoDoPreterito\":\"{listaEles[6]}\"";
            retorno += "}" + Environment.NewLine;

            lista.Clear();
            lista = null;

            listaEu  .Clear();
            listaTu  .Clear();
            listaEle .Clear();
            listaNos .Clear();
            listaVos .Clear();
            listaEles.Clear();

            listaEu = null;
            listaTu  = null;
            listaEle = null;
            listaNos = null;
            listaVos = null;
            listaEles= null;

            return retorno;
        }

        public static string TrataTraducao(string palavraportugues, string classeGramatical, string div)
        {
            string traducao = div;

            string jsonRetorno = "{" +
                                      $"\"Palavraportugues\":\"{palavraportugues}\"," +
                                      $"\"Palavraingles\":\"{traducao}\"," +
                                      $"\"Classegramatical\":\"{classeGramatical}\"" +
                                  "}";
            return jsonRetorno;
        }
    }
}
