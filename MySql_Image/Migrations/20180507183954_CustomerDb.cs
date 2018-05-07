using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MySql_Image.Migrations
{
    public partial class CustomerDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<uint>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: true),
                    Address2 = table.Column<string>(nullable: true),
                    AssociatedCustomerId = table.Column<uint>(nullable: true),
                    AssociatedEmployeeId = table.Column<uint>(nullable: true),
                    AssociatedLocation = table.Column<uint>(nullable: true),
                    BillAddress = table.Column<string>(nullable: true),
                    BillAddress2 = table.Column<string>(nullable: true),
                    BillAddressDifferent = table.Column<sbyte>(nullable: false),
                    BillCity = table.Column<string>(nullable: true),
                    BillState = table.Column<string>(nullable: true),
                    BillZipCode = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    Email1 = table.Column<string>(nullable: true),
                    Email2 = table.Column<string>(nullable: true),
                    Email3 = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    GateCode = table.Column<string>(nullable: true),
                    IsNotExportedContact = table.Column<byte>(nullable: false),
                    IsRegisteredToC4 = table.Column<byte>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    Latitude = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    Password = table.Column<byte[]>(nullable: true),
                    Phone1Description = table.Column<string>(nullable: true),
                    Phone1Extension = table.Column<string>(nullable: true),
                    Phone1Value = table.Column<string>(nullable: true),
                    Phone2Description = table.Column<string>(nullable: true),
                    Phone2Extension = table.Column<string>(nullable: true),
                    Phone2Value = table.Column<string>(nullable: true),
                    Phone3Description = table.Column<string>(nullable: true),
                    Phone3Extension = table.Column<string>(nullable: true),
                    Phone3Value = table.Column<string>(nullable: true),
                    SmallNote = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    TaxId = table.Column<string>(nullable: true),
                    TaxIdImage = table.Column<byte[]>(nullable: true),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_UserId",
                table: "Customers",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
