using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchBase.Domain.Entities
{
    public class Modelo : BaseProduto
    {
        public int IdMarca { get; set; }
        public List<Marca> Marcas { get; set; }
    }
}
