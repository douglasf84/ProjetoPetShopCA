using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchBase.Domain.Entities
{
    public class Estoque
    {
        public int Id { get; set; }
        public int IdProduto { get; set; }
        public string Descricao {  get; set; }

        public int Quantidade { get; set; }
        public DateTime DataAtualizacaoEstoque { get; set; }
    }
}
