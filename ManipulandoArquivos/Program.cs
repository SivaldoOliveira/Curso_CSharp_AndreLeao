using ManipulandoArquivos.Util;
using System;

namespace ManipulandoArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            TesteLeituraDeArquivos();
        }

        static void TesteLeituraDeArquivos()
        {

            try
            {


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            var gerenciadorArquivos = new GerenciadorDeArquivos();
            var contatos = gerenciadorArquivos.ExtrairContatos();
        }
    }
}
