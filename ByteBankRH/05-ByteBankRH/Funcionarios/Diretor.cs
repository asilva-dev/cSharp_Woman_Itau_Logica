using System;
using System.Collections.Generic;
using System.Text;
using _05_ByteBankRH.Sistemas;

namespace _05_ByteBankRH.Funcionarios
{
    class Diretor : Autenticavel
    {
        //ao herdar de Funcionario as propriedades ficam sublinhadas de verde pois já estão declaradas na classe base
        //após herença, modificar GerenciadorBonificacao
        //public string Nome { get; set; }
        //public string CPF { get; set; }
        //public double Salario { get; set; }

        //public double GetBonificacao()
        //virtual - tem uma implementação mas permite que outra classe sobreescreva o metodo
        //public virtual double GetBonificacao()
        //{
        //    return Salario;
        //}

        //só funciona quando trabalha a partir de uma referencia explicitamente do uso diretor
        //override indica que está sobreescrevendo o método virtual da classe base
        //polimorfismo - objetos de uma classe derivada podem ser tratados como objetos de uma classe base, modificando o comportamento
        //public double GetBonificacao();
        public override double GetBonificacao()
        {
            //return Salario;
            //return Salario + (Salario * 0.10);
            //loop - estouro da pilha
            //return Salario + GetBonificacao();

            //referencia para classe base
            return Salario + base.GetBonificacao();
        }
    }
}
