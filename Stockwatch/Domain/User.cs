﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class User
    {
        public int UserId { get; set; }
        public int PersonId { get; set; } 
        public string Username { get; set; }
        protected string Password { get; set; }

    }
}
