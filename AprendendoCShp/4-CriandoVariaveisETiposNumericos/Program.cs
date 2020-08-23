using System;

namespace _4_CriandoVariaveisETiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4- Tipo e outras variávies!");

            int valUm = 5;
            int valDois = 2;
            double valDouble = 2.5;
            double result = (double)valUm / valDois;  //casting, convertendo o valor
            int valInteiro = (int)valDouble;

            //int idadeTerra = 1300000000000; //numeros int até 32 bits 
            long idade = 1300000000000; //numeros long de 33 até 64 bits em long
            short valorUnico = 15000; //numeros short 16 bits

            float altura = 1.8f;

            Console.WriteLine("Resultado cast: " + result);
            Console.WriteLine("Resultado cast: " + valInteiro);
            Console.WriteLine("Resultado cast: " + idade);



            Console.ReadKey(); 


        }
    }
}
