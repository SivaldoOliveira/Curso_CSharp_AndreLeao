using BibliotecaSimol.Models.Contracts.Repositories;
using BibliotecaSimol.Models.Contracts.Services;
using BibliotecaSimol.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaSimol.Models.Services
{
    public class LivroService : ILivroService
    {
        private readonly ILivroRepository _livroRepository;
        public LivroService(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }
        public List<LivroDto> Listar()
        {
            try
            {
                return _livroRepository.Listar();
            }
            catch (Exception ex )
            {

                throw ex;
            }
           
        }
    }
}
