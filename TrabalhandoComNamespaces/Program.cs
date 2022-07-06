using System;
using TrabalhandoComNamespaces.Entidades;
using TrabalhandoComNamespaces.Servicos;

namespace TrabalhandoComNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var contatoService = new ContatoService();

            var contato = new Contato();

            contato.Id = 01;
            contato.Nome = "Sivaldo";
            contato.Email = "sival@hotmail";

        contatoService.Adicionar(contato);

            var contatos = contatoService.Listar();
        }
    }
}
