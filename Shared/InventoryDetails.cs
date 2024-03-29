﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SonicWarehouseManagement.Shared
{
    public class InventoryDetails
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
        public string Header_Ref { get; set; }
        public int Quantity { get; set; }
        public string Transaction_Type { get; set; }
        public string Uom { get; set; }
        public string Warehouse { get; set; }
        public string Location { get; set; }
    }
}
