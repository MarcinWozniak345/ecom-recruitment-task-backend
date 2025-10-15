using AutoMapper;
using Backend.Application.Models;
using Backend.Domain.Entities;
using Backend.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Application.Services
{
    public class FootballerService : IFootballerService
    {
        private readonly IFootballerRepository _footballerRepository;
        private readonly IMapper _mapper;
        public FootballerService(IFootballerRepository footballerRepository, IMapper mapper)
        { 
            _footballerRepository = footballerRepository;
            _mapper = mapper;
        }

        public async Task CreateFootballer(CreateFootbalerDTO newFootballer)
        {
            var data = _mapper.Map<Domain.Entities.Footballer>(newFootballer);
            await _footballerRepository.CreateNewFootballer(data);
        }

        public async Task DeleteFootballer(Guid guid)
        {
            await _footballerRepository.DeleteFootballer(guid);
        }

        public List<FootballerDTO> GetAllFootballers()
        {
            var data = _footballerRepository.GetAllFootballers();
            var result = _mapper.Map<List<FootballerDTO>>(data);
            return result;
        }

        public FootballerDTO GetFootballer(Guid guid)
        {
            var data = _footballerRepository.GetFootballer(guid);
            var result = _mapper.Map<FootballerDTO>(data);
            return result;
        }

        public async Task UpdateFootballer(UpdateFootbalerDTO updatedFootballer)
        {
            var f = _mapper.Map<Domain.Entities.Footballer>(updatedFootballer);
            await _footballerRepository.UpdateFootballer(f);
        }
    }
}
