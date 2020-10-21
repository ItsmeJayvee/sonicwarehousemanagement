using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SonicWarehouseManagement.Server.Migrations
{
    public partial class eighthcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Delivery_Receipts",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Distributor = table.Column<string>(maxLength: 100, nullable: true),
                    Distributor_Desc = table.Column<string>(maxLength: 100, nullable: true),
                    Site = table.Column<string>(maxLength: 100, nullable: true),
                    Site_Desc = table.Column<string>(maxLength: 100, nullable: true),
                    Sales_Route = table.Column<string>(maxLength: 100, nullable: true),
                    Route_Desc = table.Column<string>(maxLength: 100, nullable: true),
                    Outlet_Code = table.Column<int>(nullable: true),
                    Outlet_Name = table.Column<string>(maxLength: 100, nullable: true),
                    Master_FSS = table.Column<int>(nullable: true),
                    Master_FSS_Name = table.Column<string>(maxLength: 100, nullable: true),
                    Salesman_Team_Type = table.Column<string>(maxLength: 100, nullable: true),
                    Salesman_Team_Type_Desc = table.Column<string>(maxLength: 100, nullable: true),
                    Calendar_Day = table.Column<DateTime>(type: "datetime", nullable: true),
                    Delivery_Due_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Purchase_Order_No = table.Column<string>(maxLength: 100, nullable: true),
                    Sales_Order_No = table.Column<string>(maxLength: 100, nullable: true),
                    Delivery_Receipt_No = table.Column<string>(maxLength: 100, nullable: true),
                    Billing_Type = table.Column<string>(maxLength: 100, nullable: true),
                    Billing_Type_1 = table.Column<string>(maxLength: 100, nullable: true),
                    Terms_Of_Payment = table.Column<string>(maxLength: 100, nullable: true),
                    Master_Outlet_Subtype = table.Column<string>(maxLength: 100, nullable: true),
                    Master_Outlet_Subtype_Name = table.Column<string>(maxLength: 100, nullable: true),
                    Master_Outlet_City = table.Column<string>(maxLength: 100, nullable: true),
                    Master_Outlet_City_Name = table.Column<string>(maxLength: 100, nullable: true),
                    Product_Id = table.Column<string>(maxLength: 100, nullable: true),
                    Product_Name = table.Column<string>(maxLength: 100, nullable: true),
                    Pack_Size = table.Column<string>(maxLength: 100, nullable: true),
                    Master_Brand = table.Column<string>(maxLength: 100, nullable: true),
                    Master_Brand_Name = table.Column<string>(maxLength: 100, nullable: true),
                    Master_Basepack = table.Column<string>(maxLength: 100, nullable: true),
                    Master_Basepack_Name = table.Column<string>(maxLength: 100, nullable: true),
                    Lead_Basepack = table.Column<string>(maxLength: 100, nullable: true),
                    Salesman_Id = table.Column<int>(nullable: true),
                    Salesman_Name = table.Column<string>(maxLength: 100, nullable: true),
                    Sales_Qty_CS = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    Sales_Qty_PC = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    Free_Qty_CS = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    Free_Qty_PC = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    Sales_Qty_Liter = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    Free_Qty_Liter = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    Sales_Qty_Aggr_CS = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    Sales_Qty_Aggr_PC = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    Free_Qty_Aggr_CS = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    Free_Qty_Aggr_PC = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    GSV = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    TPR = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    UW = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    DT_Discount = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    Sales_After = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    Volume_Discount = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    Coupon_Discount = table.Column<int>(nullable: true),
                    NIV = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    VAT = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    Total_Sales_Amnt_Inc = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    Aggr_Pieces = table.Column<int>(nullable: true),
                    Cabinet_Count = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Delivery_Receipts", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Delivery_Receipts");
        }
    }
}
