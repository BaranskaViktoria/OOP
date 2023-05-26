using System;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using System.Threading.Tasks;
using BeautySalon_Dapper.DAL.Entities;
using BeautySalon_Dapper.DAL.Repositories.Contracts;
using BeautySalon.BLL.DTO;
using BeautySalon.BLL.Services;
using BeautySalon.BLL.Services.Interfaces;
using BeautySalon_Dapper.DAL.Repositories.Contracts;
using static BeautySalon.BLL.Services.ServiceService;

namespace BeautySalon.BLL.Services
{
    public class ServiceService : IServiceService
    {
        public class ServiceService : IServiceService
        {
            IUnitOfWork _uow;

            public ServiceService(IUnitOfWork uow)
            {
                _uow = uow;
            }
            public async Task<Guid> CreateAsync(ServiceDTO entity)
            {
                // Mapping without AutoMapper
                var id = await _uow.Service.CreateAsync(new Service
                {
                    Id = entity.Id,
                    ServiceName = entity.ServiceName,
                    DescriptionServices = entity.DescriptionServices,
                    Price = entity.Price,
                });
                _uow.Commit();

                return id;
            }
            public async Task<ServiceDTO> GetAsync(Guid id)
            {
                var entity = await _uow.Services.GetByIdAsync(id);

                // Mapping without AutoMapper
                return new ServiceDTO
                {
                    Id = entity.Id,
                    ServiceName = entity.ServiceName,
                    DescriptionServices = entity.DescriptionServices,
                    Price = entity.Price,
                };
            }
            public async Task<IEnumerable<ServiceDTO>> GetAllAsync()
            {
                var list = await _uow.Service.GetAllAsync();
                var result = new List<ServiceDTO>();

                // Mapping without AutoMapper
                list.ToList().ForEach(entity => result.Add(new ServiceDTO
                {
                    Id = entity.Id,
                    ServiceName = entity.ServiceName,
                    DescriptionServices = entity.DescriptionServices,
                    Price = entity.Price,
                }));

                return result;
            }
            public async Task UpdateAsync(ServiceDTO entity)
            {
                // Mapping without AutoMapper
                await _uow.Service.UpdateAsync(new Service
                {
                    Id = entity.Id,
                    ServiceName = entity.ServiceName,
                    DescriptionServices = entity.DescriptionServices,
                    Price = entity.Price,
                });
                _uow.Commit();
            }
            public async Task DeleteAsync(Guid id)
            {
                await _uow.Service.DeleteAsync(id);
                _uow.Commit();
            }

            public void Dispose()
            {
                _uow.Dispose();
            }
        }
    }
}

