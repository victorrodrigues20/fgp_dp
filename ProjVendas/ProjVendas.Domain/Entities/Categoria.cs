using System.Collections.Generic;

namespace ProjVendas.Domain.Entities
{
    public class Categoria
    {
        public int CategoriaID { get; set; }

        public string Nome { get; set; }

        public ICollection<ProdutoCategoria> ProdCategoria { get; set; }
    }
}