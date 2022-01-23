using System;

namespace TrabalhandoComCondicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExemplosCondicionais();
        }

        static void ExemplosCondicionais()
        {
            Console.WriteLine("Exemplos utilizando condicionais");

  
        for (int n = 1; n < 10; n++)
            {
                Console.WriteLine($"tabuada do {n}\n");

                for (int i = 1; i <= 10; i++)
                {
                    var x = n * i;
                    Console.WriteLine($"{n} x {i} = {x}");
                }
                Console.WriteLine("\n");
            }

        }
    }
}
