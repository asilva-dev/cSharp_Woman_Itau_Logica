using System;
using System.Collections.Generic;
using System.Text;
using ByteBank.Sistemas;
using ByteBank.Funcionarios;

namespace ByteBank.Sistemas
{
    //public abstract class IAutenticavel : Funcionario
    //{
    //    public IAutenticavel(double salario, string cpf) : base(salario, cpf)
    //    {
    //    }
    //    public string Senha { get; set; }
    //    public bool Autenticar(string senha)
    //    {
    //        return Senha == senha;
    //    }

    //é um contrato onde quem assina se responsabiliza por implementar esses métodos (cumprir o contrato)
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}

