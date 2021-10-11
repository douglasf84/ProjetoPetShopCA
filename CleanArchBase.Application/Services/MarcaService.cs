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
    public class MarcaService : IMarcaService
    {
        private IMarcaRepository _marcaRepository;
        private readonly IMapper _mapper;

        public MarcaService(IMarcaRepository marcaRepository, IMapper mapper)
        {
            _marcaRepository = marcaRepository;
            _mapper = mapper;
        }

        public async Task CreateAsync(MarcaViewModel marca)
        {
            var mapObject = _mapper.Map<Marca>(marca);
            await _marcaRepository.CreateAsync(mapObject);
        }

        public async Task<IEnumerable<MarcaViewModel>> GetAllAsync()
        {
            var result = await _marcaRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<MarcaViewModel>>(result);
        }

        public async Task<MarcaViewModel> GetByIdAsync(int? id)
        {
            var result = await _marcaRepository.GetByIdAsync(id);
            return _mapper.Map<MarcaViewModel>(result);
        }

        public async Task RemoveAsync(int? id)
        {
            var objectRemove = _marcaRepository.GetByIdAsync(id).Result;
            await _marcaRepository.RemoveAsync(objectRemove);
        }

        public async Task UpdateAsync(MarcaViewModel marca)
        {
            var mapObject = _mapper.Map<Marca>(marca);
            await _marcaRepository.UpdateAsync(mapObject);
        }
    }
}
