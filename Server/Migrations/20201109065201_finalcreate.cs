using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace SonicWarehouseManagement.Server.Migrations
{
    public partial class finalcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Article_Masters",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Article_Code = table.Column<string>(nullable: true),
                    Article_Description = table.Column<string>(nullable: true),
                    Primary_Price_CS = table.Column<string>(nullable: true),
                    Secondary_Price_CS = table.Column<string>(nullable: true),
                    Article_Short_Description = table.Column<string>(nullable: true),
                    Unit_Conversion2 = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Site = table.Column<string>(nullable: true),
                    Uom2 = table.Column<string>(nullable: true),
                    Uom3 = table.Column<string>(nullable: true),
                    Volume_CS = table.Column<string>(nullable: true),
                    Volume_CS_L = table.Column<string>(nullable: true),
                    Volume_PC = table.Column<string>(nullable: true),
                    Volume_PC_L = table.Column<string>(nullable: true),
                    Width_CS = table.Column<string>(nullable: true),
                    Width_PC = table.Column<string>(nullable: true),
                    Base_Unit_of_Measure = table.Column<string>(nullable: true),
                    Uom1 = table.Column<string>(nullable: true),
                    Unit_Conversion1 = table.Column<string>(nullable: true),
                    Unit_Conversion3 = table.Column<string>(nullable: true),
                    Merchandise_Category = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Division = table.Column<string>(nullable: true),
                    Assortment_No = table.Column<string>(nullable: true),
                    Listing_Module = table.Column<string>(nullable: true),
                    Assortment_status = table.Column<string>(nullable: true),
                    Gross_Weight_PC = table.Column<string>(nullable: true),
                    Net_Weight_PC = table.Column<string>(nullable: true),
                    Gross_Weight_CS = table.Column<string>(nullable: true),
                    Net_Weight_CS = table.Column<string>(nullable: true),
                    Length_PC = table.Column<string>(nullable: true),
                    Height_PC = table.Column<string>(nullable: true),
                    Length_CS = table.Column<string>(nullable: true),
                    Height_CS = table.Column<string>(nullable: true),
                    Updated_Date = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Article_Masters", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Business_Partners",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Card_Code = table.Column<string>(nullable: true),
                    Card_Name = table.Column<string>(nullable: true),
                    Card_Type = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    PJP = table.Column<string>(nullable: true),
                    Salesman = table.Column<string>(nullable: true),
                    Salesman_Name = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    Street_2 = table.Column<string>(nullable: true),
                    Street_3 = table.Column<string>(nullable: true),
                    Outlet_Type = table.Column<string>(nullable: true),
                    Outlet_Type_Description = table.Column<string>(nullable: true),
                    Outlet_Sub_Type = table.Column<string>(nullable: true),
                    Outlet_Sub_Type_Description = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    Payment_Type_Description = table.Column<string>(nullable: true),
                    Terms_of_Payment = table.Column<string>(nullable: true),
                    Terms_of_Payment_Description = table.Column<string>(nullable: true),
                    Postal_Code = table.Column<string>(nullable: true),
                    VAT_Number = table.Column<string>(nullable: true),
                    Contact_Person = table.Column<string>(nullable: true),
                    Classification = table.Column<string>(nullable: true),
                    Classification_Description = table.Column<string>(nullable: true),
                    Delivering_Site = table.Column<string>(nullable: true),
                    Delivering_Site_Description = table.Column<string>(nullable: true),
                    Lead_Time = table.Column<string>(nullable: true),
                    MAG_Description = table.Column<string>(nullable: true),
                    LSR_Level_Description = table.Column<string>(nullable: true),
                    LSR_Province_Description = table.Column<string>(nullable: true),
                    LSR_City_Description = table.Column<string>(nullable: true),
                    LSR_Barangay_Description = table.Column<string>(nullable: true),
                    Deactivation_date = table.Column<DateTime>(type: "date", nullable: true),
                    Changed_date = table.Column<DateTime>(type: "date", nullable: true),
                    Payment_Type = table.Column<string>(nullable: true),
                    Latitude = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true),
                    Banner_ID_Description = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Fax = table.Column<string>(nullable: true),
                    House_Number = table.Column<string>(nullable: true),
                    Name2 = table.Column<string>(nullable: true),
                    Name3 = table.Column<string>(nullable: true),
                    Outlet_Location = table.Column<string>(nullable: true),
                    Search_Term1 = table.Column<string>(nullable: true),
                    Search_Term2 = table.Column<string>(nullable: true),
                    Tax1 = table.Column<string>(nullable: true),
                    Created_On = table.Column<DateTime>(type: "date", nullable: true),
                    Perfect_Store_Audit_Type = table.Column<string>(nullable: true),
                    eRTM = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Business_Partners", x => x.Id);
                });

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
                    Calendar_Day = table.Column<DateTime>(type: "date", nullable: true),
                    Delivery_Due_Date = table.Column<DateTime>(type: "date", nullable: true),
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

            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "date", nullable: true),
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
                    Date = table.Column<DateTime>(type: "date", nullable: true),
                    Item_Code = table.Column<string>(nullable: true),
                    Ref_ID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory_Headers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalesLocation = table.Column<string>(nullable: true),
                    GiftLocation = table.Column<string>(nullable: true),
                    DamageLocation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Purchase_Details",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Header_ID = table.Column<int>(nullable: true),
                    Site = table.Column<string>(maxLength: 100, nullable: true),
                    Posting_Date = table.Column<DateTime>(type: "date", nullable: true),
                    Document_Date = table.Column<DateTime>(type: "date", nullable: true),
                    Item_Code = table.Column<string>(maxLength: 100, nullable: true),
                    Item_Desc = table.Column<string>(maxLength: 100, nullable: true),
                    Quantity = table.Column<int>(nullable: true),
                    Uom = table.Column<string>(nullable: true)
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

            migrationBuilder.CreateTable(
                name: "Purchase_Orders",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Site = table.Column<string>(maxLength: 100, nullable: true),
                    Posting_Date = table.Column<DateTime>(type: "date", nullable: true),
                    Document_Date = table.Column<DateTime>(type: "date", nullable: true),
                    Article_Doc = table.Column<string>(maxLength: 100, nullable: true),
                    Bill_Doc = table.Column<string>(maxLength: 100, nullable: true),
                    Item_Code = table.Column<string>(maxLength: 100, nullable: true),
                    Item_Desc = table.Column<string>(maxLength: 100, nullable: true),
                    Quantity = table.Column<int>(nullable: true),
                    Uom = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchase_Orders", x => x.ID);
                });

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
                    Calendar_Day = table.Column<DateTime>(type: "date", nullable: true),
                    Invoice_Due_Date = table.Column<DateTime>(type: "date", nullable: true),
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
                name: "Sales_Orders",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Route_No = table.Column<string>(nullable: true),
                    Order_Type = table.Column<string>(nullable: true),
                    Order_Number = table.Column<string>(nullable: true),
                    SO_Date = table.Column<DateTime>(type: "date", nullable: true),
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
                    Calendar_Day = table.Column<DateTime>(type: "date", nullable: true),
                    Invoice_Due_Date = table.Column<DateTime>(type: "date", nullable: true),
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

            migrationBuilder.CreateTable(
                name: "Salesman_Masters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Salesman_Code = table.Column<string>(nullable: true),
                    Salesman_Name = table.Column<string>(nullable: true),
                    FSS_Code = table.Column<string>(nullable: true),
                    FSS_Name = table.Column<string>(nullable: true),
                    Product_Grp_desc = table.Column<string>(nullable: true),
                    Sales_Route = table.Column<string>(nullable: true),
                    Sales_Route_Description = table.Column<string>(nullable: true),
                    Salesman_Team_Type = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Product_Group = table.Column<string>(nullable: true),
                    Warehouse_Distributor = table.Column<string>(nullable: true),
                    Status_Description = table.Column<string>(nullable: true),
                    Salesman_Team_Description = table.Column<string>(nullable: true),
                    Salesman_Type = table.Column<string>(nullable: true),
                    Site = table.Column<string>(nullable: true),
                    Salesman_Type_desc = table.Column<string>(nullable: true),
                    Date_of_Birth = table.Column<DateTime>(type: "date", nullable: true),
                    Education = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Address_2 = table.Column<string>(nullable: true),
                    Address_1 = table.Column<string>(nullable: true),
                    PDA_Flag_Description = table.Column<string>(nullable: true),
                    PDA_Flag = table.Column<string>(nullable: true),
                    Start_Date = table.Column<DateTime>(type: "date", nullable: true),
                    End_Date = table.Column<DateTime>(type: "date", nullable: true),
                    Site_desc = table.Column<string>(nullable: true),
                    Legacy_Salesman_Code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salesman_Masters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalesOrder_Details",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Header_ID = table.Column<int>(nullable: true),
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
                    Cases_Pieces = table.Column<string>(nullable: true),
                    Free_CS_PS = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrder_Details", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SalesOrder_Headers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Route_Type = table.Column<string>(nullable: true),
                    Salesman_Name = table.Column<string>(nullable: true),
                    Terms_of_payment = table.Column<string>(nullable: true),
                    Delivery_Free_Qty_CS = table.Column<string>(nullable: true),
                    Turnover_Value = table.Column<decimal>(type: "decimal(18, 4)", nullable: true),
                    Delivery_Free_Qty_PC = table.Column<string>(nullable: true),
                    Document_Category = table.Column<string>(nullable: true),
                    Salesman = table.Column<string>(nullable: true),
                    Order_Type = table.Column<string>(nullable: true),
                    Route_No = table.Column<string>(nullable: true),
                    Order_Type_Desc = table.Column<string>(nullable: true),
                    Order_Number = table.Column<string>(nullable: true),
                    SO_Date = table.Column<DateTime>(type: "date", nullable: true),
                    Outlet_Code = table.Column<string>(nullable: true),
                    Outlet_Name = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Delivery_N = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrder_Headers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SAP_SalesmanMasters",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Salesman_Code = table.Column<int>(nullable: true),
                    SAP_Salesman_Code = table.Column<int>(nullable: true),
                    Salesman_Customer_Code = table.Column<int>(nullable: true),
                    Route_Code = table.Column<string>(nullable: true),
                    SalesLoc = table.Column<string>(nullable: true),
                    GiftLoc = table.Column<string>(nullable: true),
                    DamageLoc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SAP_SalesmanMasters", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Warehouses",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiteCode = table.Column<string>(nullable: true),
                    SiteName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouses", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Article_Masters");

            migrationBuilder.DropTable(
                name: "Business_Partners");

            migrationBuilder.DropTable(
                name: "Business_Units");

            migrationBuilder.DropTable(
                name: "Delivery_Receipts");

            migrationBuilder.DropTable(
                name: "Inventories");

            migrationBuilder.DropTable(
                name: "Inventory_Details");

            migrationBuilder.DropTable(
                name: "Inventory_Headers");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Purchase_Details");

            migrationBuilder.DropTable(
                name: "Purchase_Headers");

            migrationBuilder.DropTable(
                name: "Purchase_Orders");

            migrationBuilder.DropTable(
                name: "Sales_Invoice");

            migrationBuilder.DropTable(
                name: "Sales_Orders");

            migrationBuilder.DropTable(
                name: "SalesInvoice_Details");

            migrationBuilder.DropTable(
                name: "SalesInvoice_Headers");

            migrationBuilder.DropTable(
                name: "Salesman_Masters");

            migrationBuilder.DropTable(
                name: "SalesOrder_Details");

            migrationBuilder.DropTable(
                name: "SalesOrder_Headers");

            migrationBuilder.DropTable(
                name: "SAP_SalesmanMasters");

            migrationBuilder.DropTable(
                name: "Warehouses");
        }
    }
}
