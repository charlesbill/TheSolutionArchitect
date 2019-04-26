using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using test_mvc_webapp.Models;

namespace test_mvc_webapp.Data
{
    public class MvcWebAppDbContext : DbContext
    {
        public MvcWebAppDbContext(DbContextOptions<MvcWebAppDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<Product> Products { get; set;}
    }
}