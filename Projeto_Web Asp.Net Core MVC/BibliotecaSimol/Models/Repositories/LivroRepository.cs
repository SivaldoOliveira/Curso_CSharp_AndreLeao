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
        public List<LivroDto> Listar()
        {
            var livros = ContextDataFake.Livros;
            return livros
                .OrderBy(p => p.Nome)
                .ToList();
        }
    }


}
