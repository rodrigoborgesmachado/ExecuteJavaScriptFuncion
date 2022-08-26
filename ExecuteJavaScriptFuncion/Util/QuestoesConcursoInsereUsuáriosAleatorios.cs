using ExecuteJavaScriptFuncion.Model.ForDev;
using ExecuteJavaScriptFuncion.Model.QuestaoConcursando;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecuteJavaScriptFuncion.Util
{
    public class QuestoesConcursoInsereUsuáriosAleatorios
    {
        List<Usuario> usuarios = new List<Usuario>();

        /// <summary>
        /// Método que cria as respostas para usuários
        /// </summary>
        /// <param name="quantidadeUsuarios"></param>
        /// <param name="quantidadeRespostas"></param>
        /// <returns></returns>
        public bool CriaRespostasParaUsuarios(int quantidadeUsuarios, int quantidadeRespostas)
        {
            bool result = true;

            try
            {
                CreateUsers(quantidadeUsuarios);
                int qtRespostaPorUsuario = quantidadeRespostas / quantidadeUsuarios;

                usuarios.ForEach(usuario =>
                {
                    for(int i = 0; i< qtRespostaPorUsuario; i++)
                    {
                        RespondeQuestao(usuario);
                    }
                });
            }
            catch
            {
                result = false;
            }

            return result;
        }

        /// <summary>
        /// Método que cria os usuários
        /// </summary>
        /// <param name="quantidade"></param>
        private void CreateUsers(int quantidade)
        {
            var client = new RestClient("http://fordevs.sunsalesystem.com.br/PHP/BuscaPessoasAleatorias.php?quantidade=" + quantidade);
            var request = new RestRequest("http://fordevs.sunsalesystem.com.br/PHP/BuscaPessoasAleatorias.php?quantidade=" + quantidade, Method.Get);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);

            var pessoas = JsonConvert.DeserializeObject<ListaPessoas>(response.Content);

            pessoas.lista.ForEach(item =>
            {
                Usuario usuario = new Usuario()
                {
                    Email = item.email,
                    Nascimento = DateTime.Parse(item.data_nasc),
                    Nome = item.nome,
                    Password = "1450575459"
                };

                usuarios.Add(usuario);
            });

            usuarios.ForEach(item =>
            {
                item.Codigo = CadastrarUsuario(item);
            });
        }

        /// <summary>
        /// Método que cria o usuário na base do concursando
        /// </summary>
        /// <param name="usuario"></param>
        private int CadastrarUsuario(Usuario usuario)
        {
            var client = new RestClient("http://questoesconcurso.sunsalesystem.com.br/PHP/InsereUsuario.php");
            var request = new RestRequest("http://questoesconcurso.sunsalesystem.com.br/PHP/InsereUsuario.php", Method.Post);
            request.AddHeader("Content-Type", "application/json");

            var body = "{";
            body += $"\"Nome\":\"{usuario.Nome}\", ";
            body += $"\"Email\":\"{usuario.Email}\", ";
            body += $"\"Password\":\"{usuario.Password}\", ";
            body += $"\"Datanascimento\":\"{usuario.Nascimento.ToString("yyyy-mm-dd")}\" ";
            body += "}";
                
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);

            client = new RestClient($"http://questoesconcurso.sunsalesystem.com.br/PHP/Logar.php?login={usuario.Email}&pass={usuario.Password}");
            request = new RestRequest($"http://questoesconcurso.sunsalesystem.com.br/PHP/Logar.php?login={usuario.Email}&pass={usuario.Password}", Method.Get);
            response = client.Execute(request);
            var retornoLogin = JsonConvert.DeserializeObject<RetornoLogar>(response.Content);

            int codigo = retornoLogin.CodigoUsuario;
            return codigo;
        }

        /// <summary>
        /// Método que responde uma questão
        /// </summary>
        private void RespondeQuestao(Usuario usuario)
        {
            try
            {
                int codigoResposta = BuscarQuestao();
                InsereResposta(usuario.Codigo, codigoResposta);
            }
            catch
            {

            }
        }

        /// <summary>
        /// Método que busca a questão
        /// </summary>
        private int BuscarQuestao()
        {
            var client = new RestClient("http://questoesconcurso.sunsalesystem.com.br/PHP/BuscarQuestaoAleatoria.php");
            var request = new RestRequest("http://questoesconcurso.sunsalesystem.com.br/PHP/BuscarQuestaoAleatoria.php", Method.Get);
            request.AddHeader("Referer", "http://questoesconcurso.sunsalesystem.com.br/");
            RestResponse response = client.Execute(request);

            Console.WriteLine(response.Content);
            var questao = JsonConvert.DeserializeObject<ListaQuestoes>(response.Content);
            int random = Funcoes.NumeroAleatorio(questao.lista[0].respostas.Count - 1);

            return questao.lista[0].respostas[random].Codigo;
        }

        /// <summary>
        /// Método que insere resposta
        /// </summary>
        /// <param name="codigoUser"></param>
        /// <param name="codigoResposta"></param>
        private void InsereResposta(int codigoUser, int codigoResposta)
        {
            var client = new RestClient("http://questoesconcurso.sunsalesystem.com.br/PHP/InsereResposta.php");
            var request = new RestRequest("http://questoesconcurso.sunsalesystem.com.br/PHP/InsereResposta.php", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            var body = @"{";
            body += $"\"Codigousuario\":\"{codigoUser}\", ";
            body += $"\"Codigoresposta\":\"{codigoResposta}\"";
            body += "}";
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }
    }
}
