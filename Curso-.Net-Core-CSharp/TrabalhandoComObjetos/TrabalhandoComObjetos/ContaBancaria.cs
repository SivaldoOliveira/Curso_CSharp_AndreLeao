using System;

namespace TrabalhandoComObjetos
{
    internal class ContaBancaria
    {
        public static int ProximoCodigo = 1;
        public int Codigo { get; }
        public string Nome { get; }
        private double Saldo { get; set; }
        public string Email { get; }
        public string CPF { get; }

        public ContaBancaria(string nome, string email, string cpf)
            : this(nome, cpf)
        {
            Email = email;

        }
        public ContaBancaria(string nome, string cpf)
            : this()
        {

            Nome = nome;
            CPF = cpf;
        }

        private ContaBancaria()
        {
            Saldo = 0.0;
            Codigo = ProximoCodigo;
            ProximoCodigoDaConta();

        }
        private void ProximoCodigoDaConta()
        {
            ProximoCodigo += 1;

        }
        public string ExibirInformacoes()
        {
            var info = $"Codigo: {Codigo}, Nome do cliente: {Nome}";
            return info;
        }
        public void Depositar(double valor)
        {
            if (valor <= 0)
            {
                throw new Exception("Depósito não foi realizado, verifique o valor para depósito.");
            }
            Saldo += valor;
        }
       
        public bool Sacar(double valor)
        {
            if (valor > Saldo)
            {
                throw new Exception("Saque não foi realizado, valor superior ao disponivel em conta.");
            }
            if (valor <= 0)
            {
                throw new Exception("Saque não foi realizado, valor deve ser maior que zero.");
            }
            
                Saldo -= valor;
                return true;
            }
       

        public void Transferencia(ContaBancaria conta, double valor)
        {
            var saqueRealizado = this.Sacar(valor);
            if (saqueRealizado)
            {
                conta.Depositar(valor);
            }
        }

        public double ExibirExtrato()
        {
            return Saldo;
        }

    }
}
