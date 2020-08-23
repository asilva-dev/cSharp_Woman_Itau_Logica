using System;
using System.Collections.Generic;
using System.Text;
using _04_ByteBankRH.Funcionarios;
using _04_ByteBankRH;

namespace _04_ByteBankRH.Funcionarios
{
    //classe funcionario na vdd é uma abstração que mostra as caracteristicas compartilhadas: propriedades e metodos
    //cada derivada possui sua logica 
    //benefícios do polimorfismo
    //classes abstratas não podem/devem ser instanciadas
    class Funcionario
    {        
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }
        public static int TotalDeFuncionarios { get; private set; }

        public Funcionario(double salario, string cpf)
        {
            TotalDeFuncionarios++;
            Console.WriteLine("Criando Funcionario");

            CPF = cpf;
            Salario = salario;
        }

        //abstract - ao transformar os metodos em abstratos, as classes derivadas são obrigadas a implementar os metodos
        //metodos abstratos não tem implementações (corpo), apenas definem a assinatura.
        //metodos abstratos somente em classes abstratas
        public abstract double GetBonificacao();

        //{
        //    return Salario * 0.10;
        //}

        public abstract void AumentarSalario();
        //{
        //    //Salario = Salario + (Salario * 0.1);
        //    //Salario = Salario * 1.1;
        //    Salario *= 1.1;
        //}
    }
}
