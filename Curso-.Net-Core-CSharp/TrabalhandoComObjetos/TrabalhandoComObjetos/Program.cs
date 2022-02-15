using System;

namespace TrabalhandoComObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestandoContas();
        }

        static void TestandoContas()
        {

            try
            {
                var conta1 = new ContaBancaria("Sivaldo", "sivaldo@sivaldo", "939163368757");
                conta1.Depositar(100);
                var saldo = conta1.ExibirExtrato();



                var conta2 = new ContaBancaria("Mauriza", "maruiza@riu", "45245245245");
                conta2.Depositar(100);
                saldo = conta2.ExibirExtrato();

                conta1.Depositar(-500);

                conta1.Transferencia(conta2, 3500);

                conta1.Sacar(45500);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void TestandoCarros()
        {
            var carro1 = new Carro()
            {
                Cor = "Azul",
                Modelo = "Corsa",
                Ano = 2022
            };

            var velocidade = 0;

            carro1.Acelerar(30);
            velocidade = carro1.ExibirVelocidadeAtual();

            carro1.Acelerar(20);
            velocidade = carro1.ExibirVelocidadeAtual();

            carro1.Diminuir(15);
            velocidade = carro1.ExibirVelocidadeAtual();

            carro1.Acelerar(40);
            velocidade = carro1.ExibirVelocidadeAtual();

            carro1.Diminuir(10);
            velocidade = carro1.ExibirVelocidadeAtual();

        }
        static void ExemploClientes()
        {
            var cliente1 = new Cliente();

            cliente1.Nome = "Sivaldo";
            cliente1.Email = "sivaldo@gmail.com";
            cliente1.Fone = "11 1223-3444";
            cliente1.ExibirInformacoes();


            var cliente2 = new Cliente();

            cliente2.Nome = "Riu";
            cliente2.Email = "Riu@hotmail.co";
            cliente2.Fone = "11 96767-5943";
            cliente2.ExibirInformacoes();
        }
    }
}
