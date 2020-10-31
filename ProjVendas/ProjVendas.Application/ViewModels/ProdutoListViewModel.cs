using System.Collections.Generic;
using ProjVendas.Domain.Entities;

namespace ProjVendas.Application.ViewModels
{
    public class ProdutoListViewModel
    {
        public IEnumerable<Produto> Produtos { get; set; }
    }
}