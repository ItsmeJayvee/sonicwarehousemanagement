using Microsoft.EntityFrameworkCore.Migrations;

namespace SonicWarehouseManagement.Server.Migrations
{
    public partial class tenthcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SAP_SalesmanMasters",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Salesman_Code = table.Column<int>(nullable: false),
                    SAP_Salesman_Code = table.Column<int>(nullable: false),
                    Salesman_Customer_Code = table.Column<int>(nullable: false),
                    Route_Code = table.Column<string>(nullable: true),
                    SalesLoc = table.Column<string>(nullable: true),
                    GiftLoc = table.Column<string>(nullable: true),
                    DamageLoc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SAP_SalesmanMasters", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SAP_SalesmanMasters");
        }
    }
}
