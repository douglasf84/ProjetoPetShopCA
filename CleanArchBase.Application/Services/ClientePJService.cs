using AutoMapper;
using CleanArchBase.Application.Interfaces;
using CleanArchBase.Application.ViewModels;
using CleanArchBase.Domain.Entities;
using CleanArchBase.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchBase.Application.Services
{
    public class ClientePJService : IClientePJService
    {
        private IClientePJRepository _clientePJRepository;
        private readonly IMapper _mapper;

        public ClientePJService(IClientePJRepository clientePJRepository, IMapper mapper)
        {
            _clientePJRepository = clientePJRepository;
            _mapper = mapper;
        }

        public async Task CreateAsync(ClientePJViewModel clientePJ)
        {
            var mapObject = _mapper.Map<ClientePJ>(clientePJ);
            await _clientePJRepository.CreateAsync(mapObject);
        }

        public async Task<IEnumerable<ClientePJViewModel>> GetASllsAsync()
        {
            var result = await _clientePJRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<ClientePJViewModel>>(result);
        }

        public async Task<ClientePJViewModel> GetByIdAsync(int? id)
        {
            var result = await _clientePJRepository.GetByIdAsync(id);
            return _mapper.Map<ClientePJViewModel>(result);
        }

        public async Task RemoveAsync(int? id)
        {
            var objectRemove = _clientePJRepository.GetByIdAsync(id).Result;
            await _clientePJRepository.RemoveAsync(objectRemove);
        }

        public async Task UpdateAsync(ClientePJViewModel clientePJ)
        {
            var mapObject = _mapper.Map<ClientePJ>(clientePJ);
            await _clientePJRepository.UpdateAsync(mapObject);
        }
    }
}
