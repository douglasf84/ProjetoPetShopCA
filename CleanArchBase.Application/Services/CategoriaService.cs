using AutoMapper;
using CleanArchBase.Application.Interfaces;
using CleanArchBase.Application.ViewModels;
using CleanArchBase.Domain.Entities;
using CleanArchBase.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchBase.Application.Services
{
    public class CategoriaService : ICategoriaService
    {
        private ICategoriaRepository _categoriaRepository;
        private readonly IMapper _mapper;

        public CategoriaService(ICategoriaRepository categoriaRepository, IMapper mapper)
        {
            _categoriaRepository = categoriaRepository;
            _mapper = mapper;
        }

        public async Task CreateAsync(CategoriaViewModel Categoria)
        {
            var mapProduct = _mapper.Map<Categoria>(Categoria);
            await _categoriaRepository.CreateAsync(mapProduct);
        }

        public async Task<CategoriaViewModel> GetByIdAsync(int? id)
        {
            var result = await _categoriaRepository.GetByIdAsync(id);
            return _mapper.Map<CategoriaViewModel>(result);
        }

        public async Task<IEnumerable<CategoriaViewModel>> GetAllAsync()
        {
            var result = await _categoriaRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<CategoriaViewModel>>(result);
        }

        public async Task RemoveAsync(int? id)
        {
            var Categoria = _categoriaRepository.GetByIdAsync(id).Result;
            await _categoriaRepository.RemoveAsync(Categoria);
        }

        public async Task UpdateAsync(CategoriaViewModel Categoria)
        {
            var mapProdutc = _mapper.Map<Categoria>(Categoria);
            await _categoriaRepository.UpdateAsync(mapProdutc);
        }
    }
}
