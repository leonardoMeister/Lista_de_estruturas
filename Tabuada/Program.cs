using System;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um numero: ");
            int valor = Convert.ToInt32(Console.ReadLine());
            
            for (int x =0;x <11;x++)
            {
                Console.WriteLine($"{x} x {valor} = {x*valor}");
            }

            Console.ReadKey();
        }
    }
}
