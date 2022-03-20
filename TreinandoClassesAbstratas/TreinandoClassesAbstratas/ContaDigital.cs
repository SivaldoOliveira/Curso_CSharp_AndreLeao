using System;
using System.Collections.Generic;
using System.Text;

namespace TreinandoClassesAbstratas
{
    class ContaDigital : Conta
    {
        public double Limite { get; set; }

        public ContaDigital()
        {
            Limite = 100;
        }

        public override double ExibirSaldoTotal()
        {
            return Saldo + (Limite * 0.8);
        }
    }
}
