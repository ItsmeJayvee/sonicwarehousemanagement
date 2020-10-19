using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SonicWarehouseManagement.Server.Migrations
{
    public partial class secondcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Purchase_Orders",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Site = table.Column<string>(maxLength: 100, nullable: true),
                    Posting_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Document_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Article_Doc = table.Column<string>(maxLength: 100, nullable: true),
                    Bill_Doc = table.Column<string>(maxLength: 100, nullable: true),
                    Item_Code = table.Column<string>(maxLength: 100, nullable: true),
                    Item_Desc = table.Column<string>(maxLength: 100, nullable: true),
                    Quantity = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchase_Orders", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Purchase_Orders");
        }
    }
}
