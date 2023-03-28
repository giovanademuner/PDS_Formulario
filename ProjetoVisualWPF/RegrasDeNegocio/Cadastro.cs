using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVisualWPF.RegrasDeNegocio
{
    internal class Cadastro
    {
        public string id {  get; set; }

        public string nome { get; set; }

        public string email { get; set; }

        public string telefone { get; set; }
        public string sexo { get; set; }

        public  DateTime DataDeNascimento { get; set; }
    }
}
