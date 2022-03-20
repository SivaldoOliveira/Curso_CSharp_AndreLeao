using System;

namespace TrabalhandoComInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            TesteInterfaces();
        }
        static void TesteInterfaces()
            {
            var cadastroCliente = new CadastroCliente();
            
            var cliente = new Cliente() 
            { Codigo = 14, 
                Nome = "Siva",
                Email = "siva@siva" 
            };

            var cliente2 = new Cliente()
            {
                Codigo = 10,
                Nome = "Joao",
                Email = "Joao@siva"
            };

            var cliente3 = new Cliente()
            {
                Codigo = 16,
                Nome = "Riu",
                Email = "riu@siva"
            };

            cadastroCliente.Adicionar(cliente);
            cadastroCliente.Adicionar(cliente2);
            cadastroCliente.Adicionar(cliente3);

            var pesquisa = cadastroCliente.Pesquisar("Riu");

            cadastroCliente.Excluir(10);

            var lista = cadastroCliente.Listar();

        }
    }
}
