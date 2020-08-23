using System;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("6");             

            //Instanciando as Classes cliente e conta
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            //Atribuindo propriedades
            cliente.Nome = "Amanda";
            cliente.CPF = "355.034.798-74";
            cliente.profisao = "Desenvolvedora";

            //saldo nao pode ser negativo, porém o campo está public e em qualquer lugar do código pode ser modificado com facilidade
            //conta.saldo = -10;

            //conta.SetSaldo(-10);
            //conta.GetSaldo(-10);

            conta.Saldo = -10;
            conta.Titular = cliente;

            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Saldo);

            Console.ReadLine();
             
        }
    }
}
