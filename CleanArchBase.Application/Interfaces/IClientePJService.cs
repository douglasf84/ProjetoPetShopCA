using CleanArchBase.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchBase.Application.Interfaces
{
    public interface IClientePJService
    {
        Task CreateAsync(ClientePJViewModel clientePJViewModel);
        Task UpdateAsync(ClientePJViewModel clientePJViewModel);
        Task RemoveAsync(int? id);
        Task<IEnumerable<ClientePJViewModel>> GeASllsAsync();
        Task<ClientePJViewModel> GetByIdAsync(int? id);
    }
}
