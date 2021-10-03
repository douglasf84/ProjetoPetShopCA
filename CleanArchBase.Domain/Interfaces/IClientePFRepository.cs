using CleanArchBase.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchBase.Domain.Interfaces
{
    public interface IClientePFRepository
    {    
        Task CreateAsync(ClientePF clientePF);
        Task UpdateAsync(ClientePF clientePF);
        Task RemoveAsync(ClientePF clientePF);
        Task<IEnumerable<ClientePF>> GetAllAsync();
        Task<ClientePF> GetByIdAsync(int? id);
    }
}
