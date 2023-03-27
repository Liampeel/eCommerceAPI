using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Data.Context
{
    public class ECommerceContext : DbContext
    {
        public ECommerceContext(DbContextOptions<ECommerceContext> options) : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}

