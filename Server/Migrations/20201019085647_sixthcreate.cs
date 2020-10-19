using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SonicWarehouseManagement.Server.Migrations
{
    public partial class sixthcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sales_Invoice",
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
                    Invoice_Due_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Purchase_Order_No = table.Column<string>(maxLength: 100, nullable: true),
                    Sales_Order_No = table.Column<string>(maxLength: 100, nullable: true),
                    Invoice_No = table.Column<string>(maxLength: 100, nullable: true),
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
                    table.PrimaryKey("PK_Sales_Invoice", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SalesInvoice_Details",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Header_ID = table.Column<int>(nullable: true),
                    Product_Id = table.Column<string>(nullable: true),
                    Product_Name = table.Column<string>(nullable: true),
                    Pack_Size = table.Column<string>(nullable: true),
                    Master_Brand = table.Column<string>(nullable: true),
                    Master_Brand_Name = table.Column<string>(nullable: true),
                    Master_Basepack = table.Column<string>(nullable: true),
                    Master_Basepack_Name = table.Column<string>(nullable: true),
                    Lead_Basepack = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_SalesInvoice_Details", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SalesInvoice_Headers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Distributor = table.Column<string>(nullable: true),
                    Distributor_Desc = table.Column<string>(nullable: true),
                    Site = table.Column<string>(nullable: true),
                    Site_Desc = table.Column<string>(nullable: true),
                    Sales_Route = table.Column<string>(nullable: true),
                    Route_Desc = table.Column<string>(nullable: true),
                    Outlet_Code = table.Column<int>(nullable: true),
                    Outlet_Name = table.Column<string>(nullable: true),
                    Master_FSS = table.Column<int>(nullable: true),
                    Master_FSS_Name = table.Column<string>(nullable: true),
                    Salesman_Team_Type = table.Column<string>(nullable: true),
                    Salesman_Team_Type_Desc = table.Column<string>(nullable: true),
                    Calendar_Day = table.Column<DateTime>(nullable: true),
                    Invoice_Due_Date = table.Column<DateTime>(nullable: true),
                    Purchase_Order_No = table.Column<string>(nullable: true),
                    Sales_Order_No = table.Column<string>(nullable: true),
                    Invoice_No = table.Column<string>(nullable: true),
                    Billing_Type = table.Column<string>(nullable: true),
                    Billing_Type_1 = table.Column<string>(nullable: true),
                    Terms_Of_Payment = table.Column<string>(nullable: true),
                    Master_Outlet_Subtype = table.Column<string>(nullable: true),
                    Master_Outlet_Subtype_Name = table.Column<string>(nullable: true),
                    Master_Outlet_City = table.Column<string>(nullable: true),
                    Master_Outlet_City_Name = table.Column<string>(nullable: true),
                    Salesman_Id = table.Column<int>(nullable: true),
                    Salesman_Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesInvoice_Headers", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sales_Invoice");

            migrationBuilder.DropTable(
                name: "SalesInvoice_Details");

            migrationBuilder.DropTable(
                name: "SalesInvoice_Headers");

            migrationBuilder.CreateTable(
                name: "Invoice_Details",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aggr_Pieces = table.Column<int>(type: "int", nullable: true),
                    Cabinet_Count = table.Column<int>(type: "int", nullable: true),
                    Coupon_Discount = table.Column<int>(type: "int", nullable: true),
                    DT_Discount = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    Free_Qty_Aggr_CS = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    Free_Qty_Aggr_PC = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    Free_Qty_CS = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    Free_Qty_Liter = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    Free_Qty_PC = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    GSV = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    Header_ID = table.Column<int>(type: "int", nullable: true),
                    Lead_Basepack = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Master_Basepack = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Master_Basepack_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Master_Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Master_Brand_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NIV = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    Pack_Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Product_Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Product_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sales_After = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    Sales_Qty_Aggr_CS = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    Sales_Qty_Aggr_PC = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    Sales_Qty_CS = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    Sales_Qty_Liter = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    Sales_Qty_PC = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    TPR = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    Total_Sales_Amnt_Inc = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    UW = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    VAT = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    Volume_Discount = table.Column<decimal>(type: "decimal(18, 4)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice_Details", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Invoice_Headers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Billing_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Billing_Type_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Calendar_Day = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Distributor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Distributor_Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Invoice_Due_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Invoice_No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Master_FSS = table.Column<int>(type: "int", nullable: true),
                    Master_FSS_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Master_Outlet_City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Master_Outlet_City_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Master_Outlet_Subtype = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Master_Outlet_Subtype_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Outlet_Code = table.Column<int>(type: "int", nullable: true),
                    Outlet_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Purchase_Order_No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Route_Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sales_Order_No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sales_Route = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salesman_Id = table.Column<int>(type: "int", nullable: true),
                    Salesman_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salesman_Team_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salesman_Team_Type_Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Site = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Site_Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Terms_Of_Payment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice_Headers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ISR_Daily_Sales_Invoices",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aggr_Pieces = table.Column<int>(type: "int", nullable: true),
                    Billing_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Billing_Type_1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Cabinet_Count = table.Column<int>(type: "int", nullable: true),
                    Calendar_Day = table.Column<DateTime>(type: "datetime", nullable: true),
                    Coupon_Discount = table.Column<int>(type: "int", nullable: true),
                    DT_Discount = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    Distributor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Distributor_Desc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Free_Qty_Aggr_CS = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    Free_Qty_Aggr_PC = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    Free_Qty_CS = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    Free_Qty_Liter = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    Free_Qty_PC = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    GSV = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    Invoice_Due_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Invoice_No = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Lead_Basepack = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Master_Basepack = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Master_Basepack_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Master_Brand = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Master_Brand_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Master_FSS = table.Column<int>(type: "int", nullable: true),
                    Master_FSS_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Master_Outlet_City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Master_Outlet_City_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Master_Outlet_Subtype = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Master_Outlet_Subtype_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NIV = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    Outlet_Code = table.Column<int>(type: "int", nullable: true),
                    Outlet_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Pack_Size = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Product_Id = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Product_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Purchase_Order_No = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Route_Desc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Sales_After = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    Sales_Order_No = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Sales_Qty_Aggr_CS = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    Sales_Qty_Aggr_PC = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    Sales_Qty_CS = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    Sales_Qty_Liter = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    Sales_Qty_PC = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    Sales_Route = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Salesman_Id = table.Column<int>(type: "int", nullable: true),
                    Salesman_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Salesman_Team_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Salesman_Team_Type_Desc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Site = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Site_Desc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TPR = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    Terms_Of_Payment = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Total_Sales_Amnt_Inc = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    UW = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    VAT = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    Volume_Discount = table.Column<decimal>(type: "decimal(18, 4)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ISR_Daily_Sales_Invoices", x => x.ID);
                });
        }
    }
}
