﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _03_BBExceptions
{
    class Cliente
    {
        private string _cpf;
        public string Nome { get; set; }
        public string CPF
        {
            get
            {
                return _cpf;
            }
            set
            {
                _cpf = value;
            }
        }
        public string Profissao { get; set; }
    }
}