using BeautySalon_Dapper.DAL.Entities;
using BeautySalon_Dapper.DAL.Entities_Models_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon_Dapper.DAL.Repositories.Contracts
{
    public interface ISalonCityRepository : IGenericRepository<SalonCity>
    {
        Task<IEnumerable<SalonCityRepository>> TopFiveMasterAsync();
    }
}
