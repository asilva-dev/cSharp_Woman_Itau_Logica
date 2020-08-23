using System;
using System.Collections.Generic;
using System.Text;
using ByteBank.Sistemas;

namespace ByteBank
{
    class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
