using System.Collections.Generic;
using ProjVendas.Domain.Entities;

namespace ProjVendas.Domain.Interfaces
{
    public interface ICategoriaRepository : IRepository<Categoria>
    {
        IEnumerable<Categoria> GetCategoriasContemNome(string nome);
    }
}