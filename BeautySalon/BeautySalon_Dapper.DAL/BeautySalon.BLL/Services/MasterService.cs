using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeautySalon_Dapper.DAL.Entities;
using BeautySalon_Dapper.DAL.Repositories.Contracts;
using BeautySalon.BLL.DTO;
using BeautySalon.BLL.Services;
using BeautySalon.BLL.Services.Interfaces;
using BeautySalon_Dapper.DAL.Entities_Models_;

namespace BeautySalon.BLL.Services
{
    public class MasterService:IMasterServices
    {

        IUnitOfWork _uow;

        public MasterService(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public async Task<Guid> CreateAsync(MasterDTO entity)
        {
            // Mapping without AutoMapper
            var id = await _uow.Master.CreateAsync(new Master
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                MastersType = entity.MastersType,
                ServiceID = entity.ServiceID,
                SalonID = entity.SalonID,
            });
            _uow.Commit();

            return id;
        }
        public async Task<MasterDTO> GetAsync(Guid id)
        {
            var entity = await _uow.Master.GetByIdAsync(id);

            // Mapping without AutoMapper
            return new MasterDTO
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                MastersType = entity.MastersType,
                ServiceID = entity.ServiceID,
                SalonID = entity.SalonID,
            };
        }
        public async Task<IEnumerable<MasterDTO>> GetAllAsync()
        {
            var list = await _uow.Master.GetAllAsync();
            var result = new List<MasterDTO>();

            // Mapping without AutoMapper
            list.ToList().ForEach(entity => result.Add(new MasterDTO
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                MastersType = entity.MastersType,
                ServiceID = entity.ServiceID,
                SalonID = entity.SalonID,
            }));

            return result;
        }
        public async Task UpdateAsync(MasterDTO entity)
        {
            // Mapping without AutoMapper
            await _uow.Master.UpdateAsync(new Master
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                MastersType = entity.MastersType,
                ServiceID = entity.ServiceID,
                SalonID = entity.SalonID,
            });
            _uow.Commit();
        }
        public async Task DeleteAsync(Guid id)
        {
            await _uow.Master.DeleteAsync(id);
            _uow.Commit();
        }

        public void Dispose()
        {
            _uow.Dispose();
        }
    }
}
