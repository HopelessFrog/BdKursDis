﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BdKursDis.Model
{
    public  class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Password { get; set; }


        public bool IsOperator { get; set; }

        public bool IsCook { get; set; }
    }
}
