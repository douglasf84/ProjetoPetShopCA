using CleanArchBase.Application.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchBase.Application.Interfaces
{
    public interface IMarcaService
    {
        Task CreateAsync(MarcaViewModel marcaViewModel);
        Task UpdateAsync(MarcaViewModel marcaViewModel);
        Task RemoveAsync(int? id);
        Task<IEnumerable<MarcaViewModel>> GetProductsAsync();
        Task<MarcaViewModel> GetByIdAsync(int? id);
    }
}
