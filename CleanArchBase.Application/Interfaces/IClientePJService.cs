using CleanArchBase.Application.ViewModels;
using CleanArchBase.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchBase.Application.Interfaces
{
    public interface IClientePJService
    {
        Task CreateAsync(ClientePJViewModel clientePJ);
        Task UpdateAsync(ClientePJViewModel clientePJ);
        Task RemoveAsync(int? id);
        Task<IEnumerable<ClientePJViewModel>> GetASllsAsync();
        Task<ClientePJViewModel> GetByIdAsync(int? id);
    }
}
