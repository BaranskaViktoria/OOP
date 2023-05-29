using BeautySalon_EF.BLL.DTOs;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon_EF.BLL.Managers.Interfaces
{
    public interface IProductManager
    {
        Task<ProductsDTOs> CreateTopic(ProductsDTOs topic);
        Task<IEnumerable<ProductsDTOs>> GetAllTopics(PageModel pagination);
        Task<ProductsDTOs> GetTopicById(int topicId);
        Task<bool> UpdateTopicById(ProductsDTOs entity);
        Task<bool> DeleteTopicById(int Id);

        Task<List<ProductWithTopicsDto>> GetAllTopicsWithPosts();
        Task<ProductWithTopicsDto?> GetTopicByIdWithPosts(int topicId);
    }
}
