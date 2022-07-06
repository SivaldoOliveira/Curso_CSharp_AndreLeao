using System;
using System.Collections.Generic;
using System.Text;
using TrabalhandoComNamespaces.Entidades;
using TrabalhandoComNamespaces.Repositorios;

namespace TrabalhandoComNamespaces.Servicos
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

    public void Remover(int id)
        {
            _contatoRepository.Remover(id);
        }

        public List<Contato>Listar()
        {
            return _contatoRepository.Listar();
        }
    }
}
