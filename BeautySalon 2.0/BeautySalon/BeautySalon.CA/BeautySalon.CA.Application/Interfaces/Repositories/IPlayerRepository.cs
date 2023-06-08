using BeautySalon_ADO.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.CA.Application.Interfaces.Repositories
{
    public interface IPlayerRepository
    {
        Task<List<User>> GetPlayersByClubAsync(int Id);
    }
}
