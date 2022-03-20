using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhandoComInterfaces
{
    interface ICadastro
    {
        void Adicionar(Cliente  cliente);
        void Adicionar(List<Cliente> cliente);
        void Atualizar(Cliente cliente);
        bool Excluir(int codigo);
        Cliente Pesquisar(string nome);
        List<Cliente> Listar();
    }
}
