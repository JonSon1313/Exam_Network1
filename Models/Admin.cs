﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Admin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname {  get; set; }
        
        public string Login { get; set; }
        public string Password { get; set; }    
    }
}
