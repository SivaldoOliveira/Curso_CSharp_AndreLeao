using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploComHeranca
{
    internal class Aluno : Pessoa
    {
        public int Matricula { get; set; }
        public Aluno (string nome, string email, string fone)
            :base (nome, email, fone)
        {

        }
    }
}
