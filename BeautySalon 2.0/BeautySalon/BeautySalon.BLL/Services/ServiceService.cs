using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeautySalon.BLL.DTO;
using BeautySalon.BLL.Services;
using BeautySalon.BLL.Services.Interfaces;
using static BeautySalon.BLL.Services.ServiceService;
using BeautySalon_ADO.DAL.Repositories.Contracts;
using BeautySalon_ADO.DAL.Models;

namespace BeautySalon.BLL.Services
{
    public class ServiceService : IServiceService
    {
      
            IUnitOfWork _uow;

            public ServiceService(IUnitOfWork uow)
            {
                _uow = uow;
            }
            public async Task<int> CreateAsync(ServiceDTO entity)
            {
                // Mapping without AutoMapper
                var id = await _uow._serviceRepository.AddAsync(new Service
                {
                    Id = entity.Id,
                    ServiceName = entity.ServiceName,
                    DescriptionServices = entity.DescriptionServices,
                    Price = entity.Price,
                });
                _uow.Commit();

                return id;
            }
            public async Task<ServiceDTO> GetAsync(int id)
            {
                var entity = await _uow._serviceRepository.GetAsync(id);

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
                var list = await _uow._serviceRepository.GetAllAsync();
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
                await _uow._serviceRepository.ReplaceAsync(new ()
                {
                    Id = entity.Id,
                    ServiceName = entity.ServiceName,
                    DescriptionServices = entity.DescriptionServices,
                    Price = entity.Price,
                });
                _uow.Commit();
            }
            public async Task DeleteAsync(int id)
            {
                await _uow._serviceRepository.DeleteAsync(id);
                _uow.Commit();
            }

            public void Dispose()
            {
                _uow.Dispose();
            }
        }
    
}

