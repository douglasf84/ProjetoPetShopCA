using CleanArchBase.Domain.Entities;
using CleanArchBase.Domain.Interfaces;
using CleanArchBase.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchBase.Infra.Data.Repositories
{
    public class ProductRepository : IProdutoRepository
    {
        private ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(Produto product)
        {
            await _context.AddAsync(product);
            await _context.SaveChangesAsync();
        }
        
        public async Task<Produto> GetByIdAsync(int? id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task<IEnumerable<Produto>> GetProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task RemoveAsync(Produto product)
        {
            _context.Remove(product);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Produto product)
        {
            _context.Update(product);
            await _context.SaveChangesAsync();
        }
    }
}
