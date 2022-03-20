using System;

namespace ExemploComposicao
{
    class Program
    {
        static void Main(string[] args)
        {
           TesteComposicao();
        }
        static void TesteComposicao()
        {
            var cliente = new Cliente();
            cliente.Codigo = 10;
            cliente.Nome = "Manoel";

            var email = new Email();
            email.EmailPrincipal = "maoel@gmail.com";

            var telefone = new Telefone();
            telefone.Celular =  " 11  999456-4543";

           

            var endereco = new Endereco();
            endereco.Logradouro = "Rua linda";
            endereco.Numero = "888";
            endereco.Bairro = " Vila Pindormara";
            endereco.Cidade = "Joia City";
            endereco.Estado = "São Paulo";
            endereco.CEP = "07565-545";

            cliente.Email = email;
            cliente.Endereco = endereco;
            cliente.Telefone = telefone;
        }
    }
}
