using System;

namespace Fatorial_de_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, num, fat;
            Console.WriteLine("Informe o número");
            
            fat = num = double.Parse(Console.ReadLine());
            
            for (x = num - 1; x >= 1; x--)
            {
                Console.WriteLine($"{fat} * {x}");

                fat = fat * x;
            }
            Console.WriteLine($"\nFatorial de {num} é {fat} ");
            
            Console.ReadKey();

        }
    }
}
