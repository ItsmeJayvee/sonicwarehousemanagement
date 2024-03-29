﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SonicWarehouseManagement.Shared
{
    public class InventoryHeader
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }
        public string Item_Code { get; set; }
        public string Ref_ID { get; set; }
    }
}
