using System;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("9- Escopo!");

            int idadeCarla = 18;
            int qtdPessoas = 1;
            bool acompanhada = false;

            //string mensagemAdicional;
            //string mensagemAdicional = "";
            string mensagemAdicional = string.Empty;

            if (acompanhada) 
                mensagemAdicional = "Carla está acompanhada";
            else
                mensagemAdicional = "Carla não está acompanhada";
            if(idadeCarla >= 18 && acompanhada)
                mensagemAdicional = "Carla pode entrar!";

        }
}
