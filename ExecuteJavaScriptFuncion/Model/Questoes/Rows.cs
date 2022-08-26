using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecuteJavaScriptFuncion.Model.Questoes
{
    public class Rows
    {
        public List<Bancas> bancas { get; set; }
        public List<int> anos { get; set; }

        public List<object> tiposProva { get; set; }

        public string enunciado_clean { get; set; }
        public List<Area> areas { get; set; }

        public int resposta { get; set; }
        public List<Resposta> itens { get; set; }
    }
}
