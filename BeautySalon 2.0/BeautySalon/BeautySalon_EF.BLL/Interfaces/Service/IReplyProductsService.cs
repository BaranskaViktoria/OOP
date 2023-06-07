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
    public interface IReplyProductsService
    {
        Task<ReplyProductsDTOs> CreatePost(ReplyProductsDTOs topic);
        Task<IEnumerable<ReplyProductsDTOs>> GetAllPosts(PageModel pagination);
        Task<ReplyProductsDTOs> GetPostById(int Id);
        Task<bool> UpdatePostById(ReplyProductsDTOs entity);
        Task<bool> DeletePostById(int postId);
        Task<List<ReplyProductsResponse>> GetAllPostsWithTopics();
        Task<ReplyProductsResponse?> GetPostByIdWithTopics(int Id);
    }
}
