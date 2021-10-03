using CleanArchBase.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchBase.Domain.Interfaces
{
    public interface ICategoriaRepository
    {    
        Task CreateAsync(Categoria categoria);
        Task UpdateAsync(Categoria categoria);
        Task RemoveAsync(Categoria categoria);
        Task<IEnumerable<Categoria>> GetAllsAsync();
        Task<Categoria> GetByIdAsync(int? id);
    }
}
