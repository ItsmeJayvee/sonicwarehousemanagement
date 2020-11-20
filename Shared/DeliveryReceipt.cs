using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SonicWarehouseManagement.Shared
{
    public class DeliveryReceipt
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
        [MaxLength(100)]
        public string Distributor { get; set; }
        [MaxLength(100)]
        public string Distributor_Desc { get; set; }
        [MaxLength(100)]
        public string Site { get; set; }
        [MaxLength(100)]
        public string Site_Desc { get; set; }
        [MaxLength(100)]
        public string Sales_Route { get; set; }
        [MaxLength(100)]
        public string Route_Desc { get; set; }
        public int Outlet_Code { get; set; }
        [MaxLength(100)]
        public string Outlet_Name { get; set; }
        public int Master_FSS { get; set; }
        [MaxLength(100)]
        public string Master_FSS_Name { get; set; }
        [MaxLength(100)]
        public string Salesman_Team_Type { get; set; }
        [MaxLength(100)]
        public string Salesman_Team_Type_Desc { get; set; }
        [Column(TypeName = "date")]
        public DateTime Calendar_Day { get; set; }
        [Column(TypeName = "date")]
        public DateTime Delivery_Due_Date { get; set; }
        [MaxLength(100)]
        public string Purchase_Order_No { get; set; }
        [MaxLength(100)]
        public string Sales_Order_No { get; set; }
        [MaxLength(100)]
        public string Delivery_Receipt_No { get; set; }
        [MaxLength(100)]
        public string Billing_Type { get; set; }
        [MaxLength(100)]
        public string Billing_Type_1 { get; set; }
        [MaxLength(100)]
        public string Terms_Of_Payment { get; set; }
        [MaxLength(100)]
        public string Master_Outlet_Subtype { get; set; }
        [MaxLength(100)]
        public string Master_Outlet_Subtype_Name { get; set; }
        [MaxLength(100)]
        public string Master_Outlet_City { get; set; }
        [MaxLength(100)]
        public string Master_Outlet_City_Name { get; set; }
        [MaxLength(100)]
        public string Product_Id { get; set; }
        [MaxLength(100)]
        public string Product_Name { get; set; }
        [MaxLength(100)]
        public string Pack_Size { get; set; }
        [MaxLength(100)]
        public string Master_Brand { get; set; }
        [MaxLength(100)]
        public string Master_Brand_Name { get; set; }
        [MaxLength(100)]
        public string Master_Basepack { get; set; }
        [MaxLength(100)]
        public string Master_Basepack_Name { get; set; }
        [MaxLength(100)]
        public string Lead_Basepack { get; set; }
        public int Salesman_Id { get; set; }
        [MaxLength(100)]
        public string Salesman_Name { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal Sales_Qty_CS { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal Sales_Qty_PC { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal Free_Qty_CS { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal Free_Qty_PC { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal Sales_Qty_Liter { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal Free_Qty_Liter { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal Sales_Qty_Aggr_CS { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal Sales_Qty_Aggr_PC { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal Free_Qty_Aggr_CS { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal Free_Qty_Aggr_PC { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal GSV { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal TPR { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal UW { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal DT_Discount { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal Sales_After { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal Volume_Discount { get; set; }
        public int Coupon_Discount { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal NIV { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal VAT { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal Total_Sales_Amnt_Inc { get; set; }
        public int Aggr_Pieces { get; set; }
        public int Cabinet_Count { get; set; }
    }
}
