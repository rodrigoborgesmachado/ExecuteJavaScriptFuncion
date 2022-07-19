using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecuteJavaScriptFuncion.Util
{
    public static class JavascriptFuncoes
    {
        public static string FuncaoGeraPessoa(string funcao)
        {
            return @"
            function " + funcao + @"(){
            	var d=new XMLHttpRequest;
            	d.open('POST','ferramentas_online.php', false);
            	d.setRequestHeader('Content-Type','application/x-www-form-urlencoded');
            		
            	d.send('acao=gerar_pessoa&sexo=1&pontuacao=&idade=0&cep_estado=0&txt_qtde=1&cep_cidade=0');
            	return d.responseText;
            }";
        }

        public static string FuncaoGeraVeiculo(string funcao)
        {
            return @"
            function " + funcao + @"(){
            	var d=new XMLHttpRequest;
            	d.open('POST','ferramentas_online.php', false);
            	d.setRequestHeader('Content-Type','application/x-www-form-urlencoded');
            		
            	d.send('acao=gerar_veiculo&pontuacao=S&estado=&fipe_codigo_marca=');
            	return d.responseText;
            }";
        }

        public static string FuncaoMontaContaBancaria(string funcao)
        {
            return @"
            function " + funcao + @"(){
            	var d=new XMLHttpRequest;
            	d.open('POST','ferramentas_online.php', false);
            	d.setRequestHeader('Content-Type','application/x-www-form-urlencoded');
            		
            	d.send('acao=gerar_conta_bancaria&estado=&banco=');
            	return d.responseText;
            }";
        }

        public static string FuncaoMontaCartaoCredito(string funcao)
        {
            return @"
            function " + funcao + @"(){
            	var d=new XMLHttpRequest;
            	d.open('POST','ferramentas_online.php', false);
            	d.setRequestHeader('Content-Type','application/x-www-form-urlencoded');
            		
            	d.send('acao=gerar_cc&pontuacao=S&bandeira=master');
            	return d.responseText;
            }";
        }

        public static string FuncaoMontaEmpresa(string funcao)
        {
            return @"
            function " + funcao + @"()
            {
	        	var d=new XMLHttpRequest;
	        	d.open('POST','ferramentas_online.php', false);
	        	d.setRequestHeader('Content-Type','application/x-www-form-urlencoded');
	        		
	        	d.send('acao=gerar_empresa&pontuacao=&estado=SP&idade=5');
	        	return d.responseText;
            }";
        }

        public static string FuncaoBuscarDivOleos(string funcao)
        {
            return @"
            function " + funcao + @"()
            {
	        	return document.getElementById('content_body').innerHTML;
            }";
        }
    }
}
