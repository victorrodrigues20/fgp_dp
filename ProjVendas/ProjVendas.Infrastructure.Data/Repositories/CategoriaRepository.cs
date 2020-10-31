using System.Collections.Generic;
using System.Linq;
using ProjVendas.Domain.Entities;
using ProjVendas.Domain.Interfaces;
using ProjVendas.Infrastructure.Data.Context;

namespace ProjVendas.Infrastructure.Data.Repositories
{
    public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(VendasDbContext context) : base(context)
        {
            
        }

        public IEnumerable<Categoria> GetCategoriasContemNome(string nome)
        {
            return _context.Set<Categoria>()
                .Where(a => a.Nome.Contains(nome));
        }
    }
}