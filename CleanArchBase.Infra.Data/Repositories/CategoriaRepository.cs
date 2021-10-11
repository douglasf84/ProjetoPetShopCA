using CleanArchBase.Domain.Entities;
using CleanArchBase.Domain.Interfaces;
using CleanArchBase.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchBase.Infra.Data.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private ApplicationDbContext _context;

        public CategoriaRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public Task CreateAsync(Categoria categoria)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Categoria>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Categoria> GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(Categoria categoria)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Categoria categoria)
        {
            throw new NotImplementedException();
        }
    }
}