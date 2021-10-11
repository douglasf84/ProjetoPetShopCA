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
    public class ModeloRepository : IModeloRepository
    {
        private ApplicationDbContext _context;

        public ModeloRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task CreateAsync(Modelo modelo)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Modelo>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Modelo> GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(Modelo modelo)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Modelo modelo)
        {
            throw new NotImplementedException();
        }
    }
}
