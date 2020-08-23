using System;

namespace _6_AtribuicoesDeVariavies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("6-Atribuindo variaveis!");

            int idade = 31;
            Console.WriteLine(idade);
            int idadeAmanda = idade;
            Console.WriteLine(idadeAmanda);

            idade = 32;

            Console.WriteLine(idade);
            Console.WriteLine(idadeAmanda);

            Console.ReadKey();
        }
    }
}
