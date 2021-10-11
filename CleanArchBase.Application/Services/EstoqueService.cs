using AutoMapper;
using CleanArchBase.Application.Interfaces;
using CleanArchBase.Application.ViewModels;
using CleanArchBase.Domain.Entities;
using CleanArchBase.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchBase.Application.Services
{
    public class EstoqueService : IEstoqueService
    {
        private IEstoqueRepository _estoqueRepository;
        private readonly IMapper _mapper;

        public EstoqueService(IEstoqueRepository estoqueRepository, IMapper mapper)
        {
            _estoqueRepository = estoqueRepository;
            _mapper = mapper;
        }

        public async Task CreateAsync(EstoqueViewModel estoque)
        {
            var mapObject = _mapper.Map<Estoque>(estoque);
            await _estoqueRepository.CreateAsync(mapObject);
        }

        public async Task<IEnumerable<EstoqueViewModel>> GetAllAsync()
        {
            var result = await _estoqueRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<EstoqueViewModel>>(result);
        }

        public async Task<EstoqueViewModel> GetByIdAsync(int? id)
        {
            var result = await _estoqueRepository.GetByIdAsync(id);
            return _mapper.Map<EstoqueViewModel>(result);
        }

        public async Task RemoveAsync(int? id)
        {
            var objectRemove = _estoqueRepository.GetByIdAsync(id).Result;
            await _estoqueRepository.RemoveAsync(objectRemove);
        }

        public async Task UpdateAsync(EstoqueViewModel estoque)
        {
            var mapObject = _mapper.Map<Estoque>(estoque);
            await _estoqueRepository.UpdateAsync(mapObject);
        }
    }
}
