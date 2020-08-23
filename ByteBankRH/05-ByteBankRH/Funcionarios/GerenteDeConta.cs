using System;
using System.Collections.Generic;
using System.Text;
using _05_ByteBankRH.Funcionarios;

namespace _05_ByteBankRH.Funcionarios
{
    class GerenteDeConta : Funcionario
    {
        //public string Senha { get; set; }
        public GerenteDeConta(string cpf) : base(4000, cpf)
        {
        }

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.5;
        }

        //public bool Autenticar(string senha)
        //{
        //    return Senha == senha;
        //}
    }
}
