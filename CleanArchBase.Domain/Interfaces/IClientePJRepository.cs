using CleanArchBase.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchBase.Domain.Interfaces
{
    public interface IClientePJRepository
    {    
        Task CreateAsync(ClientePJ clientePJ);
        Task UpdateAsync(ClientePJ clientePJ);
        Task RemoveAsync(ClientePJ clientePJ);
        Task<IEnumerable<ClientePF>> GetAllAsync();
        Task<ClientePJ> GetByIdAsync(int? id);
    }
}
