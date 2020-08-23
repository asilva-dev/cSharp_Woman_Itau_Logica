﻿using _04_ByteBankRH.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace _04_ByteBankRH
{
    class GerenciadorBonificacao
    {
        private double _totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }

        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }

    }
}
