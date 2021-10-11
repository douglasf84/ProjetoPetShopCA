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
    public class EnderecoRepository : IEnderecoRepository
    {
        private ApplicationDbContext _context;

        public EnderecoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task CreateAsync(Endereco endereco)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Endereco>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Endereco> GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(Endereco endereco)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Endereco endereco)
        {
            throw new NotImplementedException();
        }
    }
}