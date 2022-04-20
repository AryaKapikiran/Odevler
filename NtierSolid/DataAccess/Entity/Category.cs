﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Category:BaseEntity
    {
        public int Id { get; set; }

        public string CategoryName { get; set; }

       public List<Product> Products { get; set; }
    }
}
