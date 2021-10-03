using System;

namespace CleanArchBase.Application.ViewModels
{
    public class EstoqueViewModel
    {
        public int Id { get; set; }
        public int IdProduto { get; set; }
        public string Descricao {  get; set; }

        public int Quantidade { get; set; }
        public DateTime DataAtualizacaoEstoque { get; set; }
    }
}
