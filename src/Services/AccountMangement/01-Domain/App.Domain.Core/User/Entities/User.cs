﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.User.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string LastName { get; set; }
        public string PhoneNumber { get; set; } 

    }
}
