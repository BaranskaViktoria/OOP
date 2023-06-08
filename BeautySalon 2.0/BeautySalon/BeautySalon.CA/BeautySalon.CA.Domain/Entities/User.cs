using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon_ADO.DAL.Models
{
    public class User
    {
        public int Id{ get; set; }
        public string? UserFirstName { get; set; }
        public string? UserLastName { get; set; }
        public string? UserEmail { get; set; }
        public string? Paswordd { get; set; }
    }
}
