using LojaServices.Models;
using LojaServices.Services;
using Microsoft.EntityFrameworkCore;
using System;
using Xunit;

namespace Loja.Test
{
    public class EnderecoServiceTest
    {
        private LojaContext _contexto;

        public EnderecoServiceTest()
        {
            var options = new DbContextOptionsBuilder<LojaContext>();
            options.UseSqlServer("Server=localhost;Database=LojaServices;Integrated Security=True;");

            _contexto = new LojaContext(options.Options);
        }

        [Fact]
        public void Devera_Add_Novo_Endereço()
        {
            //definir entradas
            var fakeEnd = new Endereco()
            {
                Id = 0,
                Logradouro = "Rua Duzentos",
                Numero = 500,
                Cidade = "São Paulo",
                Bairro = "Treze"
            };

            var atual = new Endereco();

            //metodo de teste
            var service = new EnderecoService(_contexto);
            atual = service.Salvar(fakeEnd);

            //Assert
            Assert.NotEqual(0, fakeEnd.Id);
        }

        [Fact]
        public void Devera_Alterar__Endereco()
        {
            //definir entradas
            var fakeEnd = new Endereco()
            {
                Id = 2,
                Logradouro = "Rua Um",
                Numero = 130,
                Cidade = "São Paulo",
                Bairro = "Teste"
            };

            var atual = new Endereco();

            //metodo de teste
            var service = new EnderecoService(_contexto);
            atual = service.Salvar(fakeEnd);

            //Assert
            Assert.NotEqual(0, fakeEnd.Id);
        }
    }
}
