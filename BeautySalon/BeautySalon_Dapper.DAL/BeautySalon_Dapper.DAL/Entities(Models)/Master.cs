﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon_Dapper.DAL.Entities_Models_
{ 
    public class Master
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MastersType { get; set; }
        public int ServiceID { get; set; }
        public int SalonID { get; set; }
    }
}