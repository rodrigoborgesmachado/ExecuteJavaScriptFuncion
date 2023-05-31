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
using System.Net;
using System.IO;
using RestSharp;

namespace ExecuteJavaScriptFuncion
{
    public partial class Prin : Form
    {
        #region Eventos

        /// <summary>
        /// Evento lançado no clique do botão de gerar pessoa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGerarPessoa_Click(object sender, EventArgs e)
        {
            string texto = GeraPessoa();
            Clipboard.SetText(texto);
            MessageBox.Show("Copiado para área de transferência", "Sucesso");
        }

        /// <summary>
        /// Evento lançado no clique do botão de gerar empresa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGerarEmpresa_Click(object sender, EventArgs e)
        {
            string texto = GeraEmpresa();
            Clipboard.SetText(texto);
            MessageBox.Show("Copiado para área de transferência", "Sucesso");
        }

        /// <summary>
        /// Evento lançado no clique do botão de gerar veículo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_gerarVeiculo_Click(object sender, EventArgs e)
        {
            string texto = GerarVeiculo();
            Clipboard.SetText(texto);
            MessageBox.Show("Copiado para área de transferência", "Sucesso");
        }

        /// <summary>
        /// Método que fera a conta bancária
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_gerar_conta_bancaria_Click(object sender, EventArgs e)
        {
            string texto = GerarContaBancaria();
            Clipboard.SetText(texto);
            MessageBox.Show("Copiado para área de transferência", "Sucesso");
        }

        /// <summary>
        /// Evento lançado no clique do botão da geração de cartão de crédito
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_gerarCartaoCredito_Click(object sender, EventArgs e)
        {
            string texto = GerarCartaoCredito();
            Clipboard.SetText(texto);
            MessageBox.Show("Copiado para área de transferência", "Sucesso");
        }

        #endregion Eventos

        #region Construtores

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        public Prin()
        {
            InitializeComponent();

            ChangeEnableButtons(false);
            this.webPrincipal.Visible = false;
            this.webPrincipal.Navigate("https://www.4devs.com.br/");

            this.webPrincipal.Navigated += delegate
            {
                //ChangeEnableButtons(true);
                //InsereGenerico();
            };

            //this.InsereQuestoesGenericas();
            this.InsereRespostasQuestoes();
        }

        #endregion Construtores

        #region Métodos

        /// <summary>
        /// Função que controle a opção enable dos botões da tela
        /// </summary>
        /// <param name="enable"></param>
        private void ChangeEnableButtons(bool enable)
        {
            this.btnGerarEmpresa.Enabled = this.btn_gerarVeiculo.Enabled = this.gerarPessoa.Enabled = enable;
        }

        /// <summary>
        /// Função que incsere os dados genéricos
        /// </summary>
        private void InsereGenerico()
        {
            int limite = 1000000;
            while (limite-- > 0)
            {
                InserePessoaAPI();
                InsereEmpresaAPI();
                InsereVeiculoAPI();
                InsereContaBancariaAPI();
                InsereCartaoCreditoAPI();
                Thread.Sleep(2000);
            }
        }

        /// <summary>
        /// método que controla a inserção de pessoas genéricas
        /// </summary>
        private void InserePessoaAPI()
        {
            string json = GeraPessoa();
            WebTest.EnviaPessoaInserir(json);
        }

        /// <summary>
        /// método que controla a inserção de pessoas jurídicas genéricas
        /// </summary>
        private void InsereEmpresaAPI()
        {
            string json = GeraEmpresa();
            WebTest.EnviaEmpresaInserir(json);
        }

        /// <summary>
        /// método que insere veículos aleatórios
        /// </summary>
        private void InsereVeiculoAPI()
        {
            string json = GerarVeiculo();
            WebTest.EnviaVeiculoInserir(json);
        }

        /// <summary>
        /// método que insere contas bancárias genéricas
        /// </summary>
        private void InsereContaBancariaAPI()
        {
            string json = GerarContaBancaria();
            WebTest.EnviaContaBancariaInserir(json);
        }

        /// <summary>
        /// método que insere cartão de crédito genérico
        /// </summary>
        private void InsereCartaoCreditoAPI()
        {
            string json = GerarCartaoCredito();
            WebTest.EnviaCartaoCreditoInserir(json);
        }

        /// <summary>
        /// Método que insere as questões genéricas
        /// </summary>
        private void InsereQuestoesGenericas()
        {
            List<string> listaJsons = GerarJsonsQuestoes();
            listaJsons.ForEach(json =>
            {
                WebTest.EnviaJsonQuestao(json);
            });
        }

        /// <summary>
        /// Método que insere as respostas para questões
        /// </summary>
        private void InsereRespostasQuestoes()
        {
            QuestoesConcursoInsereUsuáriosAleatorios questoes = new QuestoesConcursoInsereUsuáriosAleatorios();
            questoes.CriaRespostasParaUsuarios(100, 70000);
        }

        /// <summary>
        /// Método que faz a geração de pessoas
        /// </summary>
        /// <returns></returns>
        private string GeraPessoa()
        {
            try
            {
                HtmlElement head = webPrincipal.Document.GetElementsByTagName("head")[0];
                HtmlElement scriptEl = webPrincipal.Document.CreateElement("script");
                IHTMLScriptElement element = (IHTMLScriptElement)scriptEl.DomElement;

                string funcao = "gerar_pessoaJson";
                element.text = JavascriptFuncoes.FuncaoGeraPessoa(funcao);

                head.AppendChild(scriptEl);
                var teste = webPrincipal.Document.InvokeScript(funcao);

                return teste?.ToString();
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Método que faz a geração do veículo
        /// </summary>
        /// <returns></returns>
        private string GerarVeiculo()
        {
            try
            {
                HtmlElement head = webPrincipal.Document.GetElementsByTagName("head")[0];
                HtmlElement scriptEl = webPrincipal.Document.CreateElement("script");
                IHTMLScriptElement element = (IHTMLScriptElement)scriptEl.DomElement;

                string funcao = "gerar_CarroJson";
                element.text = JavascriptFuncoes.FuncaoGeraVeiculo(funcao);

                head.AppendChild(scriptEl);
                var teste = webPrincipal.Document.InvokeScript(funcao);

                return Funcoes.TrataRetornoJsonVeiculo(teste?.ToString());
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Método que faz a geração da conta
        /// </summary>
        /// <returns></returns>
        private string GerarContaBancaria()
        {
            try
            {
                HtmlElement head = webPrincipal.Document.GetElementsByTagName("head")[0];
                HtmlElement scriptEl = webPrincipal.Document.CreateElement("script");
                IHTMLScriptElement element = (IHTMLScriptElement)scriptEl.DomElement;

                string funcao = "gerar_ContaBancaria";
                element.text = JavascriptFuncoes.FuncaoMontaContaBancaria(funcao);

                head.AppendChild(scriptEl);
                var teste = webPrincipal.Document.InvokeScript(funcao);

                return Funcoes.TrataRetornoJsonContaBancaria(teste?.ToString());
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Método que faz a geração do cartão de crédito
        /// </summary>
        /// <returns></returns>
        private string GerarCartaoCredito()
        {
            try
            {
                HtmlElement head = webPrincipal.Document.GetElementsByTagName("head")[0];
                HtmlElement scriptEl = webPrincipal.Document.CreateElement("script");
                IHTMLScriptElement element = (IHTMLScriptElement)scriptEl.DomElement;

                string funcao = "gerar_CartaoCredito";
                element.text = JavascriptFuncoes.FuncaoMontaCartaoCredito(funcao);

                head.AppendChild(scriptEl);
                var teste = webPrincipal.Document.InvokeScript(funcao);

                return Funcoes.TrataRetornoJsonCartaoCredito(teste?.ToString());
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Método que faz a geração da empresa
        /// </summary>
        /// <returns></returns>
        private string GeraEmpresa()
        {
            try
            {
                HtmlElement head = webPrincipal.Document.GetElementsByTagName("head")[0];
                HtmlElement scriptEl = webPrincipal.Document.CreateElement("script");
                IHTMLScriptElement element = (IHTMLScriptElement)scriptEl.DomElement;

                string funcao = "gerar_empresaJson";
                element.text = JavascriptFuncoes.FuncaoMontaEmpresa(funcao);

                head.AppendChild(scriptEl);
                var teste = webPrincipal.Document.InvokeScript(funcao);

                return Funcoes.TrataRetornoJsonEmpresa(teste?.ToString());
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Método que gera os jsons das questões
        /// </summary>
        /// <returns></returns>
        private List<string> GerarJsonsQuestoes()
        {
            List<string> list = new List<string>();

            var client = new RestClient("https://rota-api.grancursosonline.com.br/open/elastic/questao?perPage=20&page=1&assunto[]=405626&resolucao=todas&anulada=0&desatualizada=0&sort=[%7B%22anos%22:%22desc%22%7D,%7B%22_score%22:%22desc%22%7D]");
            var request = new RestRequest("GET");
            request.AddHeader("Cookie", "__cf_bm=5fegtHtNvicCEUxtIK9cdiO8j8.C.Fk5WoeW36108ok-1659365769-0-Aemvo5kARJf66Fytvs3CI3mECrGS3zhU0A57jBy528BoeszOAjwQFnC0MwXqMRS26uq7iNYWqu1dH7pZDLrvIlc=; path=/; expires=Mon, 01-Aug-22 15:26:09 GMT; domain=.grancursosonline.com.br; HttpOnly; Secure; SameSite=None");
            request.AddHeader("Referer", "https://questoes.grancursosonline.com.br/");
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            list = Funcoes.TrataJsonQuestoes(constClass.param);

            return list;
        }

        #endregion Métodos

    }
}
