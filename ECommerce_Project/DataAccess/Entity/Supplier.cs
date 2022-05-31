﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace DataAccess.Entity
{
    public class Supplier:EntityRepository
    {
        public string CompanyName { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Adress { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}