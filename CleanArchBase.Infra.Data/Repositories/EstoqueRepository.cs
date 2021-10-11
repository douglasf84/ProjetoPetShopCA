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
    public class EstoqueRepository : IEstoqueRepository
    {
        private ApplicationDbContext _context;

        public EstoqueRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task CreateAsync(Estoque estoque)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ClientePF>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Estoque> GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(Estoque estoque)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Estoque estoque)
        {
            throw new NotImplementedException();
        }
    }
}