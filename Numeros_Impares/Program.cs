using System;

namespace Numeros_Impares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int x =100; x <200; x++)
            {
                if(x %2 == 1)
                {
                    Console.WriteLine(x);
                }
            }
            Console.ReadKey();
        }
    }
}
