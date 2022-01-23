using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComObjetos
{
    internal class ContaBancaria
    {
        public static int ProximoCodigo = 1;  
        public int Codigo { get; }
        public string Nome { get; }
        private double Saldo { get; set; }
        public string Email { get;}
        public string CPF { get; }

        public ContaBancaria(string nome, string email, string cpf)
            :this( nome,cpf)
        {           
            Email = email;
            
        }
                
        public ContaBancaria( string nome, string cpf)
            :this()
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
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            Saldo -= valor;
        }

        public double ExibirExtrato()
        {
            return Saldo;
        }

    }
}
