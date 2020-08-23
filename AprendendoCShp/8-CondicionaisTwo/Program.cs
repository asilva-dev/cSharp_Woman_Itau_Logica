using System;

namespace _8_CondicionaisTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("8 - Condicionais Dois!");

            int idadeCarla = 16;
            int qtdPessoas = 1;
            bool acompanhada = false;

            // OU(idadeCarla >= 18 || acompanhada == true)
            if (idadeCarla >= 18 && acompanhada == true) //E
            {
                Console.WriteLine("Pode entrar!");
            }
            else
            {
                Console.WriteLine("Carla nao pode entrar!");
            }
        }
    }
}
