using CleanArchBase.Application.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchBase.Application.Interfaces
{
    public interface IEnderecoService
    {
        Task CreateAsync(EnderecoViewModel endereco);
        Task UpdateAsync(EnderecoViewModel endereco);
        Task RemoveAsync(int? id);
        Task<IEnumerable<EnderecoViewModel>> GetAllAsync();
        Task<EnderecoViewModel> GetByIdAsync(int? id);
    }
}
