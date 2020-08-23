using System;

namespace _13_Lacofor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("13 Laco for");
            for(int numero = 0; numero <= 10; numero++)
            {
                Console.Write("Tabuada do " + numero + " : ");
                for( int multiplador = 0; multiplador <= 10; multiplador++)
                {
                    Console.Write(numero * multiplador);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
