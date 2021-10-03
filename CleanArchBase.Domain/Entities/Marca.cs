using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchBase.Domain.Entities
{
    public class Marca : BaseProduto
    {
        public int IdCategoria { get; set; }
        public List<Categoria> Categorias { get; set; }
    }

}
