using CleanArchBase.Application.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchBase.Application.Interfaces
{
    public interface IEstoqueService
    {
        Task CreateAsync(EstoqueViewModel estoqueViewModel);
        Task UpdateAsync(EstoqueViewModel estoqueViewModel);
        Task RemoveAsync(int? id);
        Task<IEnumerable<EstoqueViewModel>> GetProductsAsync();
        Task<EstoqueViewModel> GetByIdAsync(int? id);
    }
}
