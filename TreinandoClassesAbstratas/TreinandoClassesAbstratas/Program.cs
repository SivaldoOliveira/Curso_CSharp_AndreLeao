using System;

namespace TreinandoClassesAbstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            TesteContas();
        }

        static void TesteContas()
        {
            var info = "";
            var saldoTotal = 0.0;


            var conta1 = new ContaCorrente();
            conta1.Numero = 7;
            conta1.NomeCliente = "José";
            conta1.Saldo = 200;
            info = conta1.obterIformacoes();
            saldoTotal = conta1.ExibirSaldoTotal();

            var conta2 = new ContaPoupanca();
            conta2.Numero =9;
            conta2.NomeCliente = "Pedro";
            conta2.Saldo = 300;
            info = conta2.obterIformacoes();
            saldoTotal = conta2.ExibirSaldoTotal();


            var conta3 = new ContaDigital();
            conta3.Numero =10;
            conta3.NomeCliente = "Maonel";
            conta3.Saldo = 100;
            info = conta3.obterIformacoes();
            saldoTotal = conta3.ExibirSaldoTotal();
        }
    }
}
