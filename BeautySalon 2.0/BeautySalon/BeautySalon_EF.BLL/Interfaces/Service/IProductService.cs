using BeautySalon_EF.BLL.DTOs;
using BeautySalon_EF.BLL.DTOs.Responses;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon_EF.BLL.Interfaces.Service
{
    public interface IProductService
    {
        Task<ProductsDTOs> CreateTopic(ProductsDTOs topic);
        Task<IEnumerable<ProductsDTOs>> GetAllTopics(PageModel pagination);
        Task<ProductsDTOs> GetTopicById(int topicId);
        Task<bool> UpdateTopicById(ProductsDTOs entity);
        Task<bool> DeleteTopicById(int Id);

        Task<List<ProductResponse>> GetAllTopicsWithPosts();
        Task<ProductResponse?> GetTopicByIdWithPosts(int topicId);
    }
}
