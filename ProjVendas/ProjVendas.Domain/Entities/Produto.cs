using System.Collections.Generic;

namespace ProjVendas.Domain.Entities
{
    public class Produto
    {
        public int ProdutoID { get; set; }

        public string Nome { get; set; }

        public int? Quantidade { get; set; }

        public ICollection<ProdutoCategoria> ProdCategoria { get; set; }
    }
}