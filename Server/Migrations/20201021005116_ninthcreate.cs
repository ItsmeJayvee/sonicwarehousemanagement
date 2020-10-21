using Microsoft.EntityFrameworkCore.Migrations;

namespace SonicWarehouseManagement.Server.Migrations
{
    public partial class ninthcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Business_Units",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Business_Unit = table.Column<string>(nullable: true),
                    Site = table.Column<string>(nullable: true),
                    Product = table.Column<string>(nullable: true),
                    Group_Code = table.Column<string>(nullable: true),
                    Cost_Center = table.Column<string>(nullable: true)
                }, 
                constraints: table =>
                {
                    table.PrimaryKey("PK_Business_Units", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Business_Units");
        }
    }
}
