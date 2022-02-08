using System;

namespace SomaImpares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            for (int x = 1; x < 500; x++)
            {
                if (x % 2 == 1)
                {
                    total += x;
                }
            }
            Console.WriteLine(total);

            Console.ReadKey();
        }
    }
}
