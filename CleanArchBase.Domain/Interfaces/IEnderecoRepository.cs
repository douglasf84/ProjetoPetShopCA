using CleanArchBase.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchBase.Domain.Interfaces
{
    public interface IEnderecoRepository
    {    
        Task CreateAsync(Endereco endereco);
        Task UpdateAsync(Endereco endereco);
        Task RemoveAsync(Endereco endereco);
        Task<IEnumerable<Endereco>> GetAllAsync();
        Task<Endereco> GetByIdAsync(int? id);
    }
}
