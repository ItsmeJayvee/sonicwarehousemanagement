using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SonicWarehouseManagement.Server.Migrations
{
    public partial class InitialCreate : Migration
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
                    Updated_Date = table.Column<string>(nullable: true)
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
                    Deactivation_date = table.Column<string>(nullable: true),
                    Changed_date = table.Column<string>(nullable: true),
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
                    Created_On = table.Column<string>(nullable: true),
                    Perfect_Store_Audit_Type = table.Column<string>(nullable: true),
                    eRTM = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Business_Partners", x => x.Id);
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
                    Date_of_Birth = table.Column<string>(nullable: true),
                    Education = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Address_2 = table.Column<string>(nullable: true),
                    Address_1 = table.Column<string>(nullable: true),
                    PDA_Flag_Description = table.Column<string>(nullable: true),
                    PDA_Flag = table.Column<string>(nullable: true),
                    Start_Date = table.Column<string>(nullable: true),
                    End_Date = table.Column<string>(nullable: true),
                    Site_desc = table.Column<string>(nullable: true),
                    Legacy_Salesman_Code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salesman_Masters", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Article_Masters");

            migrationBuilder.DropTable(
                name: "Business_Partners");

            migrationBuilder.DropTable(
                name: "Salesman_Masters");
        }
    }
}
