using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MySql_Image.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySql_Image.Data
{
    public class ProductImageDbContext : IdentityDbContext<ApplicationUser>
    {
        public ProductImageDbContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<ProductImage> ProductImages { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Customer> Customers { get; set; }
    }
}
