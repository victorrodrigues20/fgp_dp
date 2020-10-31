using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ProjVendas.Domain.Entities;
using ProjVendas.Domain.Interfaces;
using ProjVendas.Infrastructure.Data.Context;

namespace ProjVendas.Infrastructure.Data.Repositories
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(VendasDbContext context) : base(context)
        {
            
        }

        public IEnumerable<Produto> GetProdutosPorCategoria(int CategoriaID)
        {
            return _context.Produto
                .Include(l => l.ProdCategoria)
                .Where(l => l.ProdCategoria.Any(la => la.CategoriaID == CategoriaID));
        }

        public IEnumerable<Produto> GetProdutosSemEstoque()
        {
            return _context.Produto.Where(l => l.Quantidade == 0);
        }
    }
}