using Microsoft.EntityFrameworkCore;
using MySql_Image.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySql_Image.Data
{
    public class ProductImageDbContext : DbContext
    {
        public ProductImageDbContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<ProductImage> ProductImages { get; set; }
    }
}
