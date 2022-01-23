using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComObjetos
{
    internal class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Fone { get; set; }

        public void ExibirInformacoes()
        {
            var resumo = $"Nome: {Nome}, Email: {Email}, Fone: { Fone}";
            Console.WriteLine(resumo);
           
        }
    }
}
