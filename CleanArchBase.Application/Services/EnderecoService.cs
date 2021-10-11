using AutoMapper;
using CleanArchBase.Application.Interfaces;
using CleanArchBase.Application.ViewModels;
using CleanArchBase.Domain.Entities;
using CleanArchBase.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchBase.Application.Services
{
    public class EnderecoService : IEnderecoService
    {
        private IEnderecoRepository _enderecoRepository;
        private readonly IMapper _mapper;

        public EnderecoService(IEnderecoRepository enderecoRepository, IMapper mapper)
        {
            _enderecoRepository = enderecoRepository;
            _mapper = mapper;
        }

        public async Task CreateAsync(EnderecoViewModel endereco)
        {
            var mapObject = _mapper.Map<Endereco>(endereco);
            await _enderecoRepository.CreateAsync(mapObject);
        }

        public async Task<IEnumerable<EnderecoViewModel>> GetAllAsync()
        {
            var result = await _enderecoRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<EnderecoViewModel>>(result);
        }

        public async Task<EnderecoViewModel> GetByIdAsync(int? id)
        {
            var result = await _enderecoRepository.GetByIdAsync(id);
            return _mapper.Map<EnderecoViewModel>(result);
        }

        public async Task RemoveAsync(int? id)
        {
            var objectRemove = _enderecoRepository.GetByIdAsync(id).Result;
            await _enderecoRepository.RemoveAsync(objectRemove);
        }

        public async Task UpdateAsync(EnderecoViewModel endereco)
        {
            var mapObject = _mapper.Map<Endereco>(endereco);
            await _enderecoRepository.UpdateAsync(mapObject);
        }
    }
}
