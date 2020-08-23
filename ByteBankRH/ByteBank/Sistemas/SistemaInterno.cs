﻿using System;
using System.Collections.Generic;
using System.Text;
using ByteBank.Funcionarios;

namespace ByteBank.Sistemas
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

        public bool Logar(IAutenticavel funcionario, string senha)
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
