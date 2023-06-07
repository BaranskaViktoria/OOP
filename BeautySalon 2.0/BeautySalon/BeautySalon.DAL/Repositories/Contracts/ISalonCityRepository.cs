using BeautySalon_ADO.DAL.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon_ADO.DAL.Repositories.Contracts
{
    public interface ISalonCityRepository : IGenericRepository<SalonCity>
    {
        Task<IEnumerable<SalonCity>> TopFiveSalonCityAsync();
    }
}
