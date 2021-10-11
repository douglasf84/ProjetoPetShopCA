using AutoMapper;
using CleanArchBase.Application.Interfaces;
using CleanArchBase.Application.ViewModels;
using CleanArchBase.Domain.Entities;
using CleanArchBase.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchBase.Application.Services
{
    public class ProdutoService : IProdutoService
    {
        private IProdutoRepository _productRepository;
        private readonly IMapper _mapper;

        public ProdutoService(IProdutoRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task CreateAsync(ProdutoViewModel product)
        {
            var mapProduct = _mapper.Map<Produto>(product);
            await _productRepository.CreateAsync(mapProduct);
        }

        public async Task<ProdutoViewModel> GetByIdAsync(int? id)
        {
            var result = await _productRepository.GetByIdAsync(id);
            return _mapper.Map<ProdutoViewModel>(result);
        }

        public async Task<IEnumerable<ProdutoViewModel>> GetAllAsync()
        {
            var result = await _productRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<ProdutoViewModel>>(result);
        }

        public async Task RemoveAsync(int? id)
        {
            var product = _productRepository.GetByIdAsync(id).Result;
            await _productRepository.RemoveAsync(product);
        }


        public async Task UpdateAsync(ProdutoViewModel product)
        {
            var mapProdutc = _mapper.Map<Produto>(product);
            await _productRepository.UpdateAsync(mapProdutc);
        }


    }
}
