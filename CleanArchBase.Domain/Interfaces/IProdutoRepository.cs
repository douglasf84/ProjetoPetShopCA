using CleanArchBase.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchBase.Domain.Interfaces
{
    public interface IProdutoRepository
    {    
        Task CreateAsync(Produto product);
        Task UpdateAsync(Produto product);
        Task RemoveAsync(Produto product);
        Task<IEnumerable<Produto>> GetProductsAsync();
        Task<Produto> GetByIdAsync(int? id);
    }
}
