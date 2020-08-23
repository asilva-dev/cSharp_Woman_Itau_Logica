using System;

namespace _5_CaracteresExternos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5- Caracteres e textos!");

            char primeiraLetra = 'a'; //aspas simples para char
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65 ; //Tabela ASCII
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Codenation Women Itau";
            Console.WriteLine(titulo);

            //string modulos = "Variaveis " +
            //    "Orientacao a Objetos " +
            //    "Clean Code ";

            string modulos = 
@"Variaveis  
Orientacao a Objetos 
Clean Code ";

            Console.WriteLine(modulos);
            

            Console.ReadKey();
        }
    }
}
