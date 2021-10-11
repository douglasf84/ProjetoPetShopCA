using CleanArchBase.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchBase.Domain.Interfaces
{
    public interface IModeloRepository
    {    
        Task CreateAsync(Modelo modelo);
        Task UpdateAsync(Modelo modelo);
        Task RemoveAsync(Modelo modelo);
        Task<IEnumerable<Modelo>> GetAllAsync();
        Task<Modelo> GetByIdAsync(int? id);
    }
}
