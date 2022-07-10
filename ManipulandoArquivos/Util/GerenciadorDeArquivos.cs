using ManipulandoArquivos.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ManipulandoArquivos.Util
{
    public class GerenciadorDeArquivos
    {
        public List<Contato> ExtrairContatos()
        {
            var contatos = new List<Contato>();

            var diretorioDoArquivo = @"c:\temp\";
            var nomeDoArquivo = "contatos.txt";
            var caminhoCompletoDoArquivo = $"{diretorioDoArquivo}{nomeDoArquivo}";

            var reader = new StreamReader(caminhoCompletoDoArquivo);
            var dados = reader.ReadToEnd();

            char caracter = '\n';
            var aux = dados.Split(caracter);

            foreach (var item in aux)
            {
                var linha = item.Replace("\r", "");
                
                if (!string.IsNullOrEmpty(linha) && !linha.Contains("codigo;"))
                {
                    caracter = ';';
                    var colunas = linha.Split(caracter);

                    var contato = new Contato
                    {
                        Codigo = Int32.Parse(colunas[0]),
                        Nome = colunas[1],
                        Email = colunas[2],
                        Fone = colunas[3]

                    };

                    contatos.Add(contato);
                }

            };

            reader.Close();

            return contatos;
        }

        public void GravarEmArquivo(List<Contato> contatos)
        {
            var diretorioDoArquivo = @"c:\temp\";
            var nomeDoArquivo = "agenda.txt";
            var caminhoCompletoDoArquivo = $"{diretorioDoArquivo}{nomeDoArquivo}";

            var arquivo = new StreamWriter(caminhoCompletoDoArquivo);

            arquivo.WriteLine("Nome; Email");

            foreach (var item in contatos)
            {
                var linha = $"{item.Nome};{item.Email}";
                arquivo.WriteLine(linha);
            }

            arquivo.Close();
        }

    }
}
