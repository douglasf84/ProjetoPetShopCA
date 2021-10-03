using System.Collections.Generic;

namespace CleanArchBase.Domain.Entities
{
    public class Categoria : BaseProduto
    {
        public int IdProduto { get; set; }

        public List<Produto> Produtos { get; set; }
         
    }
}
