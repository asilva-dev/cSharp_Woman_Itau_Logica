using System;
using System.Collections.Generic;
using System.Text;
using _04_ByteBankRH.Funcionarios;

namespace _04_ByteBankRH.Funcionarios
{
    class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(2000, cpf)
        {
        }
        public override double GetBonificacao()
        {
            return Salario * 0.20;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }
    }
}
