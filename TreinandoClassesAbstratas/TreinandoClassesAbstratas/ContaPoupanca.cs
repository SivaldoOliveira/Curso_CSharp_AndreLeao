using System;
using System.Collections.Generic;
using System.Text;

namespace TreinandoClassesAbstratas
{
    class ContaPoupanca : Conta
    {
        public override double ExibirSaldoTotal()
        {
            return Saldo;
        }
    }
}
