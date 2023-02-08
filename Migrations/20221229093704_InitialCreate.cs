using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PurchaseSystem.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    emp_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    emp_name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.emp_id);
                });

            migrationBuilder.CreateTable(
                name: "issuances",
                columns: table => new
                {
                    issuance_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    issuance_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    emp_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_issuances", x => x.issuance_id);
                });

            migrationBuilder.CreateTable(
                name: "items",
                columns: table => new
                {
                    item_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    item_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    item_status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_items", x => x.item_id);
                });

            migrationBuilder.CreateTable(
                name: "purchases",
                columns: table => new
                {
                    purchase_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    purchase_item = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    purchase_quantity = table.Column<int>(type: "int", nullable: false),
                    purchase_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false),
                    vendor = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_purchases", x => x.purchase_id);
                });

            migrationBuilder.CreateTable(
                name: "vendors",
                columns: table => new
                {
                    vendor_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vendor_name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vendors", x => x.vendor_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "issuances");

            migrationBuilder.DropTable(
                name: "items");

            migrationBuilder.DropTable(
                name: "purchases");

            migrationBuilder.DropTable(
                name: "vendors");
        }
    }
}
