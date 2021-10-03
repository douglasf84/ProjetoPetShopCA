using CleanArchBase.Application.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchBase.Application.Interfaces
{
    public interface ICategoriaPFService
    {
        Task CreateAsync(CategoriaViewModel categoriaViewModel);
        Task UpdateAsync(CategoriaViewModel categoriaViewModel);
        Task RemoveAsync(int? id);
        Task<IEnumerable<CategoriaViewModel>> GetProductsAsync();
        Task<CategoriaViewModel> GetByIdAsync(int? id);
    }
}
