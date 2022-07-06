using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabalhandoComNamespaces.Entidades;

namespace TrabalhandoComNamespaces.Repositorios
{
    class ContatoRepository
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

        public void Remover(int id)
        {
           var itemParaRemover =  _contatos.First(c => c.Id == id);
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
