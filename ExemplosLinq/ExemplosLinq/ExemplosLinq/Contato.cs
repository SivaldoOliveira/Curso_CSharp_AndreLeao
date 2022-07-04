using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosLinq
{
    class Contato
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public string NomeCompleto()
        {
            return Nome + " " + Sobrenome;
        }
    }
}
