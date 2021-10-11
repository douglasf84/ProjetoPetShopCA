using CleanArchBase.Application.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchBase.Application.Interfaces
{
    public interface IClientePFService
    {
        Task CreateAsync(ClientePFViewModel clientePF);
        Task UpdateAsync(ClientePFViewModel clientePF);
        Task RemoveAsync(int? id);
        Task<IEnumerable<ClientePFViewModel>> GetASllsAsync();
        Task<ClientePFViewModel> GetByIdAsync(int? id);
    }
}
