using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

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

        public static List<string> TrataJsonQuestoes(string result)
        {
            List<string> lista = new List<string>();

            Model.Questoes.MD_Main temp = JsonConvert.DeserializeObject<Model.Questoes.MD_Main>(RemoveDiacritics(TrataDados(result)));

            temp.data.rows.ForEach(item =>
            {
                string texto = string.Empty;

                texto += "{";
                texto += "   \"questao\":{";
                texto += $"      \"Campoquestao\":\"{item.enunciado_clean}\",";
                texto += "      \"Observacaoquestao\":\"\",";
                texto += $"      \"Materia\":\"{(item.areas.Count > 0 ? item.areas[0].descricao : string.Empty)}\",";
                texto += "      \"Codigoprova\":\"9999\",";
                texto += "      \"Numeroquestao\":\"999\",";
                texto += "      \"anexosQuestao\":[";
                texto += "";
                texto += "      ]";
                texto += "   },";
                texto += "   \"respostas\":[";

                bool first = true;
                item.itens.ForEach(resposta =>
                {
                    if (first)
                    {
                        first = false;
                    }
                    else
                    {
                        texto += ",";
                    }

                    texto += "      {";
                    texto += $"         \"Textoresposta\":\"{resposta.corpo}\",";
                    texto += $"         \"Certa\":\"{(resposta.id == item.resposta ? "1" : "0")}\",";
                    texto += "         \"Observacaoresposta\":\"\",";
                    texto += "         \"anexos\":[";
                    texto += "";
                    texto += "         ]";
                    texto += "      }";
                });

                texto += "   ],";
                texto += "   \"codUsuario\":\"15\"";
                texto += "}";

                lista.Add(texto);
            });

            return lista;
        }

        private static string TrataDados(string dados)
        {
            return dados.Replace("style=text-align: justify;", string.Empty);
        }

        private static string RemoveDiacritics(string text)
        {
            //return text.Replace("\u00c0", "À").Replace("\u00c1", "Á").Replace("\u00c2", "Â").Replace("\u00c3", "Ã").Replace("\u00c4", "Ä").Replace("\u00c5", "Å").Replace("\u00c6", "Æ").Replace("\u00c7", "Ç").Replace("\u00c8", "È").Replace("\u00c9", "É").Replace("\u00ca", "Ê").Replace("\u00cb", "Ë").Replace("\u00cc", "Ì").Replace("\u00cd", "Í").Replace("\u00ce", "Î").Replace("\u00cf", "Ï").Replace("\u00d1", "Ñ").Replace("\u00d2", "Ò").Replace("\u00d3", "Ó").Replace("\u00d4", "Ô").Replace("\u00d5", "Õ").Replace("\u00d6", "Ö").Replace("\u00d8", "Ø").Replace("\u00d9", "Ù").Replace("\u00da", "Ú").Replace("\u00db", "Û").Replace("\u00dc", "Ü").Replace("\u00dd", "Ý").Replace("\u00df", "ß").Replace("\u00e0", "à").Replace("\u00e1", "á").Replace("\u00e2", "â").Replace("\u00e3", "ã").Replace("\u00e4", "ä").Replace("\u00e5", "å").Replace("\u00e6", "æ").Replace("\u00e7", "ç").Replace("\u00e8", "è").Replace("\u00e9", "é").Replace("\u00ea", "ê").Replace("\u00eb", "ë").Replace("\u00ec", "ì").Replace("\u00ed", "í").Replace("\u00ee", "î").Replace("\u00ef", "ï").Replace("\u00f0", "ð").Replace("\u00f1", "ñ").Replace("\u00f2", "ò").Replace("\u00f3", "ó").Replace("\u00f4", "ô").Replace("\u00f5", "õ").Replace("\u00f6", "ö").Replace("\u00f8", "ø").Replace("\u00f9", "ù").Replace("\u00fa", "ú").Replace("\u00fb", "û").Replace("\u00fc", "ü").Replace("\u00fd", "ý").Replace("\u00ff", "ÿ");
            return text.Replace("u00c0", "À").Replace("u00c1", "Á").Replace("u00c2", "Â").Replace("u00c3", "Ã").Replace("u00c4", "Ä").Replace("u00c5", "Å").Replace("u00c6", "Æ").Replace("u00c7", "Ç").Replace("u00c8", "È").Replace("u00c9", "É").Replace("u00ca", "Ê").Replace("u00cb", "Ë").Replace("u00cc", "Ì").Replace("u00cd", "Í").Replace("u00ce", "Î").Replace("u00cf", "Ï").Replace("u00d1", "Ñ").Replace("u00d2", "Ò").Replace("u00d3", "Ó").Replace("u00d4", "Ô").Replace("u00d5", "Õ").Replace("u00d6", "Ö").Replace("u00d8", "Ø").Replace("u00d9", "Ù").Replace("u00da", "Ú").Replace("u00db", "Û").Replace("u00dc", "Ü").Replace("u00dd", "Ý").Replace("u00df", "ß").Replace("u00e0", "à").Replace("u00e1", "á").Replace("u00e2", "â").Replace("u00e3", "ã").Replace("u00e4", "ä").Replace("u00e5", "å").Replace("u00e6", "æ").Replace("u00e7", "ç").Replace("u00e8", "è").Replace("u00e9", "é").Replace("u00ea", "ê").Replace("u00eb", "ë").Replace("u00ec", "ì").Replace("u00ed", "í").Replace("u00ee", "î").Replace("u00ef", "ï").Replace("u00f0", "ð").Replace("u00f1", "ñ").Replace("u00f2", "ò").Replace("u00f3", "ó").Replace("u00f4", "ô").Replace("u00f5", "õ").Replace("u00f6", "ö").Replace("u00f8", "ø").Replace("u00f9", "ù").Replace("u00fa", "ú").Replace("u00fb", "û").Replace("u00fc", "ü").Replace("u00fd", "ý").Replace("u00ff", "ÿ").Replace("u201c", string.Empty).Replace("u201d", string.Empty).Replace("u2013","-").Replace("u00aa","ª").Replace("u2022","<br></li><li>").Replace("ud835udc43", "P").Replace("821d2", "->").Replace("ud835udc44", "Q").Replace("u2192", "->").Replace("u2228", "v");
        }

        /// <summary>
        /// Método que gera um número aleatorio
        /// </summary>
        /// <param name="max"></param>
        /// <returns></returns>
        public static int NumeroAleatorio(int max)
        {
            Random rnd = new Random();
            int random = rnd.Next(0, max);

            return random;
        }
    }
}
