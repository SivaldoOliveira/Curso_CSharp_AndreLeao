using System;
using System.Collections.Generic;
using System.Linq;

namespace ExemplosLinq
{
    class Program
    {
        static List<TimeDeFutebol> listaDeTimes = new List<TimeDeFutebol>();
        static List<Esporte> listaDeEsportes = new List<Esporte>();
        static List<Jogo> listaDeJogos = new List<Jogo>();
        static List<Contato> listaDeContatos = new List<Contato>();

        static void Main(string[] args)
        {
            CadastrarDados();
            TestarLing();
        }

        private static void TestarLing()
        {
            var lsTimes = listaDeTimes
                                        .OrderBy(t => t.Nome)
                                        .ToList();

            var timesBrasileiros = listaDeTimes
                                         .Where(t => t.Nacionalidade == "Brasileiro")
                                         .ToList();

            var lsEsportes = listaDeEsportes.ToList();

            var lsJogos = listaDeJogos.ToList();

            var lsContato = listaDeContatos.ToList();
        }

        private static void CadastrarDados()
        {
            CadastrarTimesDeFutebol();
            CadastrarEsportes();
            CadastrarJogos();
            CadastrarContatos();
        }

        private static void CadastrarContatos()
        {
            var contato = new Contato { Nome = "Mauriza", Sobrenome = "Almeida" };
            listaDeContatos.Add(contato);

            contato = new Contato { Nome = "Sivaldo", Sobrenome = "Muniz" };
            listaDeContatos.Add(contato);

            contato = new Contato { Nome = "Leticia", Sobrenome = "Oliveira" };
            listaDeContatos.Add(contato);

            contato = new Contato { Nome = "Giovana", Sobrenome = "Oliveira" };
            listaDeContatos.Add(contato);

            contato = new Contato { Nome = "Maria", Sobrenome = "Russa" };
            listaDeContatos.Add(contato);

            contato = new Contato { Nome = "Jovelcino", Sobrenome = "BeiçoDeMula" };
            listaDeContatos.Add(contato);

            contato = new Contato { Nome = "Luke", Sobrenome = "Cachorro" };
            listaDeContatos.Add(contato);

            contato = new Contato { Nome = "Lucas", Sobrenome = "Egidio" };
            listaDeContatos.Add(contato);

            contato = new Contato { Nome = "Andre", Sobrenome = "Liso" };
            listaDeContatos.Add(contato);

            contato = new Contato { Nome = "Fusca", Sobrenome = "Branco" };
            listaDeContatos.Add(contato);





























        }

        private static void CadastrarJogos()
        {
            var jogo = new Jogo { Nome = "Super Mario Bros", Plataforma = "Nintendo" };
            listaDeJogos.Add(jogo);

            jogo = new Jogo { Nome = "Super Mario World", Plataforma = "Nintendo" };
            listaDeJogos.Add(jogo);

            jogo = new Jogo { Nome = "Fifa 20", Plataforma = "PS4" };
            listaDeJogos.Add(jogo);

            jogo = new Jogo { Nome = "PES 20", Plataforma = "XBOX ONE" };
            listaDeJogos.Add(jogo);

            jogo = new Jogo { Nome = "Aladdin", Plataforma = "Nintendo" };
            listaDeJogos.Add(jogo);

            jogo = new Jogo { Nome = "Street fighter", Plataforma = "PS4" };
            listaDeJogos.Add(jogo);
        }

        private static void CadastrarEsportes()
        {
            var esporte = new Esporte { Nome = "Futebol", Modalidade = "Com Bola" };
            listaDeEsportes.Add(esporte);

            esporte = new Esporte { Nome = "Volei", Modalidade = "Com Bola" };
            listaDeEsportes.Add(esporte);

            esporte = new Esporte { Nome = "Futevolei", Modalidade = "Com Bola" };
            listaDeEsportes.Add(esporte);

            esporte = new Esporte { Nome = "Basquete", Modalidade = "Com Bola" };
            listaDeEsportes.Add(esporte);

            esporte = new Esporte { Nome = "Natação", Modalidade = "Aquatico" };
            listaDeEsportes.Add(esporte);

            esporte = new Esporte { Nome = "Polo Aquatico", Modalidade = "Aquatico" };
            listaDeEsportes.Add(esporte);

            esporte = new Esporte { Nome = "Corrida", Modalidade = "Corrida" };
            listaDeEsportes.Add(esporte);
        }

        private static void CadastrarTimesDeFutebol()
        {
            var time1 = new TimeDeFutebol { Nome = "São Paulo", Nacionalidade = "Brasileira" };
            listaDeTimes.Add(time1);

            var time2 = new TimeDeFutebol { Nome = "Palmeiras", Nacionalidade = "Brasileiro" };
            listaDeTimes.Add(time2);

            var time3 = new TimeDeFutebol { Nome = "Santos", Nacionalidade = "Brasileiro" };
            listaDeTimes.Add(time3);

            var time4 = new TimeDeFutebol { Nome = "Gremio", Nacionalidade = "Brasileiro" };
            listaDeTimes.Add(time4);

            var time5 = new TimeDeFutebol { Nome = "Flamengo", Nacionalidade = "Brasileiro" };
            listaDeTimes.Add(time5);

            var time6 = new TimeDeFutebol { Nome = "São Caetano", Nacionalidade = "Brasileiro" };
            listaDeTimes.Add(time6);

            var time7 = new TimeDeFutebol { Nome = "Corinthians", Nacionalidade = "Brasileiro" };
            listaDeTimes.Add(time7);

            var time8 = new TimeDeFutebol { Nome = "Fluminense", Nacionalidade = "Brasileiro" };
            listaDeTimes.Add(time8);

            var time9 = new TimeDeFutebol { Nome = "Coritiba", Nacionalidade = "Brasileiro" };
            listaDeTimes.Add(time9);

            var time10 = new TimeDeFutebol { Nome = "Barcelona", Nacionalidade = "Espanha" };
            listaDeTimes.Add(time10);

            var time11 = new TimeDeFutebol { Nome = "Real Madrid", Nacionalidade = "Espanha" };
            listaDeTimes.Add(time11);

            var time12 = new TimeDeFutebol { Nome = "Milan", Nacionalidade = "Italia" };
            listaDeTimes.Add(time12);

            var time13 = new TimeDeFutebol { Nome = "Juventus", Nacionalidade = "Italia" };
            listaDeTimes.Add(time13);

            var time14 = new TimeDeFutebol { Nome = "PSG", Nacionalidade = "Franca" };
            listaDeTimes.Add(time14);

            var time15 = new TimeDeFutebol { Nome = "Monaco", Nacionalidade = "Franca" };
            listaDeTimes.Add(time15);

            var time16 = new TimeDeFutebol { Nome = "Bayer de Munique", Nacionalidade = "Alemanha" };
            listaDeTimes.Add(time16);


            var time17= new TimeDeFutebol { Nome = "Schalke 04", Nacionalidade = "Alemanha" };
            listaDeTimes.Add(time17);

            var time18 = new TimeDeFutebol { Nome = "Porto", Nacionalidade = "Portugal" };
            listaDeTimes.Add(time18);

            var time19 = new TimeDeFutebol { Nome = "Benfica", Nacionalidade = "Portugal" };
            listaDeTimes.Add(time19);

            var time20 = new TimeDeFutebol { Nome = "Ajax", Nacionalidade = "Holanda" };
            listaDeTimes.Add(time20);
                    }
            
      
    }
}
