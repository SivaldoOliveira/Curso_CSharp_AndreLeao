using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComObjetos
{
    internal class Carro
    {
        public string Modelo { get; set; }
        public string Cor{ get; set; }
        public int  Ano { get; set; }
        public int Velocidade { get; set; }  
        

        public void Acelerar(int velocidade)
        {
            Velocidade += velocidade;
        }

        public void Diminuir(int velocidade)
        {
            Velocidade -= velocidade;
        }

        public int ExibirVelocidadeAtual()
        {
            return Velocidade;
        }

    }
}
