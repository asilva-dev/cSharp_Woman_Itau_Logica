using LojaServices.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaServices.Services
{
    public class ClienteService
    {
        private LojaContext _context;

        public ClienteService(LojaContext contexto)
        {
            _context = contexto;
        }

        public Cliente ProcurarPorId(int clienteId)
        {
            return _context.Clientes.Find(clienteId);
        }

        public IList<Cliente> ProcurarPorNome(string clienteNome)
        {
            return _context.Clientes.Where(x => x.Nome == clienteNome).ToList();
        }

        public Cliente Salvar(Cliente cliente)
        {
            //verificar se é para Add ou Update
            var estado = cliente.Id == 0 ? EntityState.Added : EntityState.Modified;

            //salvar esse estado no contexto
            _context.Entry(cliente).State = estado;

            //persistir esses dados - salvá-los
            _context.SaveChanges();

            //retorna o objeto
            return cliente;
        }
    }
}
