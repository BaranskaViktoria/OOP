
using AutoMapper;
using BeautySalon_EF.BLL.DTOs;
using BeautySalon_EF.BLL.DTOs.Responses;
using BeautySalon_EF.BLL.Interfaces;
using BeautySalon_EF.BLL.Interfaces.Service;
using BeautySalon_EF.DAL.Entities;
using BeautySalon_EF.DAL.Interfaces.Repositories;
using BeautySalon_EF.DAL.Pagination;
using BeautySalon_EF.DAL.Parameters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Sockets;

namespace BeautySalon_EF.BLL.Managers
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork unitOfWork;

        private readonly IMapper mapper;
        private readonly IProductsRepository productsRepository;

        public Task<ProductsDTOs> CreateTopic(ProductsDTOs topic)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteTopicById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductsDTOs>> GetAllTopics(PageModel pagination)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductResponse>> GetAllTopicsWithPosts()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductResponse>> GetAsync()
        {
            var products = await productsRepository.GetAsync();
            return products?.Select(mapper.Map<Products, ProductResponse>);
        }

        public async Task<PagedList<ProductResponse>> GetAsync(
            ProductsParameters parameters)
        {
            var products = await productsRepository.GetAsync(parameters);
            return products?.Map(mapper.Map<Products, ProductResponse>);
        }

        public async Task<ProductResponse> GetByIdAsync(int id)
        {
            var products = await productsRepository.GetCompleteEntityAsync(id);
            return mapper.Map<Products, ProductResponse>(products);
        }

        public Task<ProductsDTOs> GetTopicById(int topicId)
        {
            throw new NotImplementedException();
        }

        public Task<ProductResponse?> GetTopicByIdWithPosts(int topicId)
        {
            throw new NotImplementedException();
        }

        public async Task InsertAsync(ProductResponse responses)
        {
            var products = mapper.Map<ProductResponse, Products>(responses);
            await productsRepository.InsertAsync(products);
            await unitOfWork.SaveChangesAsync();
        }

        public Task<bool> UpdateTopicById(ProductsDTOs entity)
        {
            throw new NotImplementedException();
        }
    }
}
