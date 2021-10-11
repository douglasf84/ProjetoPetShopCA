using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CleanArchBase.Application.ViewModels
{
    public class ProdutoViewModel
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage ="The Name is Required")]
        [MinLength(3)]
        [MaxLength(100)]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "The Description is Required")]
        [MinLength(3)]
        [MaxLength(100)]
        [DisplayName("Descricao")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "The Price is Required")]
        [Range(1, 99999.99)]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [DisplayName("Preco")]
        public decimal Preco { get; set; }
    }
}
