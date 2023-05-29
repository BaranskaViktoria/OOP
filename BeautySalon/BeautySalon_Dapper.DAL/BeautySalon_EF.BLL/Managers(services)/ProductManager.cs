using AutoMapper;
using BeautySalon_Dapper.DAL.Entities_Models_;
using BeautySalon_Dapper.DAL.Repositories.Contracts;
using BeautySalon_EF.BLL.DTOs;
using BeautySalon_EF.BLL.Managers.Interfaces;
using BeautySalon_EF.DAL.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon_EF.BLL.Managers
{
    public class ProductManager : IProductManager
    {
        private readonly IUnitOfWork _uow;

        public ProductManager(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<Guid> CreateAsync(ProductsDTOs entity)
        {
            Products products = MappingFunctions.MapSourceToDestination<ProductsDTOs, Products>(entity);

            var id = await _uow.Products.CreateAsync(products);
            await _uow.SaveChangesAsync();

            return id;
        }
        public async Task<IEnumerable<ProductsDTOs>> GetAllAsync(BaseParameters parameters)
        {
            // Use Mapster to project one collection onto another
            return MappingFunctions.MapListSourceToDestination<Products, ProductsDTOs>
                (await _uow.Products.GetAllAsync(parameters));
        }

        public async Task<ProductsDTOs?> GetAsync(Guid id)
        {
  
            Products? products = await _uow.Producrs.GetByIdAsync(id);

            
            ProductsDTOs? bookDTO =
            
                products == null ?
                null : MappingFunctions.MapSourceToDestination<Products, ProductsDTOs>(products);

            return bookDTO;
        }
        public async Task UpdateAsync(ProductsDTOs entity)
        {
           
            Products products = MappingFunctions.MapSourceToDestination<ProductsDTOs, Products>(entity);

            await _uow.Products.UpdateAsync(book);
            await _uow.SaveChangesAsync();
        }
        public async Task DeleteAsync(Guid id)
        {
            await _uow.Products.DeleteAsync(id);
            await _uow.SaveChangesAsync();
        }
    }
}
