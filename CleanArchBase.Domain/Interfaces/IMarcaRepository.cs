using CleanArchBase.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchBase.Domain.Interfaces
{
    public interface IMarcaRepository
    {    
        Task CreateAsync(Marca marca);
        Task UpdateAsync(Marca marca);
        Task RemoveAsync(Marca marca);
        Task<IEnumerable<ClientePF>> GetAllAsync();
        Task<Marca> GetByIdAsync(int? id);
    }
}
