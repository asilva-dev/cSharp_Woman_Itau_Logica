using System;

namespace _03__ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3 ByteBank");

            //tipo de referencia -  a variável guarda o endereço do objeto - ponteiro para o objeto, não igualdade
            ContaCorrente contaGabi = new ContaCorrente();
            contaGabi.titular = "Gabriela";
            contaGabi.agencia = 876;
            contaGabi.numero = 87909;

            //tipo de referência - a variável guarda o endereço do objeto - os endereços são diferentes
            ContaCorrente contaGabiCosta = new ContaCorrente();
            contaGabiCosta.titular = "Gabriela";
            contaGabiCosta.agencia = 876;
            contaGabiCosta.numero = 87909;

            Console.WriteLine("Igualdade de tipo referencia: " + (contaGabi == contaGabiCosta));

            //tipo de valor
            int idade = 27;
            int idadeDeNovo = 27;

            Console.WriteLine("Igualdade tipo valor: " + (idade == idadeDeNovo));

            contaGabi = contaGabiCosta;
            Console.WriteLine(contaGabi ==  contaGabiCosta);

            //ambas variáveis apontam para o mesmo objeto - podendo acessar os valores de qualquer uma das variáveis
            contaGabi.saldo = 300;
            Console.WriteLine(contaGabi.saldo);
            Console.WriteLine(contaGabiCosta.saldo);

            //oo - aspecto fundamental: classes possuem comportamentos
            if (contaGabiCosta.saldo >= 100)
            {
                contaGabiCosta.saldo -= 100;
            }

            Console.ReadLine();
        }
    }
}
