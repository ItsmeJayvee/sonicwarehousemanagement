using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SonicWarehouseManagement.Shared
{
    public class Location
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
        public string SalesLocation { get; set; }
        public string GiftLocation { get; set; }
        public string DamageLocation { get; set; }
    }
}
