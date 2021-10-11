using CleanArchBase.Domain.Entities;
using CleanArchBase.Domain.Interfaces;
using CleanArchBase.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchBase.Infra.Data.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private ApplicationDbContext _context;

        public ProdutoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(Produto produto)
        {
            await _context.AddAsync(produto);
            await _context.SaveChangesAsync();
        }
        
        public async Task<Produto> GetByIdAsync(int? id)
        {
            return await _context.Produtos.FindAsync(id);
        }

        public async Task<IEnumerable<Produto>> GetAllAsync()
        {
            return await _context.Produtos.ToListAsync();
        }

        public async Task RemoveAsync(Produto produto)
        {
            _context.Remove(produto);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Produto produto)
        {
            _context.Update(produto);
            await _context.SaveChangesAsync();
        }
    }
}
