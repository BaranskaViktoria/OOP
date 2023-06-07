using BeautySalon_EF.BLL.DTOs;
using BeautySalon_EF.BLL.DTOs.Responses;
using BeautySalon_EF.DAL.Data.Repositories;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Update.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon_EF.BLL.Interfaces.Service
{
    public interface ICommentsProductsService
    {
        Task<CommentsProductsDTOs> CreatePost(CommentsProductsDTOs topic);
        Task<IEnumerable<CommentsProductsDTOs>> GetAllPosts(PageModel pagination);
        Task<CommentsProductsDTOs> GetPostById(int Id);
        Task<bool> UpdatePostById(CommentsProductsDTOs entity);
        Task<bool> DeletePostById(int Id);
        Task<List<CommentsProductsResponse>> GetAllPostsWithTopics();
        Task<CommentsProductsResponse?> GetPostByIdWithTopics(int Id);
    }
    
}
