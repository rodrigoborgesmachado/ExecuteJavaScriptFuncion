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
    public partial class Prin : Form
    {
        public Prin()
        {
            InitializeComponent();

            ChangeEnableButtons(false);
            this.webPrincipal.Visible = false;
            this.webPrincipal.Navigate("https://www.4devs.com.br/");

            this.webPrincipal.Navigated += delegate
            {
                ChangeEnableButtons(true);
                InsereGenerico();
            };
        }

        private void ChangeEnableButtons(bool enable)
        {
            this.btnGerarEmpresa.Enabled = this.btn_gerarVeiculo.Enabled = this.gerarPessoa.Enabled = enable;
        }

        private string GeraPessoa()
        {
            try
            {
                HtmlElement head = webPrincipal.Document.GetElementsByTagName("head")[0];
                HtmlElement scriptEl = webPrincipal.Document.CreateElement("script");
                IHTMLScriptElement element = (IHTMLScriptElement)scriptEl.DomElement;


                element.text = @"
            function gerar_pessoaJson(){
            	var d=new XMLHttpRequest;
            	d.open('POST','ferramentas_online.php', false);
            	d.setRequestHeader('Content-Type','application/x-www-form-urlencoded');
            		
            	d.send('acao=gerar_pessoa&sexo=1&pontuacao=&idade=0&cep_estado=0&txt_qtde=1&cep_cidade=0');
            	return d.responseText;
            }";

                head.AppendChild(scriptEl);
                var teste = webPrincipal.Document.InvokeScript("gerar_pessoaJson");

                return teste?.ToString();
            }
            catch
            {
                return string.Empty;
            }
        }

        private string GerarVeiculo()
        {
            try
            {
                HtmlElement head = webPrincipal.Document.GetElementsByTagName("head")[0];
                HtmlElement scriptEl = webPrincipal.Document.CreateElement("script");
                IHTMLScriptElement element = (IHTMLScriptElement)scriptEl.DomElement;


                element.text = @"
            function gerar_CarroJson(){
            	var d=new XMLHttpRequest;
            	d.open('POST','ferramentas_online.php', false);
            	d.setRequestHeader('Content-Type','application/x-www-form-urlencoded');
            		
            	d.send('acao=gerar_veiculo&pontuacao=S&estado=&fipe_codigo_marca=');
            	return d.responseText;
            }";

                head.AppendChild(scriptEl);
                var teste = webPrincipal.Document.InvokeScript("gerar_CarroJson");

                return Funcoes.TrataRetornoJsonVeiculo(teste?.ToString());
            }
            catch
            {
                return string.Empty;
            }
        }

        private string GeraEmpresa()
        {
            try
            {
                HtmlElement head = webPrincipal.Document.GetElementsByTagName("head")[0];
                HtmlElement scriptEl = webPrincipal.Document.CreateElement("script");
                IHTMLScriptElement element = (IHTMLScriptElement)scriptEl.DomElement;


                element.text = @"
            function gerar_empresaJson()
            {
	        	var d=new XMLHttpRequest;
	        	d.open('POST','ferramentas_online.php', false);
	        	d.setRequestHeader('Content-Type','application/x-www-form-urlencoded');
	        		
	        	d.send('acao=gerar_empresa&pontuacao=&estado=SP&idade=5');
	        	return d.responseText;
            }";

                head.AppendChild(scriptEl);
                var teste = webPrincipal.Document.InvokeScript("gerar_empresaJson");

                return Funcoes.TrataRetornoJsonEmpresa(teste?.ToString());
            }
            catch
            {
                return string.Empty;
            }
        }

        private void InsereGenerico()
        {
            int limite = 10000;
            while (limite-- > 0)
            {
                //InserePessoaAPI();
                InsereEmpresaAPI();
                InsereVeiculoAPI();
                Thread.Sleep(2000);
            }
        }

        private void InserePessoaAPI()
        {
            string json = GeraPessoa();
            WebTest.EnviaPessoaInserir(json);
        }

        private void InsereEmpresaAPI()
        {
            string json = GeraEmpresa();
            WebTest.EnviaEmpresaInserir(json);
        }

        private void InsereVeiculoAPI()
        {
            string json = GerarVeiculo();
            WebTest.EnviaVeiculoInserir(json);
        }

        private void buttonGerarPessoa_Click(object sender, EventArgs e)
        {
            string texto = GeraPessoa();
            Clipboard.SetText(texto);
            MessageBox.Show("Copiado para área de transferência", "Sucesso");
        }

        private void btnGerarEmpresa_Click(object sender, EventArgs e)
        {
            string texto = GeraEmpresa();
            Clipboard.SetText(texto);
            MessageBox.Show("Copiado para área de transferência", "Sucesso");
        }

        private void btn_gerarVeiculo_Click(object sender, EventArgs e)
        {
            string texto = GerarVeiculo();
            Clipboard.SetText(texto);
            MessageBox.Show("Copiado para área de transferência", "Sucesso");
        }
    }
}
