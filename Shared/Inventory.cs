using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SonicWarehouseManagement.Shared
{
    public class Inventory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string Item_Code { get; set; }
        public int Quantity { get; set; }
        public string Transaction_Type { get; set; }
        public string Uom { get; set; }
        public string Warehouse { get; set; }
        public string Location { get; set; }
    }
}
