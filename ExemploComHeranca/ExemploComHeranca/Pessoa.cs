using System;

namespace ExemploComHeranca
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Fone { get; set; }
        public DateTime DataNascimento{ get; set; }


        public Pessoa(string nome, string email, string fone)
       {
            Nome = nome;
            Email = email;
           Fone = fone;
        }

        public string ExibirInformacoes()
        {
            var info = $"Nome: {Nome}, Email: {Email}, Fone: {Fone}";
            return info;
        }
    }
}
