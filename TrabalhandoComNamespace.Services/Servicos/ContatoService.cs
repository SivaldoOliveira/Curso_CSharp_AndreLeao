using System;
using System.Collections.Generic;
using System.Text;
using TrabalhandoComNamespace.Repositories.Repositorios;
using TrabalhandoComNamespaces.Domain.Entidades;

namespace TrabalhandoComNamespace.Services.Servicos
{
    public class ContatoService
    {
        private readonly ContatoRepository _contatoRepository;

        public ContatoService()
        {
            _contatoRepository = new ContatoRepository();
        }
        public void Adicionar(Contato contato)
        {
            _contatoRepository.adicionar(contato);
        }

        public void Remover(string id)
        {
            _contatoRepository.Remover(id);
        }

        public List<Contato> Listar()
        {
            return _contatoRepository.Listar();
        }
    }
}
