using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploComHeranca
{
    public class Funcionario : Pessoa        
    {

        public string Cargo { get; set; }
        public DateTime DataAdmissao { get; set; }
        public Funcionario(string nome, string email, string fone)
          : base(nome, email, fone)
        {

        }
    }
}
