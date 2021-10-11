using AutoMapper;
using CleanArchBase.Application.Interfaces;
using CleanArchBase.Application.ViewModels;
using CleanArchBase.Domain.Entities;
using CleanArchBase.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchBase.Application.Services
{
    public class ClientePFService : IClientePFService
    {
        private IClientePFRepository _clientePFRepository;
        private readonly IMapper _mapper;

        public ClientePFService(IClientePFRepository clientePFRepository, IMapper mapper)
        {
            _clientePFRepository = clientePFRepository;
            _mapper = mapper;
        }

        public async Task CreateAsync(ClientePFViewModel ClientePF)
        {
            var mapObject = _mapper.Map<ClientePF>(ClientePF);
            await _clientePFRepository.CreateAsync(mapObject);
        }

        public async Task<IEnumerable<ClientePFViewModel>> GetASllsAsync()
        {
            var result = await _clientePFRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<ClientePFViewModel>>(result);
        }

        public async Task<ClientePFViewModel> GetByIdAsync(int? id)
        {
            var result = await _clientePFRepository.GetByIdAsync(id);
            return _mapper.Map<ClientePFViewModel>(result);
        }

        public async Task RemoveAsync(int? id)
        {
            var objectRemove = _clientePFRepository.GetByIdAsync(id).Result;
            await _clientePFRepository.RemoveAsync(objectRemove);
        }

        public async Task UpdateAsync(ClientePFViewModel clientePF)
        {
            var mapObject = _mapper.Map<ClientePF>(clientePF);
            await _clientePFRepository.UpdateAsync(mapObject);
        }
    }
}
