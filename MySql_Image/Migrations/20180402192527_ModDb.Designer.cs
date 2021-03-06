﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using MySql_Image.Data;
using System;

namespace MySql_Image.Migrations
{
    [DbContext(typeof(ProductImageDbContext))]
    [Migration("20180402192527_ModDb")]
    partial class ModDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

            modelBuilder.Entity("MySql_Image.Data.Entities.ProductImage", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DateUpdated");

                    b.Property<string>("FileName")
                        .HasMaxLength(50);

                    b.Property<byte[]>("ImageFull")
                        .HasMaxLength(150000);

                    b.Property<byte[]>("ImageThumb")
                        .HasMaxLength(50000);

                    b.HasKey("Id");

                    b.ToTable("ProductImages");
                });
#pragma warning restore 612, 618
        }
    }
}
