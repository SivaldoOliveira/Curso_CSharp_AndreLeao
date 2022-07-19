using BibliotecaSimol.Models.Contracts.Repositories;
using BibliotecaSimol.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaSimol.Models.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        public void Atualizar(LivroDto livro)
        {
            var objPesquisa = PesquisarPorId(livro.Id);
            ContextDataFake.Livros.Remove(objPesquisa);

            objPesquisa.Nome = livro.Nome;
            objPesquisa.Editora = livro.Editora;
            objPesquisa.Autor = livro.Autor;

            Cadastrar(objPesquisa);

        }

        public void Cadastrar(LivroDto livro)
        {
            ContextDataFake.Livros.Add(livro);
        }

        public void Excluir (string id)
        {
            var ObjPesquisa = PesquisarPorId(id);
            ContextDataFake.Livros.Remove(ObjPesquisa);
        }

        public List<LivroDto> Listar()
        {
            var livros = ContextDataFake.Livros;
            return livros
                .OrderBy(p => p.Nome)
                .ToList();
        }

        public LivroDto PesquisarPorId(string id)
        {
           var livro = ContextDataFake.Livros.FirstOrDefault(p => p.Id == id);

            return livro;
        }
    }


}
