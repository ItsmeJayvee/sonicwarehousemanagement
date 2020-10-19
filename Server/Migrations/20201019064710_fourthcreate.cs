using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SonicWarehouseManagement.Server.Migrations
{
    public partial class fourthcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sales_Orders",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Route_No = table.Column<string>(nullable: true),
                    Order_Type = table.Column<string>(nullable: true),
                    Order_Number = table.Column<string>(nullable: true),
                    SO_Date = table.Column<DateTime>(nullable: false),
                    Outlet_Code = table.Column<string>(nullable: true),
                    Outlet_Name = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Delivery_N = table.Column<string>(nullable: true),
                    Material_N = table.Column<string>(nullable: true),
                    Article_Description = table.Column<string>(nullable: true),
                    Pack_Size = table.Column<string>(nullable: true),
                    Cases = table.Column<string>(nullable: true),
                    Pieces = table.Column<string>(nullable: true),
                    Free_Cases = table.Column<string>(nullable: true),
                    Free_Piece = table.Column<string>(nullable: true),
                    Delivery_Qty_CS = table.Column<string>(nullable: true),
                    Delivery_Qty_PC = table.Column<string>(nullable: true),
                    Sales_Value = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    VAT_Value = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    Net_Sales = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    Item_Number = table.Column<string>(nullable: true),
                    Route_Type = table.Column<string>(nullable: true),
                    Salesman_Name = table.Column<string>(nullable: true),
                    Terms_of_payment = table.Column<string>(nullable: true),
                    Delivery_Free_Qty_CS = table.Column<string>(nullable: true),
                    Turnover_Value = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    Delivery_Free_Qty_PC = table.Column<string>(nullable: true),
                    Document_Category = table.Column<string>(nullable: true),
                    Salesman = table.Column<string>(nullable: true),
                    Order_Type_Desc = table.Column<string>(nullable: true),
                    Cases_Pieces = table.Column<string>(nullable: true),
                    Free_CS_PS = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales_Orders", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sales_Orders");
        }
    }
}
