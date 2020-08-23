using System;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("7 - Condicionais!");

            int idadeCarla = 16;
            int qtdPessoas = 2;

            bool acompanhada = true;

            //if condição ? true : false;

            string teste = acompanhada == true ? "//fazTalCoisa " : "//fazOutraCoisa";
            Console.WriteLine("If ternário " + teste);

            if(idadeCarla >= 18)
            {
                Console.WriteLine("Carla possui mais de 18 anos, pode entrar!");
            } 
            else
            {
                if(qtdPessoas >= 2)
                {
                    Console.WriteLine("Carla nao possui mais de 18 anos,mas esta acompanhada!");
                }
                else
                {
                    Console.WriteLine("Carla nao possui mais de 18 anos, pode voltar para casa!");
                }
            }
        }
    }
}
