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
                    Item_Number = table.Column<string>(nullable: true),
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inventories");
        }
    }
}
