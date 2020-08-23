using System;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("07!");
         
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            ContaCorrente conta = new ContaCorrente(867, 86712540);
            //caracteristica do objeto ou da classe? quand a caracteristica pe compartilhada por todos é da classe
            //conta.TotalDeContasCriadas ++;
            
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            ContaCorrente contaDaGabriela = new ContaCorrente(867, 86745820);
            //conta.TotalDeContasCriadas = 2;

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.ReadLine();
        }
    }
}
