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
    public class ClientePFRepository : IClientePFRepository
    {
        private ApplicationDbContext _context;

        public ClientePFRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task CreateAsync(ClientePF clientePF)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ClientePF>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ClientePF> GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(ClientePF clientePF)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ClientePF clientePF)
        {
            throw new NotImplementedException();
        }
    }
}