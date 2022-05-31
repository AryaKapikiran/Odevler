﻿using Core.Map;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Map
{
    public class ProductMap:CoreMap<Product>
    {
        public ProductMap()
        {
            ToTable("dbo.Products");

            Property(x => x.ProductImagePath).IsOptional();

            Property(x => x.ProductName).IsRequired().HasMaxLength(255);

           


        }
    }
}