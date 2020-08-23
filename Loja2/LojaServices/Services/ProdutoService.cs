using LojaServices.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaServices.Services
{
    public class ProdutoService
    {
        private LojaContext _context;

        public ProdutoService(LojaContext contexto)
        {
            _context = contexto;
        }

        public Produto ProcurarPorId(int produtoId)
        {
            //utilzar metodo Find
            return _context.Produtos.Find(produtoId);
        }

        public IList<Produto> ProcurarPorCategoria(string nome)
        {
            //utilizar método Where
            return _context.Produtos.Where(x => x.Categoria == nome).ToList();
        }

        public Produto Salvar(Produto produto)
        {
            //verificar se é para Add ou Update
            var estado = produto.Id == 0 ? EntityState.Added : EntityState.Modified;

            //salvar esse estado no contexto
            _context.Entry(produto).State = estado;

            //persistir esses dados - salvá-los
            _context.SaveChanges();

            //retorna o objeto
            return produto;
        }

    }
}
