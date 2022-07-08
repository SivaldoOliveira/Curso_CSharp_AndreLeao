using System;
using TrabalhandoComNamespace.Services.Servicos;
using TrabalhandoComNamespaces.Domain.Entidades;


namespace TrabalhandoComNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var contatoService = new ContatoService();

            var contato = new Contato();

          
            contato.Nome = "Sivaldo";
            contato.Email = "sival@hotmail";

        contatoService.Adicionar(contato);

            var contatos = contatoService.Listar();
        }
    }
}
