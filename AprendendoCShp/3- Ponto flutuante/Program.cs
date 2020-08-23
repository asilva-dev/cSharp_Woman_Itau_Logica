using System;

namespace _3__Ponto_flutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-3 Criando pontos flutuantes");

            double salario = 2.9;
            Console.WriteLine(salario);

            int valorUm   = 5;
            int valorDois = 2;
            int resultado = valorUm / valorDois;
            Console.WriteLine(resultado);

            double variavelDouble = 2.0;
            double valorUmDouble = 5.0;
            double resultadoInteiro = valorUm / valorDois;
            double resultadoDouble = valorUm / variavelDouble;
            double resultadoDoubleDois = valorUmDouble / valorDois;
            

            Console.WriteLine("Resultado inteiro é: " + resultadoInteiro);
            Console.WriteLine("Resultado double é: " + resultadoDouble);
            Console.WriteLine("Resultado double dois é: " + resultadoDoubleDois);

            //variaveis int não aceitam float como atributos
            //int idade = 23.7;


            Console.ReadKey();
        }
    }
}
