using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TrabalhandoComInterfaces
{
    public class CadastroCliente : ICadastro
    {
        private static List<Cliente> clientes = null;

        public CadastroCliente()
        {
            clientes = new List<Cliente>();
        }

        public void Adicionar(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        public void Adicionar(List<Cliente> listaDeclientes)
        {
           foreach(var cliente in listaDeclientes)
            {
                clientes.Add(cliente);
            }
        }

        public void Atualizar(Cliente cliente)
        {

            var objetoAtualizacao = Pesquisar(cliente.Nome);

            clientes.Remove(objetoAtualizacao);

            objetoAtualizacao.Nome = cliente.Nome;
            objetoAtualizacao.Email = cliente.Email;

            clientes.Add(objetoAtualizacao);
        }

        public bool Excluir(int codigo)
        {

           var pesquisa = clientes.First(c => c.Codigo == codigo);
            if (pesquisa == null)
            {
                return false;
            }
            clientes.Remove(pesquisa);
            return true;
        }

        public List<Cliente> Listar()
        {
            return clientes;
        }

        public Cliente Pesquisar(string nome)
        {

       var pesquisa = clientes.First(p =>  p.Nome.ToLower().Contains(nome.ToLower()));
            return null;
        }
    }
}
