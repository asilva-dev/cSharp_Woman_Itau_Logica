using System;

namespace _2_CriandoVariáveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2-Criando variáveis");

            //erro verde quando a variavel foi declarada mas nao usada
            int idade = 31;
            Console.WriteLine(idade);

            idade = 10;
            Console.WriteLine(idade);

            idade = 10 + 5;
            Console.WriteLine(idade);

            idade = 10 + 5 * 2;
            Console.WriteLine(idade);

            idade = (10 + 5) * 2;
            Console.WriteLine(idade);

            Console.WriteLine("Sua idade é " + idade + "!");

            idade = 10 - 7;
            Console.Write(idade); //write não pula a linha

            Console.ReadKey();
        }
    }
}
