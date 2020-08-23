using LojaServices.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaServices.Services
{
    public class EnderecoService
    {
        private LojaContext _context;

        //construtor
        public EnderecoService(LojaContext contexto)
        {
            _context = contexto;
        }

        public Endereco ProcurarPorId(int enderecoId)
        {
            //Find procura algo
            return _context.Enderecos.Find(enderecoId);
        }

        public IList<Endereco> ProcurarPorClienteId(int clienteId)
        {
            var retorno = _context.Enderecos
                .Where(x => x.Cliente.Id == clienteId)
                .ToList();
            return retorno;
        }

        public Endereco Salvar(Endereco endereco)
        {
            //verificar se é para Add ou Update / 
            var estado = endereco.Id == 0 ? EntityState.Added : EntityState.Modified;

            //salvar esse estado no contexto
            _context.Entry(endereco).State = estado;

            //persistir esses dados - salvá-los
            _context.SaveChanges();

            //retorna o objeto
            return endereco;
        }
    }
}
