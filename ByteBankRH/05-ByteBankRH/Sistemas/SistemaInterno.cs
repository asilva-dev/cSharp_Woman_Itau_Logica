using System;
using System.Collections.Generic;
using System.Text;
using _05_ByteBankRH.Funcionarios;

namespace _05_ByteBankRH.Sistemas
{
    class SistemaInterno
    {
        //public bool Logar(Funcionario funcionario, string senha)
        //public bool Logar(Diretor funcionario, string senha)
        //{
        //    bool usuarioAutenticado = funcionario.Autenticar(senha);

        //    if (usuarioAutenticado)
        //    {
        //        Console.WriteLine("Bem-vindo ao sistema!");
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Senha incorreta!");
        //        return false;
        //    }
        //}

        //public bool Logar(GerenteDeConta funcionario, string senha)
        //{
        //    bool usuarioAutenticado = funcionario.Autenticar(senha);

        //    if (usuarioAutenticado)
        //    {
        //        Console.WriteLine("Bem-vindo ao sistema!");
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Senha incorreta!");
        //        return false;
        //    }
        //}

        public bool Logar(Autenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem-vindo ao sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
                return false;
            }
        }
    }
}
