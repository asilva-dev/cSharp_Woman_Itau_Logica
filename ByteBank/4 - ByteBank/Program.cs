using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaBruna = new ContaCorrente();
            contaBruna.titular = "Bruna";
            Console.WriteLine("Saldo inicial: " + contaBruna.saldo);
            Console.WriteLine("\n");

            bool resultadoSaque = contaBruna.Sacar(500);
            //Falso porque não tem como sacar 500 de 100
            Console.WriteLine("Resposta metodo sacar: " + resultadoSaque);
            Console.WriteLine("Saldo após saque: " + contaBruna.saldo);
            Console.WriteLine("\n");

            contaBruna.Depositar(500);
            Console.WriteLine("Saldo após deposito: " + contaBruna.saldo);
            Console.WriteLine("\n");

            ContaCorrente contaGabi = new ContaCorrente();
            contaGabi.titular = "Gabriela";
            Console.WriteLine("Saldo Bruna: " + contaBruna.saldo);
            Console.WriteLine("Saldo Gabi: " + contaGabi.saldo);
            Console.WriteLine("\n");

            bool resultadoTransferencia = contaBruna.Transferir(250, contaGabi);
            Console.WriteLine("Saldo Bruna após transferencia: " + contaBruna.saldo);
            Console.WriteLine("Saldo Gabi após transferencia: " + contaGabi.saldo);
            Console.WriteLine("Resultado da transferencia: " + resultadoTransferencia);
            Console.WriteLine("\n");
            
            contaGabi.Transferir(100, contaBruna);
            Console.WriteLine("Saldo da Bruna: " + contaBruna.saldo);
            Console.WriteLine("Saldo do Gabriela: " + contaGabi.saldo);

            Console.ReadKey();
        }
    }
}
