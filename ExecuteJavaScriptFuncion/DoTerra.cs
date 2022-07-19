using ExecuteJavaScriptFuncion.Util;
using mshtml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExecuteJavaScriptFuncion
{
    public partial class DoTerra : Form
    {
        public DoTerra()
        {
            InitializeComponent();

            BuscaOleos();
        }

        #region Métodos

        /// <summary>
        /// Método que busca os oleos
        /// </summary>
        private void BuscaOleos()
        {
            List<string> oleosIndividuais = BuscaOleosIndividuais();

            List<string> jsons = new List<string>();
            oleosIndividuais.ForEach(url => jsons.Add(BuscaOleoIndivisual(url)));

            jsons.ForEach(json => WebTest.EnviaOleoDoTerraInserir(json));
        }

        /// <summary>
        /// Método que busca os óleos indiviuais
        /// </summary>
        private List<string> BuscaOleosIndividuais()
        {
            List<string> urls = new List<string>();
            string html = string.Empty;
            for(int j = 0; j < 3; j++)
            {
                var url = $"https://www.doterra.com/BR/pt_BR/pl/single-oils?q=%3AdisplaySequence-desc&page={j}&sort=displaySequence-desc";

                var httpRequest = (HttpWebRequest)WebRequest.Create(url);
                httpRequest.Headers.Add("cookie", "f5_cspm=1234; f5avraaaaaaaaaaaaaaaa_session_=MFNKPFGEFHFJJIGLBHJFMDHPJDIKNIEAHOHIINLMJBOIFAECOFHFANFLAEBNJHHDFOIDFJMKMBOLJJIDIHKAFOAOIJCJBELGIMJAJEMDGKLLKPMMDHFEFLPGPBDIIKHP; f5avraaaaaaaaaaaaaaaa_session_=OAIDIDEMOGNIJIGFBPCOGCMCAKBDKIFOLGDFMJFLBPIEBHKBPCEAHGCMICFGMEPLIMGDNPKLHCPNOKIJCLOAHJDICLHIHKGLAIAMBFHCFAGGHAMKEBOLIAIADOGPCGGI; f5_cspm=1234; visid_incap_661002=Dw48gIojSgi5H21CbI53KJsws2IAAAAAQUIPAAAAAABGjsqvUDN7M7QSopjLR8Vr; notice_preferences=2:; notice_gdpr_prefs=0,1,2:; cmapi_cookie_privacy=permit 1,2,3; cmapi_gtm_bl=; _gcl_au=1.1.748165685.1655910675; __pdst=64037d8893ab477f9343f126addc74ea; marketLanguage=/BR/pt_BR; _fbp=fb.1.1655911044412.708475162; _pin_unauth=dWlkPVpEYzFaV1F3TW1VdE9ESmpNaTAwWVRVeUxUaGpaVFV0TlRVMFkyWTFZakEzTXpFMw; nlbi_661002=sgQRFEO7DHknKw3GjFnb+QAAAADUZeap1rBM2qrAj9TGQRwc; notice_behavior=implied,eu; _gid=GA1.2.1485132611.1656533631; incap_ses_9219_661002=pLtvO1yruRQvBwVHHHjwf3NCvWIAAAAAFsRHmT/PE5SbG0IknpHtnw==; incap_ses_1471_661002=jjr9Lrb8uzzUh3iw8wpqFEaMvWIAAAAAVxGMLl4jVN5q77i/AtqKqA==; incap_ses_989_661002=IIxuGq/CsADEEqsw/6K5DX+QvWIAAAAAxGn2XB6dtw9uH2jiB/E35Q==; reese84=3:9yg6Fo+1czbbSUVWNwSgUA==:t/OGEL0uBFKbRCRdD/wMMA1oQMliWaorZKkKg0Yzy9jhONB8haIAvBoOgjZwy4EcLm8JQ4cYmVsEgfbGSfaxBlIBfWV6e71CtC2IVw/FFzXyBL9z5xInnhZFLQGyQiw844UIvpr2mREagZWhVlY9hHQn19rfo+/fbMaoGqSXpUwnRYdHtnLjf0XR/dJcUqX1PdT4Q6ZbYkGfCYmaw/Ru//i9nJ9mJbjqQDaFaQ3HSYG6hFk4seo1S5WW3kWVP2Srpl7C+Op0MWFDz6sSER/COrm/7mUq9sKFqiRbYj41aIrQiJER0HjzTe8KHZbZmQsj/+tJDN2g8ttf1zDUQMqFyHZnxjiWZKZb+PYTumDCx7bQbJVF8bv3rdZbdwPJGDZoh6HU+tbkoHb5Uf7GJZKY+t+chiiuMdwokZNGGB18Lniq0Q5w0l9TAHPKjbq/agsY:bV2pd0vklAVSZsdzsxj6Wf9Rncc3rMwUiDbPG8JHmso=; fs_uid=#98984#5675743859576832:4557450220802048/1687446675; JSESSIONID=934E55EB5CAA1B10EF38660D81C5A59C.or-prd0-hyb-app4; JSESSIONID-B2BACC=934E55EB5CAA1B10EF38660D81C5A59C.or-prd0-hyb-app4; djaimses.c5e8=*; SameSite=None; _gat_UA-28403841-1=1; _gat_UA-28403841-10=1; nlbi_661002_2147483392=RtHDZhdU80/EsW2pjFnb+QAAAACI9d8CjauPA6eKef9ozIYV; ADRUM_BTa=\"R: 0 | g:8f6b54dd - e774 - 4fb3 - 954a - d7c78383a48e | n:doterra_8b838ba6 - b395 - 4869 - 8e1b - a5c8e407c69b\"; _ga_XW71K6YFHT=GS1.1.1656590806.10.1.1656591122.0; _ga=GA1.2.2113558045.1655910676; djaimid.c5e8=efe70f67-3889-4629-b0e8-8f62e42e5e01.1655910676.8.1656591122.1656552419.71ce324b-82cf-4070-b1c0-50c8a83ff15f");
                var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    html = streamReader.ReadToEnd();
                }

                string corte = string.Empty;
                for (int i = 0; i <= 24; i++)
                {
                    if (j == 2 && i == 16) break;

                    corte = "<div class=\"grid-item grid-product\" itemscope=\"\" itemtype=\"http://schema.org/Product\" data-qa=\"product-line-item-" + i + "\">";
                    html = html.Substring(html.IndexOf(corte) + corte.Length);

                    corte = "<a class=\"prod-image\" href=\"";
                    html = html.Substring(html.IndexOf(corte) + corte.Length);

                    corte = "\" style=";

                    if(html.Substring(0, html.IndexOf(corte)).Count() < 200)
                        urls.Add("https://www.doterra.com" + html.Substring(0, html.IndexOf(corte)));
                }
            }

            return urls;
        }

        /// <summary>
        /// Método que busca o oleo individual
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private string BuscaOleoIndivisual(string url)
        {
            string json = string.Empty;
            string html = string.Empty;

            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.Headers.Add("cookie", "f5_cspm=1234; f5avraaaaaaaaaaaaaaaa_session_=MFNKPFGEFHFJJIGLBHJFMDHPJDIKNIEAHOHIINLMJBOIFAECOFHFANFLAEBNJHHDFOIDFJMKMBOLJJIDIHKAFOAOIJCJBELGIMJAJEMDGKLLKPMMDHFEFLPGPBDIIKHP; f5avraaaaaaaaaaaaaaaa_session_=OAIDIDEMOGNIJIGFBPCOGCMCAKBDKIFOLGDFMJFLBPIEBHKBPCEAHGCMICFGMEPLIMGDNPKLHCPNOKIJCLOAHJDICLHIHKGLAIAMBFHCFAGGHAMKEBOLIAIADOGPCGGI; f5_cspm=1234; visid_incap_661002=Dw48gIojSgi5H21CbI53KJsws2IAAAAAQUIPAAAAAABGjsqvUDN7M7QSopjLR8Vr; notice_preferences=2:; notice_gdpr_prefs=0,1,2:; cmapi_cookie_privacy=permit 1,2,3; cmapi_gtm_bl=; _gcl_au=1.1.748165685.1655910675; __pdst=64037d8893ab477f9343f126addc74ea; marketLanguage=/BR/pt_BR; _fbp=fb.1.1655911044412.708475162; _pin_unauth=dWlkPVpEYzFaV1F3TW1VdE9ESmpNaTAwWVRVeUxUaGpaVFV0TlRVMFkyWTFZakEzTXpFMw; nlbi_661002=sgQRFEO7DHknKw3GjFnb+QAAAADUZeap1rBM2qrAj9TGQRwc; notice_behavior=implied,eu; _gid=GA1.2.1485132611.1656533631; incap_ses_9219_661002=pLtvO1yruRQvBwVHHHjwf3NCvWIAAAAAFsRHmT/PE5SbG0IknpHtnw==; incap_ses_1471_661002=jjr9Lrb8uzzUh3iw8wpqFEaMvWIAAAAAVxGMLl4jVN5q77i/AtqKqA==; incap_ses_989_661002=IIxuGq/CsADEEqsw/6K5DX+QvWIAAAAAxGn2XB6dtw9uH2jiB/E35Q==; reese84=3:9yg6Fo+1czbbSUVWNwSgUA==:t/OGEL0uBFKbRCRdD/wMMA1oQMliWaorZKkKg0Yzy9jhONB8haIAvBoOgjZwy4EcLm8JQ4cYmVsEgfbGSfaxBlIBfWV6e71CtC2IVw/FFzXyBL9z5xInnhZFLQGyQiw844UIvpr2mREagZWhVlY9hHQn19rfo+/fbMaoGqSXpUwnRYdHtnLjf0XR/dJcUqX1PdT4Q6ZbYkGfCYmaw/Ru//i9nJ9mJbjqQDaFaQ3HSYG6hFk4seo1S5WW3kWVP2Srpl7C+Op0MWFDz6sSER/COrm/7mUq9sKFqiRbYj41aIrQiJER0HjzTe8KHZbZmQsj/+tJDN2g8ttf1zDUQMqFyHZnxjiWZKZb+PYTumDCx7bQbJVF8bv3rdZbdwPJGDZoh6HU+tbkoHb5Uf7GJZKY+t+chiiuMdwokZNGGB18Lniq0Q5w0l9TAHPKjbq/agsY:bV2pd0vklAVSZsdzsxj6Wf9Rncc3rMwUiDbPG8JHmso=; fs_uid=#98984#5675743859576832:4557450220802048/1687446675; JSESSIONID=934E55EB5CAA1B10EF38660D81C5A59C.or-prd0-hyb-app4; JSESSIONID-B2BACC=934E55EB5CAA1B10EF38660D81C5A59C.or-prd0-hyb-app4; djaimses.c5e8=*; SameSite=None; _gat_UA-28403841-1=1; _gat_UA-28403841-10=1; nlbi_661002_2147483392=RtHDZhdU80/EsW2pjFnb+QAAAACI9d8CjauPA6eKef9ozIYV; ADRUM_BTa=\"R: 0 | g:8f6b54dd - e774 - 4fb3 - 954a - d7c78383a48e | n:doterra_8b838ba6 - b395 - 4869 - 8e1b - a5c8e407c69b\"; _ga_XW71K6YFHT=GS1.1.1656590806.10.1.1656591122.0; _ga=GA1.2.2113558045.1655910676; djaimid.c5e8=efe70f67-3889-4629-b0e8-8f62e42e5e01.1655910676.8.1656591122.1656552419.71ce324b-82cf-4070-b1c0-50c8a83ff15f");

            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                html = streamReader.ReadToEnd();
            }
            string corteIni = "<p itemprop=\"description\"><div>COD";
            string corteFini = "</div>";
            string temp = html.Substring(html.IndexOf(corteIni) + corteIni.Length).Replace(".", string.Empty).Replace(",", string.Empty).Replace(":", string.Empty).Replace(";", string.Empty);
            temp = temp.Substring(0, temp.IndexOf(corteFini)); 
            
            if(temp.Count() > 10) 
                temp = temp.Substring(0, temp.IndexOf("<br />"));


            json += "{\"CodigoProduto\":\"" + TrataCampoJson(temp) + "\",";

            corteIni = "<title>";
            corteFini = "| doTERRA Óleos Essenciais</title>";
            temp = html.Substring(html.IndexOf(corteIni) + corteIni.Length);
            temp = temp.Substring(0, temp.IndexOf(corteFini));

            json += "\"Nome\":\"" + TrataCampoJson(temp) + "\",";

            if (html.Contains("Tamanho"))
            {
                corteIni = "<div>Tamanho: ";
                corteFini = "</div>";
                temp = html.Substring(html.IndexOf(corteIni) + corteIni.Length);
                temp = temp.Substring(0, temp.IndexOf(corteFini));

                if (temp.Count() > 50)
                {
                    corteIni = "Tamanho: ";
                    corteFini = "<br />";
                    temp = html.Substring(html.IndexOf(corteIni) + corteIni.Length);
                    temp = temp.Substring(0, temp.IndexOf(corteFini));
                }
                if (temp.Count() > 10)
                {
                }
                json += "\"Tamanho\":\"" + TrataCampoJson(temp) + "\",";
            }

            if (html.Contains("Regular"))
            {
                corteIni = "<div>Regular: R$ ";
                corteFini = "</div>";
                temp = html.Substring(html.IndexOf(corteIni) + corteIni.Length);
                temp = temp.Substring(0, temp.IndexOf(corteFini));

                if(temp.Count() > 50)
                {
                    corteIni = "Regular: R$ ";
                    corteFini = "Membros";
                    temp = html.Substring(html.IndexOf(corteIni) + corteIni.Length);
                    temp = temp.Substring(0, temp.IndexOf(corteFini));
                }

                json += "\"PrecoRegular\":\"" + TrataCampoJson(temp) + "\",";
            }

            corteIni = "<div>Membros:";
            corteFini = "</div>";
            temp = html.Substring(html.IndexOf(corteIni) + corteIni.Length);
            temp = temp.Substring(0, temp.IndexOf(corteFini));

            if(temp.Count() > 100)
            {
                corteIni = "Membros:";
                temp = html.Substring(html.IndexOf(corteIni) + corteIni.Length);
                if(temp.Contains("<br />"))
                    corteFini = "<br />";
                else
                    corteFini = "</div>";
                temp = temp.Substring(0, temp.IndexOf(corteFini));
            }
            if (temp.Count() > 100)
            { 
            }

            json += "\"PrecoMembros\":\"" + TrataCampoJson(temp) + "\",";

            corteIni = "<div>PV: ";
            corteFini = "</div>";
            temp = html.Substring(html.IndexOf(corteIni) + corteIni.Length);
            temp = temp.Substring(0, temp.IndexOf(corteFini));

            if(temp.Count() > 100)
            {
                corteIni = "PV: ";
                corteFini = "</div>";
                temp = html.Substring(html.IndexOf(corteIni) + corteIni.Length);
                temp = temp.Substring(0, temp.IndexOf(corteFini));
            }

            json += "\"Pv\":\"" + TrataCampoJson(temp) + "\",";

            corteIni = "Modo de Usar";
            corteFini = "Precau&ccedil;&otilde;es";
            temp = html.Substring(html.IndexOf(corteIni) + corteIni.Length);
            temp = temp.Substring(0, temp.IndexOf(corteFini));
            if (temp.Count() > 300)
            {
                corteIni = "Modo de usar";
                corteFini = "Precau&ccedil;&otilde;es";
                temp = html.Substring(html.IndexOf(corteIni) + corteIni.Length);
                temp = temp.Substring(0, temp.IndexOf(corteFini));
            }
            if (temp.Count() > 300)
            {
                corteIni = "Modo De usar";
                corteFini = "Precau&ccedil;&otilde;es";
                temp = html.Substring(html.IndexOf(corteIni) + corteIni.Length);
                temp = temp.Substring(0, temp.IndexOf(corteFini));
            }
            if (temp.Count() > 300)
            {
                corteIni = "Modo De Usar";
                corteFini = "Precau&ccedil;&otilde;es";
                temp = html.Substring(html.IndexOf(corteIni) + corteIni.Length);
                temp = temp.Substring(0, temp.IndexOf(corteFini));
            }
            if (temp.Count() > 300)
            {
                corteIni = "Modo de Usar&nbsp;";
                corteFini = "Precau&ccedil;&otilde;es";
                temp = html.Substring(html.IndexOf(corteIni) + corteIni.Length);
                temp = temp.Substring(0, temp.IndexOf(corteFini));
            }

            json += "\"ModosDeUsar\":\"" + TrataCampoJson(temp) + "\",";

            corteIni = "<h2>Descrição do Produto</h2>";
            corteFini = "</p>";
            temp = html.Substring(html.IndexOf(corteIni) + corteIni.Length);
            temp = temp.Substring(0, temp.IndexOf(corteFini));

            json += "\"Descricao\":\"" + TrataCampoJson(temp) + "\",";

            if(html.Contains("Benefícios Primários"))
            {
                corteIni = "Benefícios Primários";
                corteFini = "</div>";
                temp = html.Substring(html.IndexOf(corteIni) + corteIni.Length);
                temp = temp.Substring(0, temp.IndexOf(corteFini));

                if (temp.Count() > 500)
                {
                    corteIni = "Benefícios Primários";
                    corteFini = "</div>";
                    temp = html.Substring(html.IndexOf(corteIni) + corteIni.Length);
                    temp = temp.Substring(0, temp.IndexOf(corteFini));
                }
            
                json += "\"Beneficios\":\"" + TrataCampoJson(temp) + "\",";
            }

            if (html.Contains("Descrição Aromática"))
            {
                corteIni = "<h2>Descrição Aromática</h2>";
                corteFini = "<h2>";
                temp = html.Substring(html.IndexOf(corteIni) + corteIni.Length);
                temp = temp.Substring(0, temp.IndexOf(corteFini));

                if (temp.Count() > 100)
                {
                    corteIni = "<h2>Descrição Aromática</h2>";
                    corteFini = "</div>";
                    temp = html.Substring(html.IndexOf(corteIni) + corteIni.Length);
                    temp = temp.Substring(0, temp.IndexOf(corteFini));
                }
                if (temp.Count() > 100)
                {

                }
                json += "\"DescricaoAromatica\":\"" + TrataCampoJson(temp) + "\",";
            }

            if(html.Contains("Método de Extração"))
            {
                corteIni = "<h2>Método de Extração</h2>";
                corteFini = "<h2>";
                temp = html.Substring(html.IndexOf(corteIni) + corteIni.Length);
                temp = temp.Substring(0, temp.IndexOf(corteFini));

                if (temp.Count() > 100)
                {
                    corteIni = "<h2>Método de Extração</h2>";
                    corteFini = "</div>";
                    temp = html.Substring(html.IndexOf(corteIni) + corteIni.Length);
                    temp = temp.Substring(0, temp.IndexOf(corteFini));
                }

                json += "\"MetodoExtracao\":\"" + TrataCampoJson(temp) + "\",";
            }
            
            if(html.Contains("Parte da Planta"))
            {
                corteIni = "<h2>Parte da Planta</h2>";
                corteFini = "<h2>";
                temp = html.Substring(html.IndexOf(corteIni) + corteIni.Length);
                temp = temp.Substring(0, temp.IndexOf(corteFini));

                if (temp.Count() > 100)
                {
                    corteIni = "Parte da Planta";
                    corteFini = "</div>";
                    temp = html.Substring(html.IndexOf(corteIni) + corteIni.Length);
                    temp = temp.Substring(0, temp.IndexOf(corteFini));
                }

                json += "\"ParteDaPlanta\":\"" + TrataCampoJson(temp) + "\",";
            }
            
            if(html.Contains("Principais Componentes Químicos"))
            {
                corteIni = "Principais Componentes Químicos";
                corteFini = "</div>";
                temp = html.Substring(html.IndexOf(corteIni) + corteIni.Length);
                temp = temp.Substring(0, temp.IndexOf(corteFini));

                json += "\"PrincipaisComponentesQuimicos\":\"" + TrataCampoJson(temp) + "\",";

                
            }

            if (html.Contains("<h2>Usos</h2>"))
            {
                corteIni = "<h2>Usos</h2>";
                corteFini = "</div>";
                temp = html.Substring(html.IndexOf(corteIni) + corteIni.Length);
                temp = temp.Substring(0, temp.IndexOf(corteFini));

                if(temp.Count() > 2000)
                {
                    corteIni = "Usos";
                    corteFini = "</div>";
                    temp = html.Substring(html.IndexOf(corteIni) + corteIni.Length);
                    temp = temp.Substring(0, temp.IndexOf(corteFini));
                }

                json += "\"Usos\":\"" + TrataCampoJson(temp) + "\",";
            }

            if (html.Contains("Precau&ccedil;&otilde;es"))
            {
                corteIni = "<h2>Precau&ccedil;&otilde;es</h2>";
                corteFini = "</div>";
                temp = html.Substring(html.IndexOf(corteIni) + corteIni.Length);
                temp = temp.Substring(0, temp.IndexOf(corteFini));

                if(temp.Count() > 2000)
                {
                    corteIni = "<h2>Precau&ccedil;&otilde;es&nbsp;</h2>";
                    corteFini = "</div>";
                    temp = html.Substring(html.IndexOf(corteIni) + corteIni.Length);
                    temp = temp.Substring(0, temp.IndexOf(corteFini));
                }
                if (temp.Count() > 2000)
                {
                    corteIni = "<div>Precau&ccedil;&otilde;es</div>";
                    corteFini = "</div>";
                    temp = html.Substring(html.IndexOf(corteIni) + corteIni.Length);
                    temp = temp.Substring(0, temp.IndexOf(corteFini));
                }

                json += "\"Precaucoes\":\"" + TrataCampoJson(temp) + "\"}";
            }

            return json;
        }

        private string TrataCampoJson(string temp)
        {
            return temp.Replace("<p>", "").Replace("</p>", Environment.NewLine).Replace("<div>", "").Replace("</div>", Environment.NewLine).Replace("<ul>", "").Replace("</ul>", "").Replace("<li>", "").Replace("</li>", Environment.NewLine).Replace("<h2>", "").Replace("</h2>", Environment.NewLine).Replace("</em>", Environment.NewLine).Replace("<em>", Environment.NewLine).Replace("&oacute;", "ó").Replace("&aacute;", "á").Replace("&atilde;", "ã").Replace("&otilde;", "õ").Replace("&ccedil;", "ç").Replace("&iacute;", "í").Replace("&eacute;", "é").Replace("&oacute;", "ó").Replace("&uacute;", "ú").Replace("&rdquo;", "'").Replace("&ldquo;", "'").Replace("<sup>&reg;</sup>", "").Replace("&acirc;", "â").Replace("&ocirc;", "ô").Replace("\"", "").Replace("&nbsp;", "").Replace("&ecirc;", "ê").Replace("R$", string.Empty).Replace("'", string.Empty).Replace(Environment.NewLine, string.Empty).Replace("<br />", string.Empty).Trim();
        }

        #endregion Métodos
    }
}
