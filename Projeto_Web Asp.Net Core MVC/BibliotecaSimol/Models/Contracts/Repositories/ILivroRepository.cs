﻿using BibliotecaSimol.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaSimol.Models.Contracts.Repositories
{
    public interface ILivroRepository
    {
        void Cadastrar(LivroDto livro);
        List<LivroDto> Listar();
        LivroDto PesquisarPorId(string id);

        void Atualizar(LivroDto livro);

        void Excluir (string id);
    }
}
