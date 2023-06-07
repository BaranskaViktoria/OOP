using BeautySalon.BLL.DTO;
using BeautySalon.BLL.Services.Interfaces;
using BeautySalon_ADO.DAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.BLL.Services
{
    public class SalonCityService :ISalonCityServices
    {
        IUnitOfWork _uow;

        public SalonCityService(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public async Task<int> CreateAsync(SalonCityDTO entity)
        {
            // Mapping without AutoMapper
            var id = await _uow._saloncityRepository.AddAsync(new ()
            {
                Id = entity.Id,
                CitySalon = entity.CitySalon,

            });
            _uow.Commit();

            return id;
        }
        public async Task<SalonCityDTO> GetAsync(int id)
        {
            var entity = await _uow._saloncityRepository.GetAsync(id);

            // Mapping without AutoMapper
            return new SalonCityDTO
            {
                Id = entity.Id,
                CitySalon = entity.CitySalon,
            };
        }
        public async Task<IEnumerable<SalonCityDTO>> GetAllAsync()
        {
            var list = await _uow._saloncityRepository.GetAllAsync();
            var result = new List<SalonCityDTO>();

            // Mapping without AutoMapper
            list.ToList().ForEach(entity => result.Add(new SalonCityDTO
            {
                Id = entity.Id,
                CitySalon = entity.CitySalon,

            }));

            return result;
        }
        public async Task UpdateAsync(SalonCityDTO entity)
        {
            // Mapping without AutoMapper
            await _uow._saloncityRepository.ReplaceAsync(new ()
            {
                Id = entity.Id,
                CitySalon = entity.CitySalon,

            });
            _uow.Commit();
        }
        public async Task DeleteAsync(int id)
        {
            await _uow._saloncityRepository.DeleteAsync(id);
            _uow.Commit();
        }

        public void Dispose()
        {
            _uow.Dispose();
        }
    }
}
