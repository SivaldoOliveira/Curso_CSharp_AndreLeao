using System;

namespace ExemploComHeranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TesteHeranca();
        }

        static void TesteHeranca()
        {

            var aluno1 = new Aluno("Sivaldo", "sivaldo@gmail.com", " 11 0102-4567");
                var info = aluno1.ExibirInformacoes();
            aluno1.Matricula = 1234;
            aluno1.DataNascimento = new DateTime(1994, 5, 17);

            var professor1 = new Professor("Jorge", "jorge@gmail.com", "11 4567-9876");
            professor1.Disciplina = "Matematica";
            info = professor1.ExibirInformacoes();

            var professor2 = new Professor("Ana", "Ana@gmail.com", "99 5433-4235");
            professor1.Disciplina = "Português";
            info = professor2.ExibirInformacoes();

            var funcionario1 = new Funcionario("Carlso", " crlso@gmail.com", "11 5242-5243");
            funcionario1.Cargo = "Analista";
            funcionario1.DataAdmissao = new DateTime(2019, 7, 5);

        }
    }
}
