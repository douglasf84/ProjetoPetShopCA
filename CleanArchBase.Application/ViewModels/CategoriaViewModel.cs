using System.Collections.Generic;

namespace CleanArchBase.Application.ViewModels
{
    public class CategoriaViewModel
    {
        public int IdProduto { get; set; }

        public List<ProdutoViewModel> Produtos { get; set; }
         
    }
}
