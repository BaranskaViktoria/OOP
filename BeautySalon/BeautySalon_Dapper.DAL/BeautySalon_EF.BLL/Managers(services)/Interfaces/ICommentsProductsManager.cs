using BeautySalon_EF.BLL.DTOs;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon_EF.BLL.Managers.Interfaces
{
    public interface ICommentsProductsManager
    {
        Task<CommentsProductsDTOs> CreatePost(CommentsProductsDTOs topic);
        Task<IEnumerable<CommentsProductsDTOs>> GetAllPosts(PageModel pagination);
        Task<CommentsProductsDTOs> GetPostById(int Id);
        Task<bool> UpdatePostById(CommentsProductsDTOs entity);
        Task<bool> DeletePostById(int Id);
        Task<List<CommentsProductsWithDto>> GetAllPostsWithTopics();
        Task<CommentsProductsWithDto?> GetPostByIdWithTopics(int Id);
    }
}
