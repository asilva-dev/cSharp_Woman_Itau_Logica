using LojaServices.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaServices.Services
{
    public class CompraService
    {
        private LojaContext _context;

        public CompraService(LojaContext contexto)
        {
            _context = contexto;
        }

        public Compra ProcurarPorId(int compraId)
        {
            return _context.Compras.Find(compraId);
        }

        public IList<Compra> ProcurarPorIdCliente(int clienteId)
        {
            var retorno = _context.Clientes
                .Where(x => x.Id == clienteId)
                .SelectMany(x => x.Compras)
                .Distinct() //ignora os duplicados
                .ToList();
            return retorno;
        }

        public IList<Compra> ProcurarPorIdProduto(int produtoId)
        {
            var retorno = _context.Produtos
                .Where(x => x.Id == produtoId)
                .SelectMany(x => x.Compras)
                .Distinct()
                .ToList();
            return retorno;
        }

        public Compra Salvar(Compra compra)
        {
            //verificar se é para Add ou Update
            var estado = compra.Id == 0 ? EntityState.Added : EntityState.Modified;

            //salvar esse estado no contexto
            _context.Entry(compra).State = estado;

            //persistir esses dados - salvá-los
            _context.SaveChanges();

            //retorna o objeto
            return compra;
        }
    }
}
