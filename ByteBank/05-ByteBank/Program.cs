using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5!");

            //Cliente gabriela = new Cliente();
            //gabriela.nome = "Gabriela";
            //gabriela.cpf = "355.034.798.74";

            ContaCorrente conta = new ContaCorrente();

            //conta.titular = gabriela;
            // conta.titular.cpf = "434.562.878-20";
            // conta.titular.profissao = "Desenvolvedora C#";

            conta.saldo = 500;
            conta.agencia = 1234;
            conta.numero = 97345;

            if (conta.titular == null)
            {
                Console.WriteLine("A referencia em conta.titular eh null!!");
            }
            //Console.WriteLine(contaGabriela.titular.nome);
            Console.WriteLine(conta.titular);

            Console.ReadKey();
        }
    }
}
