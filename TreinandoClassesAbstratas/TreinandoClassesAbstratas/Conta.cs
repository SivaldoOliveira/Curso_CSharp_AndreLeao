using System;
using System.Collections.Generic;
using System.Text;

namespace TreinandoClassesAbstratas
{
    public abstract class Conta
    {
        public int Numero { get; set; }
        public string NomeCliente { get; set; }
        public double Saldo { get; set; }

        public string obterIformacoes()
        {
            var mensagem = $"Numero: {Numero}, Nome: {NomeCliente}, Saldo:{ Saldo}";
            return mensagem;
        }
        public abstract double ExibirSaldoTotal();
        
    }
}