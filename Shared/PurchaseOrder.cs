using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SonicWarehouseManagement.Shared
{
    public class PurchaseOrder
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
        [MaxLength(100)]
        public string Site { get; set; }
        [Column(TypeName = "date")]
        public DateTime Posting_Date { get; set; }
        [Column(TypeName = "date")]
        public DateTime Document_Date { get; set; }
        [MaxLength(100)]
        public string Article_Doc { get; set; }
        [MaxLength(100)]
        public string Bill_Doc { get; set; }
        [MaxLength(100)]
        public string Item_Code { get; set; }
        [MaxLength(100)]
        public string Item_Desc { get; set; }
        public int Quantity { get; set; }
        public string Uom { get; set; }
    }
}
