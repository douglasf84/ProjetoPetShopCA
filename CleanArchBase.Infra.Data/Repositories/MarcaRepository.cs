using CleanArchBase.Domain.Entities;
using CleanArchBase.Domain.Interfaces;
using CleanArchBase.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchBase.Infra.Data.Repositories
{
    public class MarcaRepository : IMarcaRepository
    {
        private ApplicationDbContext _context;

        public MarcaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task CreateAsync(Marca marca)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ClientePF>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Marca> GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(Marca marca)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Marca marca)
        {
            throw new NotImplementedException();
        }
    }
}
    
