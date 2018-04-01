using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySql_Image.Data
{
    public class ProductImageContext : DbContext
    {
        public ProductImageContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<ProductImageContext> ProductImages { get; set; }

        //TODO: UpdateTimestamp code
    }
}
