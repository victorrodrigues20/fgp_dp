using ProjVendas.Domain.Interfaces;
using ProjVendas.Infrastructure.Data.Context;

namespace ProjVendas.Infrastructure.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private CategoriaRepository _CategoriaRepo; 

        private VendasDbContext _context;

        public ICategoriaRepository CategoriaRepository
        {
            get { 
                return _CategoriaRepo = _CategoriaRepo ?? new CategoriaRepository(_context);
            }
        }

        public UnitOfWork(VendasDbContext contexto)
        {
            _context = contexto;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}