using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MySql_Image.Migrations
{
    public partial class ProductDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<uint>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AdditionalCost = table.Column<byte>(nullable: false),
                    AiPartNumber = table.Column<string>(nullable: true),
                    AssociatedCategoryId = table.Column<uint>(nullable: true),
                    AssociatedGroupId = table.Column<uint>(nullable: true),
                    AssociatedImageId = table.Column<uint>(nullable: true),
                    AssociatedPrimaryVendorId = table.Column<uint>(nullable: true),
                    AssociatedRecycleId = table.Column<uint>(nullable: true),
                    AssociatedScreenId = table.Column<uint>(nullable: true),
                    AssociatedSecondaryVendorId = table.Column<uint>(nullable: true),
                    AssociatedSnapshotTypeId = table.Column<uint>(nullable: true),
                    AssociatedTertiaryVendorId = table.Column<uint>(nullable: true),
                    Cost = table.Column<double>(nullable: true),
                    CostVerificationBy = table.Column<int>(nullable: false),
                    DefaultPriority = table.Column<double>(nullable: true),
                    IsDiscontinued = table.Column<byte>(nullable: false),
                    IsExcludedDesAinumOverrwrite = table.Column<sbyte>(nullable: false),
                    IsRecycleFee = table.Column<byte>(nullable: false),
                    IsTaxable = table.Column<byte>(nullable: true),
                    ItemsAssociated = table.Column<string>(nullable: true),
                    ManufactureName = table.Column<string>(nullable: true),
                    ManufactureNumber = table.Column<string>(nullable: true),
                    MerchantNumber = table.Column<string>(nullable: true),
                    MfgManualUrl = table.Column<string>(nullable: true),
                    MfgUrl = table.Column<string>(nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    Retail = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
