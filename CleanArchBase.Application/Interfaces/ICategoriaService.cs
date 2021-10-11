using CleanArchBase.Application.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchBase.Application.Interfaces
{
    public interface ICategoriaService
    {
        Task CreateAsync(CategoriaViewModel categoria);
        Task UpdateAsync(CategoriaViewModel categoria);
        Task RemoveAsync(int? id);
        Task<IEnumerable<CategoriaViewModel>> GetAllAsync();
        Task<CategoriaViewModel> GetByIdAsync(int? id);
    }
}
