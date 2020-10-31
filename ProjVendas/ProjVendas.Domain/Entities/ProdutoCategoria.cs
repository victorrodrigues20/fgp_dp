namespace ProjVendas.Domain.Entities
{
    public class ProdutoCategoria
    {
        public int CategoriaID { get; set; }
        public Categoria Categoria { get; set; }

        public int ProdutoID { get; set; }
        public Produto Produto { get; set; }
    }
}