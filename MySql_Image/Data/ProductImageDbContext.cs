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

     /*
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ProductImage>().HasKey(m => m.Id);

            //TODO: UpdateTimestamp code
             
            // shadow properties
            builder.Entity<DataEventRecord>().Property<DateTime>("UpdatedTimestamp");
            builder.Entity<SourceInfo>().Property<DateTime>("UpdatedTimestamp");
            
            base.OnModelCreating(builder);
        }
     */
   
       
    }
}
