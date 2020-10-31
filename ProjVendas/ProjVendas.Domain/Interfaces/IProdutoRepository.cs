using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using ProjVendas.Domain.Entities;

namespace ProjVendas.Domain.Interfaces
{
    public interface IProdutoRepository  : IRepository<Produto>
    {
        IEnumerable<Produto> GetProdutosSemEstoque();
        IEnumerable<Produto> GetProdutosPorCategoria(int CategoriaID);
    }
}