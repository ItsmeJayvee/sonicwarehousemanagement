using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SonicWarehouseManagement.Shared
{
    public class SalesOrderDetails
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
        public int Header_ID { get; set; }
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
        public string Cases_Pieces { get; set; }
        public string Free_CS_PS { get; set; }
    }
}
