using ProjVendas.Application.ViewModels;

namespace ProjVendas.Application.Interfaces
{
    public interface ICategoriaService
    {
        CategoriaListViewModel Get();

        CategoriaViewModel Get(int id);

        CategoriaViewModel Post(CategoriaViewModel Categoria);

        CategoriaViewModel Put(int id, CategoriaViewModel Categoria);

        CategoriaViewModel Delete(int id);
    }
}