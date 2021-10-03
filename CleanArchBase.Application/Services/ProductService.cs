﻿using AutoMapper;
using CleanArchBase.Application.Interfaces;
using CleanArchBase.Application.ViewModels;
using CleanArchBase.Domain.Entities;
using CleanArchBase.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchBase.Application.Services
{
    public class ProductService : IProductService
    {
        private IProdutoRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProdutoRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task CreateAsync(ProductViewModel product)
        {
            var mapProduct = _mapper.Map<Produto>(product);
            await _productRepository.CreateAsync(mapProduct);
        }

        public async Task<ProductViewModel> GetByIdAsync(int? id)
        {
            var result = await _productRepository.GetByIdAsync(id);
            return _mapper.Map<ProductViewModel>(result);
        }

        public async Task<IEnumerable<ProductViewModel>> GetProductsAsync()
        {
            var result = await _productRepository.GetProductsAsync();
            return _mapper.Map<IEnumerable<ProductViewModel>>(result);
        }

        public async Task RemoveAsync(int? id)
        {
            var product = _productRepository.GetByIdAsync(id).Result;
            await _productRepository.RemoveAsync(product);
        }


        public async Task UpdateAsync(ProductViewModel product)
        {
            var mapProdutc = _mapper.Map<Produto>(product);
            await _productRepository.UpdateAsync(mapProdutc);
        }


    }
}
