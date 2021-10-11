using CleanArchBase.Application.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchBase.Application.Interfaces
{
    public interface IEstoqueService
    {
        Task CreateAsync(EstoqueViewModel estoque);
        Task UpdateAsync(EstoqueViewModel estoque);
        Task RemoveAsync(int? id);
        Task<IEnumerable<EstoqueViewModel>> GetAllAsync();
        Task<EstoqueViewModel> GetByIdAsync(int? id);
    }
}
