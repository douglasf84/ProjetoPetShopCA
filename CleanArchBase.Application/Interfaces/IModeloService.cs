using CleanArchBase.Application.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchBase.Application.Interfaces
{
    public interface IModeloService
    {
        Task CreateAsync(ModeloViewModel modeloViewModel);
        Task UpdateAsync(ModeloViewModel modeloViewModel);
        Task RemoveAsync(int? id);
        Task<IEnumerable<ModeloViewModel>> GetProductsAsync();
        Task<ModeloViewModel> GetByIdAsync(int? id);
    }
}
