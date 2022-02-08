using System;

namespace Altura_15_pessoas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] pessoas = new int[15];

            for (int x = 14; x >= 0; x--)
            {
                Console.WriteLine("Informe a aultura: ");
                pessoas[x] = Convert.ToInt32(Console.ReadLine());
            }
            int maior = 0, menor = 9999999;
            for (int x = 14; x >= 0; x--)
            {
                if (pessoas[x] > maior) maior = pessoas[x];
                if (pessoas[x]< menor) menor = pessoas[x];
            }

            Console.WriteLine($"Maior numero:{maior}");
            Console.WriteLine($"Menor numero:{menor}");


            Console.ReadKey();
        }
    }
}
