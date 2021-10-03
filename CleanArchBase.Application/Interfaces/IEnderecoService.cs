using CleanArchBase.Application.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchBase.Application.Interfaces
{
    public interface IEnderecoService
    {
        Task CreateAsync(EnderecoViewModel enderecoViewModel);
        Task UpdateAsync(EnderecoViewModel enderecoViewModel);
        Task RemoveAsync(int? id);
        Task<IEnumerable<EnderecoViewModel>> GetProductsAsync();
        Task<EnderecoViewModel> GetByIdAsync(int? id);
    }
}
