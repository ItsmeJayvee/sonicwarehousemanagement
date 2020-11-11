using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SonicWarehouseManagement.Shared
{
    public class SalesInvoice_Headers
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
        public string Distributor { get; set; }
        public string Distributor_Desc { get; set; }
        public string Site { get; set; }
        public string Site_Desc { get; set; }
        public string Sales_Route { get; set; }
        public string Route_Desc { get; set; }
        public int Outlet_Code { get; set; }
        public string Outlet_Name { get; set; }
        public int Master_FSS { get; set; }
        public string Master_FSS_Name { get; set; }
        public string Salesman_Team_Type { get; set; }
        public string Salesman_Team_Type_Desc { get; set; }
        [Column(TypeName = "date")]
        public DateTime Calendar_Day { get; set; }
        [Column(TypeName = "date")]
        public DateTime Invoice_Due_Date { get; set; }
        public string Purchase_Order_No { get; set; }
        public string Sales_Order_No { get; set; }
        public string Invoice_No { get; set; }
        public string Billing_Type { get; set; }
        public string Billing_Type_1 { get; set; }
        public string Terms_Of_Payment { get; set; }
        public string Master_Outlet_Subtype { get; set; }
        public string Master_Outlet_Subtype_Name { get; set; }
        public string Master_Outlet_City { get; set; }
        public string Master_Outlet_City_Name { get; set; }
        public int Salesman_Id { get; set; }
        public string Salesman_Name { get; set; }
    }
}
