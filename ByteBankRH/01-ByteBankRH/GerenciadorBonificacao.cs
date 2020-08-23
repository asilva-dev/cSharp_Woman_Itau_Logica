using _01_ByteBankRH.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01_ByteBankRH
{
    class GerenciadorBonificacao
    {
        //encapsular - há possibilidade de alguem manipular de fora da classe
        private double _totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }

        //métodos com mesmo nome obrigatoriamente deverao ter argumentos diferentes, cargas diferentes
        //sobrecargas de método
        //mesmo problema que tinhamos dentro da classe em funcionario - tem que ser extensível
        //remover após herança na classe de diretor
        public void Registrar(Diretor diretor)
        {
            _totalBonificacao += diretor.GetBonificacao();
        }

        //por enquanto só retorna
        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
