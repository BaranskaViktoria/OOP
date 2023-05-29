using BeautySalon.BLL.DTO;
using BeautySalon.BLL.Services.Interfaces;
using BeautySalon_Dapper.DAL.Entities_Models_;
using BeautySalon_Dapper.DAL.Repositories.Contracts;
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
        public async Task<Guid> CreateAsync(SalonCityDTO entity)
        {
            // Mapping without AutoMapper
            var id = await _uow.SalonCity.CreateAsync(new Master
            {
                Id = entity.Id,
                CitySalon = entity.CitySalon,

            });
            _uow.Commit();

            return id;
        }
        public async Task<SalonCityDTO> GetAsync(Guid id)
        {
            var entity = await _uow.SalonCity.GetByIdAsync(id);

            // Mapping without AutoMapper
            return new MasterDTO
            {
                Id = entity.Id,
                CitySalon = entity.CitySalon,
            };
        }
        public async Task<IEnumerable<SalonCityDTO>> GetAllAsync()
        {
            var list = await _uow.SalonCity.GetAllAsync();
            var result = new List<SalonCityDTO>();

            // Mapping without AutoMapper
            list.ToList().ForEach(entity => result.Add(new MasterDTO
            {
                Id = entity.Id,
                CitySalon = entity.CitySalon,

            }));

            return result;
        }
        public async Task UpdateAsync(SalonCityDTO entity)
        {
            // Mapping without AutoMapper
            await _uow.SalonCity.UpdateAsync(new Master
            {
                Id = entity.Id,
                CitySalon = entity.CitySalon,

            });
            _uow.Commit();
        }
        public async Task DeleteAsync(Guid id)
        {
            await _uow.SalonCity.DeleteAsync(id);
            _uow.Commit();
        }

        public void Dispose()
        {
            _uow.Dispose();
        }
    }
}
