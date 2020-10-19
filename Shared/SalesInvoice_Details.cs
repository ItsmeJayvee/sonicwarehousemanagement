using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SonicWarehouseManagement.Shared
{
    public class SalesInvoice_Details
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
        public int Header_ID { get; set; }
        public string Product_Id { get; set; }
        public string Product_Name { get; set; }
        public string Pack_Size { get; set; }
        public string Master_Brand { get; set; }
        public string Master_Brand_Name { get; set; }
        public string Master_Basepack { get; set; }
        public string Master_Basepack_Name { get; set; }
        public string Lead_Basepack { get; set; }
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
