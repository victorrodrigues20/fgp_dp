using ProjVendas.Application.Interfaces;
using ProjVendas.Application.ViewModels;
using ProjVendas.Domain.Interfaces;

namespace ProjVendas.Application.Services
{
    public class ProdutoService : IProdutoService
    {
        public IProdutoRepository _ProdutoRepository;

        public ProdutoService(IProdutoRepository ProdutoRepository)
        {
            this._ProdutoRepository = ProdutoRepository;
        }

        public ProdutoListViewModel Get()
        {
            return new ProdutoListViewModel()
            {
                Produtos = this._ProdutoRepository.Get()
            };
        }
    }
}