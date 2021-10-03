using CleanArchBase.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchBase.Domain.Interfaces
{
    public interface IEstoqueRepository
    {    
        Task CreateAsync(Estoque estoque);
        Task UpdateAsync(Estoque estoque);
        Task RemoveAsync(Estoque estoque);
        Task<IEnumerable<ClientePF>> GetAllAsync();
        Task<Estoque> GetByIdAsync(int? id);
    }
}
