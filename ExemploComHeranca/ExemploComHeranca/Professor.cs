using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploComHeranca
{
    public class Professor : Pessoa
    {
        public string Disciplina { get; set; }
        public Professor(string nome, string email, string fone) 
            : base(nome, email, fone)
        {

        }
    }
}
