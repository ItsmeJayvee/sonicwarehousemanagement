using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SonicWarehouseManagement.Shared
{
    public class BusinessPartner
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Card_Code { get; set; }
        public string Card_Name { get; set; }
        public string Card_Type { get; set; }
        public string Status { get; set; }
        public string PJP { get; set; }
        public string Salesman { get; set; }
        public string Salesman_Name { get; set; }
        public string Street { get; set; }
        public string Street_2 { get; set; }
        public string Street_3 { get; set; }
        public string Outlet_Type { get; set; }
        public string Outlet_Type_Description { get; set; }
        public string Outlet_Sub_Type { get; set; }
        public string Outlet_Sub_Type_Description { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Payment_Type_Description { get; set; }
        public string Terms_of_Payment { get; set; }
        public string Terms_of_Payment_Description { get; set; }
        public string Postal_Code { get; set; }
        public string VAT_Number { get; set; }
        public string Contact_Person { get; set; }
        public string Classification { get; set; }
        public string Classification_Description { get; set; }
        public string Delivering_Site { get; set; }
        public string Delivering_Site_Description { get; set; }
        public string Lead_Time { get; set; }
        public string MAG_Description { get; set; }
        public string LSR_Level_Description { get; set; }
        public string LSR_Province_Description { get; set; }
        public string LSR_City_Description { get; set; }
        public string LSR_Barangay_Description { get; set; }
        public string Deactivation_date { get; set; }
        public string Changed_date { get; set; }
        public string Payment_Type { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Banner_ID_Description { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string House_Number { get; set; }
        public string Name2 { get; set; }
        public string Name3 { get; set; }
        public string Outlet_Location { get; set; }
        public string Search_Term1 { get; set; }
        public string Search_Term2 { get; set; }
        public string Tax1 { get; set; }
        public string Created_On { get; set; }
        public string Perfect_Store_Audit_Type { get; set; }
        public string eRTM { get; set; }
    }
}
