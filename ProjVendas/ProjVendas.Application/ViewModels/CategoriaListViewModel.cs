using System.Collections.Generic;
using ProjVendas.Domain.Entities;

namespace ProjVendas.Application.ViewModels
{
    public class CategoriaListViewModel
    {
        public IEnumerable<Categoria> Categorias { get; set; }
    }
}