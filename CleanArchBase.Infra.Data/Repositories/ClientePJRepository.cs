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
    public class ClientePJRepository : IClientePJRepository
    {
        private ApplicationDbContext _context;

        public ClientePJRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task CreateAsync(ClientePJ clientePJ)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ClientePF>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ClientePJ> GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(ClientePJ clientePJ)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ClientePJ clientePJ)
        {
            throw new NotImplementedException();
        }
    }
}