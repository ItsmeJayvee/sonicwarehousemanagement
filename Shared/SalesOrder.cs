using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SonicWarehouseManagement.Shared
{
    public class SalesOrder
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
        public string Route_No { get; set; }
        public string Order_Type { get; set; }
        public string Order_Number { get; set; }
        [Column(TypeName = "date")]
        public DateTime SO_Date { get; set; }
        public string Outlet_Code { get; set; }
        public string Outlet_Name { get; set; }
        public string Status { get; set; }
        public string Delivery_N { get; set; }
        public string Material_N { get; set; }
        public string Article_Description { get; set; }
        public string Pack_Size { get; set; }
        public string Cases { get; set; }
        public string Pieces { get; set; }
        public string Free_Cases { get; set; }
        public string Free_Piece { get; set; }
        public string Delivery_Qty_CS { get; set; }
        public string Delivery_Qty_PC { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal Sales_Value { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal VAT_Value { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal Net_Sales { get; set; }
        public string Item_Number { get; set; }
        public string Route_Type { get; set; }
        public string Salesman_Name { get; set; }
        public string Terms_of_payment { get; set; }
        public string Delivery_Free_Qty_CS { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal Turnover_Value { get; set; }
        public string Delivery_Free_Qty_PC { get; set; }
        public string Document_Category { get; set; }
        public string Salesman { get; set; }
        public string Order_Type_Desc { get; set; }
        public string Cases_Pieces { get; set; }
        public string Free_CS_PS { get; set; }
    }
}
