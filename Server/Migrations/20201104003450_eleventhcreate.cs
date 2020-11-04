using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SonicWarehouseManagement.Server.Migrations
{
    public partial class eleventhcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: true),
                    Item_Code = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: true),
                    Transaction_Type = table.Column<string>(nullable: true),
                    Uom = table.Column<string>(nullable: true),
                    Warehouse = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Inventory_Details",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Header_Ref = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: true),
                    Transaction_Type = table.Column<string>(nullable: true),
                    Uom = table.Column<string>(nullable: true),
                    Warehouse = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory_Details", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Inventory_Headers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Item_Code = table.Column<string>(nullable: true),
                    Ref_ID = table.Column<string>(nullable: true),
                    Ref_Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory_Headers", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inventories");

            migrationBuilder.DropTable(
                name: "Inventory_Details");

            migrationBuilder.DropTable(
                name: "Inventory_Headers");
        }
    }
}
