using CleanArchBase.Application.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchBase.Application.Interfaces
{
    public interface IProdutoService
    {
        Task CreateAsync(ProdutoViewModel product);
        Task UpdateAsync(ProdutoViewModel product);
        Task RemoveAsync(int? id);
        Task<IEnumerable<ProdutoViewModel>> GetAllAsync();
        Task<ProdutoViewModel> GetByIdAsync(int? id);
    }
}
