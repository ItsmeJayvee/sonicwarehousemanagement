using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SonicWarehouseManagement.Shared
{
    public class Discount
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
        public string Customer_Code { get; set; }
        public string Business_Unit { get; set; }
        [Column(TypeName = "decimal(2, 2)")]
        public decimal Discount_Amount { get; set; }
    }
}
