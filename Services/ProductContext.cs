﻿using Microsoft.EntityFrameworkCore;
using ProductManagementSystem.Models;

namespace ProductManagementSystem.Services
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }

}
