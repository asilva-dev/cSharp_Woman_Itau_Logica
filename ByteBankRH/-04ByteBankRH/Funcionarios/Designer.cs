using System;
using System.Collections.Generic;
using System.Text;
using _04_ByteBankRH.Funcionarios;

namespace _04_ByteBankRH.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string cpf) : base(3000, cpf)
        {
        }

        public override double GetBonificacao()
        {
            return Salario * 0.17;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }
    }
}
