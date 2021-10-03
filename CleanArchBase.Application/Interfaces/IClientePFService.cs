using CleanArchBase.Application.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchBase.Application.Interfaces
{
    public interface IClientePFService
    {
        Task CreateAsync(ClientePFViewModel clientePFViewModel);
        Task UpdateAsync(ClientePFViewModel clientePFViewModel);
        Task RemoveAsync(int? id);
        Task<IEnumerable<ClientePFViewModel>> GeASllsAsync();
        Task<ClientePFViewModel> GetByIdAsync(int? id);
    }
}
