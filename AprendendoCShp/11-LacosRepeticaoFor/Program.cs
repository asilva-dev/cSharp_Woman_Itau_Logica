using System;

namespace _11_LacosRepeticaoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("11- For!");

            int total = 0;

            for(int contador = 0; contador <= 10; contador++)
            {
                total = contador;
                Console.WriteLine(contador);              
            }

            Console.WriteLine("Total: " + total);

            Console.ReadKey();
        }
    }
}
