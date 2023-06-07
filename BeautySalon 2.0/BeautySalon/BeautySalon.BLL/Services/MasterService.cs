using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeautySalon.BLL.DTO;
using BeautySalon.BLL.Services;
using BeautySalon.BLL.Services.Interfaces;
using BeautySalon_ADO.DAL.Models;
using BeautySalon_ADO.DAL.Repositories.Contracts;

namespace BeautySalon.BLL.Services
{
    public class MasterService:IMasterServices
    {

        IUnitOfWork _uow;

        public MasterService(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public async Task<int> CreateAsync(MasterDTO entity)
        {

            // Mapping without AutoMapper
            var id = await _uow._masterRepository.AddAsync(new Master
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
        public async Task<MasterDTO> GetAsync(int id)
        {
            var entity = await _uow._masterRepository.GetAsync(id);

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
            var list = await _uow._masterRepository.GetAllAsync();
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
            await _uow._masterRepository.ReplaceAsync(new Master
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
        public async Task DeleteAsync(int id)
        {
            await _uow._masterRepository.DeleteAsync(id);
            _uow.Commit();
        }

        public void Dispose()
        {
            _uow.Dispose();
        }
    }
}
