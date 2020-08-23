using System;
using System.Collections.Generic;
using System.Text;

namespace _06_ByteBank
{
    public class Cliente
    {
        private string _cpf;
        //atalho prop
        public string Nome { get; set; }
        public string CPF
        {
            get
            {
                return _cpf;
            }
            set
            {
                // Escrevo minha lógica de validação de CPF
                _cpf = value;
            }
        }
        public string profisao { get; set; }            
    }
}
