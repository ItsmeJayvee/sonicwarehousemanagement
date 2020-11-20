using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SonicWarehouseManagement.Shared
{
    public class BusinessUnit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
        public string Business_Unit { get; set; }
        public string Site { get; set; }
        public string Product { get; set; }
        public string Group_Code { get; set; }
        public string Cost_Center { get; set; }
    }
}
