using System;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("01 Byte Bank!");

            //string nomeTitular = "Gabriela";
            //int numeroAgencia = 789;
            //int numero = 987600;
            //double salario = 100;

            //string nomeTitular2 = "Daniela";
            //int numeroAgencia2 = 768;
            //int numero2 = 9328;
            //double saldo2 = 199;
                       
            //criando um objeto a partir da classe - Instância
            ContaCorrente contaGabriela = new ContaCorrente();

            contaGabriela.titular = "Gabriela";
            contaGabriela.agencia = 789;
            contaGabriela.numero = 987600;
            contaGabriela.saldo = 100;

            Console.WriteLine(contaGabriela.titular);
            Console.WriteLine("\nAgência: " + contaGabriela.agencia);
            Console.WriteLine("Conta: " + contaGabriela.numero);
            Console.WriteLine("Saldo: " + contaGabriela.saldo);

            Console.ReadKey();
        }
    }
}
