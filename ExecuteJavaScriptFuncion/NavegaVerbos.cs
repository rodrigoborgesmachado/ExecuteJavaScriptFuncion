using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mshtml;
using ExecuteJavaScriptFuncion.Util;
using System.Threading;

namespace ExecuteJavaScriptFuncion
{
    public partial class NavegaVerbos : Form
    {
        ListaVerbosConjugar lista = new ListaVerbosConjugar();

        public NavegaVerbos()
        {
            InitializeComponent();

            this.webPrincipal.Visible = false;
            
        }

        private void NavegaPagina(int numPag)
        {
            this.webPrincipal = new WebBrowser();
            this.webPrincipal.Navigate($"https://www.conjugacao.com.br/verbos-populares/{numPag}/");

            this.webPrincipal.DocumentCompleted += delegate
            {
                ChangeEnableButtons(true);
                InserePalavras();

                if (numPag < 50) 
                    NavegaPagina(numPag + 1);
            };
        }

        private void NavegaVerbosConjugacao(List<string> verbos, int index)
        {
            this.webPrincipal = new WebBrowser();
            this.webPrincipal.ScriptErrorsSuppressed = true;
            string url = $"https://www.conjugacao.com.br/verbo-{verbos[index]}/";
            this.webPrincipal.Navigate(url);

            this.webPrincipal.DocumentCompleted += delegate
            {
                ChangeEnableButtons(true);
                InsereConjugacao(verbos[index]);

                if(index + 1 != verbos.Count)
                    NavegaVerbosConjugacao(verbos, index + 1);
            };
        }

        private void NavegaTraducaoPalavra(int index)
        {
            this.webPrincipal = new WebBrowser();
            this.webPrincipal.ScriptErrorsSuppressed = true;
            string url = $"https://translate.google.com/?sl=auto&tl=en&text={this.lista.lista[index]}&op=translate";
            this.webPrincipal.Navigate(url);

            this.webPrincipal.DocumentCompleted += delegate
            {
                ChangeEnableButtons(true);
                InsereTraducao(this.lista.lista[index]);

                if (index + 1 != this.lista.lista.Count)
                    NavegaTraducaoPalavra(index + 1);
            };
        }

        private void ChangeEnableButtons(bool enable)
        {
            this.gerarPessoa.Enabled = enable;
        }

        private string GeraPalavras()
        {
            try
            {
                //return webPrincipal.Document.Body.OuterHtml;

                HtmlElement head = webPrincipal.Document.GetElementsByTagName("HEAD")[0];
                HtmlElement scriptEl = webPrincipal.Document.CreateElement("script");
                IHTMLScriptElement element = (IHTMLScriptElement)scriptEl.DomElement;


                element.text = @"
            function capturarPalavras()
            {
	        	var div = document.getElementsByClassName('wrapper');

                return div[0].innerHTML;
            }";

                head.AppendChild(scriptEl);
                var teste = webPrincipal.Document.InvokeScript("capturarPalavras");

                return Funcoes.TrataVerbos(teste?.ToString());
            }
            catch
            {
                return string.Empty;
            }
        }
        
        private string GeraConjugacao(string verboAnalisado)
        {
            try
            {
                //return webPrincipal.Document.Body.OuterHtml;

                HtmlElement head = webPrincipal.Document.GetElementsByTagName("HEAD")[0];
                HtmlElement scriptEl = webPrincipal.Document.CreateElement("script");
                IHTMLScriptElement element = (IHTMLScriptElement)scriptEl.DomElement;


                element.text = @"
            function capturarConjugacoes()
            {
	        	var div = document.getElementsByClassName('tempos')[0];

                return div.innerHTML;
            }";

                head.AppendChild(scriptEl);
                var teste = webPrincipal.Document.InvokeScript("capturarConjugacoes");

                return Funcoes.TrataConjugacao(verboAnalisado, teste?.ToString());
            }
            catch
            {
                return string.Empty;
            }
        }

        private string GeraTraducao(string palavraPortugues)
        {
            try
            {
                //return webPrincipal.Document.Body.OuterHtml;
                /*
                string inner = webPrincipal.Document.Body.InnerHtml;
                inner = inner.Substring(inner.IndexOf("/english-portuguese/translation/") + "/english-portuguese/translation/".Length);
                inner = inner.Substring(0, inner.IndexOf(".html"));
                */
                string inner = webPrincipal.Document.Body.InnerHtml;
                inner = inner.Substring(inner.IndexOf("<INPUT disabled type=hidden value=\"") + "<INPUT disabled type=hidden value=\"".Length);
                inner = inner.Substring(0, inner.IndexOf("\" name=tlitett>"));

                return Funcoes.TrataTraducao(palavraPortugues, "VERBO", inner.ToString());
            }
            catch
            {
                return string.Empty;
            }
        }

        private void InserePalavras()
        {
            string verbos = GeraPalavras();

            foreach(string verbo in verbos.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
            {
                WebTest.EnviaVerboInserir(verbo);
            }
        }

        private void InsereConjugacao(string verboAnalisado)
        {
            string verbos = GeraConjugacao(verboAnalisado);

            foreach (string verbo in verbos.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
            {
                WebTest.EnviaVerboConjugadoInserir(verbo);
            }
        }

        private void InsereTraducao(string palavraPortugues)
        {
            string json = GeraTraducao(palavraPortugues);

            if(!string.IsNullOrEmpty(json))
                WebTest.EnviaTraducaoInserir(json);
        }

        private void buttonGerarPessoa_Click(object sender, EventArgs e)
        {
            ChangeEnableButtons(false);
            this.NavegaPagina(1);
            ChangeEnableButtons(true);
        }

        private void btn_capturarConjugacao_Click(object sender, EventArgs e)
        {
            ChangeEnableButtons(false);
            this.NavegaVerbosConjugacao(new ListaVerbosConjugar().lista, 0);
            ChangeEnableButtons(true);
        }

        private void btn_traducao_Click(object sender, EventArgs e)
        {
            ChangeEnableButtons(false);
            this.NavegaTraducaoPalavra(0);
            ChangeEnableButtons(true);
        }
    }
}
