using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploComposicao
{
    class Cliente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public Email Email { get; set; }
        public Telefone Telefone { get; set; }
        public Endereco Endereco { get; set; }
       
    }
}
