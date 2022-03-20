using System;
using System.Collections.Generic;
using System.Text;

namespace TreinandoClassesAbstratas
{
    class ContaCorrente : Conta
    {
        public double Limite { get; set; }

        public ContaCorrente()
        {
            Limite = 200;
        }

        public override double ExibirSaldoTotal()
        {
            return Saldo + Limite;
        }
    }
}
