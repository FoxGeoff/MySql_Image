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
    [Migration("20180408005202_ProductDb")]
    partial class ProductDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

            modelBuilder.Entity("MySql_Image.Data.Entities.Product", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<byte>("AdditionalCost");

                    b.Property<string>("AiPartNumber");

                    b.Property<uint?>("AssociatedCategoryId");

                    b.Property<uint?>("AssociatedGroupId");

                    b.Property<uint?>("AssociatedImageId");

                    b.Property<uint?>("AssociatedPrimaryVendorId");

                    b.Property<uint?>("AssociatedRecycleId");

                    b.Property<uint?>("AssociatedScreenId");

                    b.Property<uint?>("AssociatedSecondaryVendorId");

                    b.Property<uint?>("AssociatedSnapshotTypeId");

                    b.Property<uint?>("AssociatedTertiaryVendorId");

                    b.Property<double?>("Cost");

                    b.Property<int>("CostVerificationBy");

                    b.Property<double?>("DefaultPriority");

                    b.Property<byte>("IsDiscontinued");

                    b.Property<sbyte>("IsExcludedDesAinumOverrwrite");

                    b.Property<byte>("IsRecycleFee");

                    b.Property<byte?>("IsTaxable");

                    b.Property<string>("ItemsAssociated");

                    b.Property<string>("ManufactureName");

                    b.Property<string>("ManufactureNumber");

                    b.Property<string>("MerchantNumber");

                    b.Property<string>("MfgManualUrl");

                    b.Property<string>("MfgUrl");

                    b.Property<string>("ProductDescription");

                    b.Property<double?>("Retail");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

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
