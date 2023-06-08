using BeautySalon.CA.Domain.Entities;
using BeautySalon_ADO.DAL.Models;
using BeautySalon_EF.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.CA.Application.Common.Interfaces
{
    public interface IBeautySalonContext
    {
        public DbSet<SalonCity>SalonCities { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Master> Masters { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public  DbSet<Reply> Replys { get; set; }
        public DbSet<ReplyProducts> ReplyProducts { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Ordeer> Ordeers { get; set; }
        public DbSet<CommentsProducts> CommentsProducts { get; set; }


        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
