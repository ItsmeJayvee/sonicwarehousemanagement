using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SonicWarehouseManagement.Server.Migrations
{
    public partial class thirdcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Purchase_Details",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Header_ID = table.Column<int>(nullable: true),
                    Site = table.Column<string>(maxLength: 100, nullable: true),
                    Posting_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Document_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Item_Code = table.Column<string>(maxLength: 100, nullable: true),
                    Item_Desc = table.Column<string>(maxLength: 100, nullable: true),
                    Quantity = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchase_Details", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Purchase_Headers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Article_Doc = table.Column<string>(maxLength: 100, nullable: true),
                    Bill_Doc = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchase_Headers", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Purchase_Details");

            migrationBuilder.DropTable(
                name: "Purchase_Headers");
        }
    }
}
