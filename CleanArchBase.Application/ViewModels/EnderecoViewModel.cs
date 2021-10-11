using CleanArchBase.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace CleanArchBase.Application.ViewModels
{
    public class EnderecoViewModel
    {
        public int Id { get; set; }

        [MaxLength(50)]
        [Display(Name = "Endereço", Description = "Endereço")]
        [Required(ErrorMessage = "O Endereço é obrigatório.")]
        [StringLength(50)]
        public string Logradouro { get; set; }

        [MaxLength(10)]
        [Required]
        public string Numero { get; set; }

        [MaxLength(50)]
        [Required]
        public string Bairro { get; set; }

        [MaxLength(15)]
        [Required]
        [DataType(DataType.PostalCode)]
        public string Cep { get; set; }

        [MaxLength(50)]
        [Required]
        public string Cidade { get; set; }

        [MaxLength(50)]
        [Required]
        public string Estado { get; set; }

        public ClientePF ClientePF { get; set; }
        public int ClientePFId { get; set; }

        public ClientePJ ClientePJ { get; set; }
        public int ClientePJId { get; set; }

    }
}
