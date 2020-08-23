using LojaServices.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaServices.Services
{
    public class PromocoesService
    {

        private LojaContext _context;

        public PromocoesService(LojaContext contexto)
        {
            _context = contexto;
        }

        public Promocao ProcurarPorId(int promocaoId)
        {
            //utilzar metodo Find
            return _context.Promocoes.Find(promocaoId);
        }

        //relacionamento de n para n
        public Promocao ProdutosPromocao()
        {
            return _context.Promocoes
                .Include(p => p.Produtos)
                .ThenInclude(pp => pp.Produto)
                .FirstOrDefault();
        }

        public Promocao Salvar(Promocao promocao)
        {
             //Analisar e identificar as entidades identificadas como adicionadas
            _context.Add(promocao);
            //persistir esses dados - salvá-los
            _context.SaveChanges();
            //retorna o objeto
            return promocao;
        }
    }
}
