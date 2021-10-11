using CleanArchBase.Application.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchBase.Application.Interfaces
{
    public interface IModeloService
    {
        Task CreateAsync(ModeloViewModel modelo);
        Task UpdateAsync(ModeloViewModel modelo);
        Task RemoveAsync(int? id);
        Task<IEnumerable<ModeloViewModel>> GetAllAsync();
        Task<ModeloViewModel> GetByIdAsync(int? id);
    }
}
