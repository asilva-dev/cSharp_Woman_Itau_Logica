using System;
using System.Collections.Generic;

namespace Fibonacci
{
    class Program
    {
        public List<int> Fibonacci(int n)
        {
            int n1 = 0, n2 = 1, n3, i, numero = 14;
            for (i = 2; i < numero; ++i)  // o loop inicia em 2 porque 0 e 1 já estão impressos    
            {
                n3 = n1 + n2;
                Console.Write(n3 + "");
                n1 = n2;
                n2 = n3;
            }


            throw new NotImplementedException();
        }

        public bool IsFibonacci(int numberToTest)
        {
            throw new NotImplementedException();

        }
    }
}
