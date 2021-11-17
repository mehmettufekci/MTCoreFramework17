using Microsoft.EntityFrameworkCore;
using MTFramework.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTFramework.DataAccess.Concrete.EntityFramework.Context
{
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
        }
        public DbSet<Product> Products { get; set; }
    }
}
