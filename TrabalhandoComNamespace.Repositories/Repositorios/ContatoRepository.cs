using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabalhandoComNamespaces.Domain.Entidades;

namespace TrabalhandoComNamespace.Repositories.Repositorios
{
    public class ContatoRepository
    {
        private List<Contato> _contatos;

        public ContatoRepository()
        {
            _contatos = new List<Contato>();
        }
        public void adicionar(Contato contato)
        {
            _contatos.Add(contato);
        }

        public void Remover(string id)
        {
            var itemParaRemover = _contatos.First(c => c.Id == id);
            if (itemParaRemover != null)
            {
                _contatos.Remove(itemParaRemover);
            }
        }

        public List<Contato> Listar()
        {
            return _contatos;
        }
    }
}
