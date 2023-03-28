using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVisual1.RegrasDeNegocio
{
    internal class Cadastro
    {
        public string id { get ; set; } 
        public string name { get; set; }    
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Sexo { get; set; }

        public DateTime DataDeNascimento { get; set; }
    }
}
