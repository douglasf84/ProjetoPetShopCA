using CleanArchBase.Application.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchBase.Application.Interfaces
{
    public interface IMarcaService
    {
        Task CreateAsync(MarcaViewModel marca);
        Task UpdateAsync(MarcaViewModel marca);
        Task RemoveAsync(int? id);
        Task<IEnumerable<MarcaViewModel>> GetAllAsync();
        Task<MarcaViewModel> GetByIdAsync(int? id);
    }
}
