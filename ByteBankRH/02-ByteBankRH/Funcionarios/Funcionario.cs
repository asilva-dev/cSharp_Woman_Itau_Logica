using System;
using System.Collections.Generic;
using System.Text;

namespace _02_ByteBankRH.Funcionarios
{
    class Funcionario
    {
        //public Funcionario(int tipo)
        //0 - funcionario sem deficição de cargo
        //1- diretor
        //2 - designer
        //N - ...
        //private int _tipo;
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        
        //public double GetBonificacao()
        //virtual permite que outra classe sobreescreva o metodo
        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }
    }
}
