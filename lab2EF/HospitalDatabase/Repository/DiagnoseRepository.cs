using HospitalDatabase.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDatabase.Repository
{
    public class DiagnoseRepository:IDiagnoseRepository
    {
        readonly HospitalContext _context;

        public DiagnoseRepository(HospitalContext context)
        {
            _context = context;
        }
    }
}
