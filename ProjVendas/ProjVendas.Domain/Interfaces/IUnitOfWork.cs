using ProjVendas.Domain.Interfaces;

namespace ProjVendas.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        ICategoriaRepository CategoriaRepository { get; }

         void Commit();
    }
}