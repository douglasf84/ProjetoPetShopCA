using System;

namespace CleanArchBase.Domain.Entities
{
    public class BaseProduto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAtualizacao{ get; set; }
    }
}
