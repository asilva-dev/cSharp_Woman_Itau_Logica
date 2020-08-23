using System;

namespace _10_LacoRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10 - Laço e repeticao While");

            int contador = 1;
            int total = 0;

            while (contador <= 10) //condicao enquando for verdadeira
            {
                total = contador;
                Console.WriteLine(total);
                contador++;
            }

            Console.WriteLine(contador);

            Console.ReadKey();
        }
    }
}
