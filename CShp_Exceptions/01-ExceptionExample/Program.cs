using System;

namespace _01_ExceptionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("01!");

            var retorno = Metodo();

            if(retorno == -2)
            {
                Console.WriteLine("Ocorreu um erro!");

                Console.ReadKey();
            }
        }

        private static int Metodo()
        {
            //return void
            //TestaDivisao(2);
            //Erro DivideByZeroException é um argumento que o método não sabe tratar

            //return int
            return TestaDivisao(2);
        }

        //não deve ser responsável pelo controle de erro do método dividir, pra isso precisa avisar o método anterior
        private static int TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);

            //retorno int
            if(resultado == -2)
            {
                return -2;
            }

            //retorno void
            if(resultado == -1)
            {
                Console.WriteLine("Não é possivel fazer a divisão por zero");
            }
            else
            {
                Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
            }

            //return int
            return 0;
            //Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
        }    

        private static int Dividir(int numero, int divisor)
        {
            //retorno inteiro - codigo de erro divisão por zero
            if (divisor == 0)
            {
                return -1;
            }

            //mesmo codigo de erro de divisão por zero
            //if (divisor > numero)
            //{
            //    return -1;
            //}

            if (divisor > numero)
            {
                return -2;
            }

            return numero / divisor;
        }
    }
}
