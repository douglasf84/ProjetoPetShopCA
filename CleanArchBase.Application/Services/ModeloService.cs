using AutoMapper;
using CleanArchBase.Application.Interfaces;
using CleanArchBase.Application.ViewModels;
using CleanArchBase.Domain.Entities;
using CleanArchBase.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchBase.Application.Services
{
    public class ModeloService : IModeloService
    {
        private IModeloRepository _modeloRepository;
        private readonly IMapper _mapper;

        public ModeloService(IModeloRepository modeloRepository, IMapper mapper)
        {
            _modeloRepository = modeloRepository;
            _mapper = mapper;
        }

        public async Task CreateAsync(ModeloViewModel modelo)
        {
            var mapObject = _mapper.Map<Modelo>(modelo);
            await _modeloRepository.CreateAsync(mapObject);
        }

        public async Task<IEnumerable<ModeloViewModel>> GetAllAsync()
        {
            var result = await _modeloRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<ModeloViewModel>>(result);
        }

        public async Task<ModeloViewModel> GetByIdAsync(int? id)
        {
            var result = await _modeloRepository.GetByIdAsync(id);
            return _mapper.Map<ModeloViewModel>(result);
        }

        public async Task RemoveAsync(int? id)
        {
            var objectRemove = _modeloRepository.GetByIdAsync(id).Result;
            await _modeloRepository.RemoveAsync(objectRemove);
        }

        public async Task UpdateAsync(ModeloViewModel modelo)
        {
            var mapObject = _mapper.Map<Modelo>(modelo);
            await _modeloRepository.UpdateAsync(mapObject);
        }
    }
}
