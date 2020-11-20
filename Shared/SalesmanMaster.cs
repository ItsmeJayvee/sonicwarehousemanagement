using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SonicWarehouseManagement.Shared
{
    public class SalesmanMaster
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Salesman_Code { get; set; }
        public string Salesman_Name { get; set; }
        public string FSS_Code { get; set; }
        public string FSS_Name { get; set; }
        public string Product_Grp_desc { get; set; }
        public string Sales_Route { get; set; }
        public string Sales_Route_Description { get; set; }
        public string Salesman_Team_Type { get; set; }
        public string Status { get; set; }
        public string Product_Group { get; set; }
        public string Warehouse_Distributor { get; set; }
        public string Status_Description { get; set; }
        public string Salesman_Team_Description { get; set; }
        public string Salesman_Type { get; set; }
        public string Site { get; set; }
        public string Salesman_Type_desc { get; set; }
        [Column(TypeName = "date")]
        public DateTime Date_of_Birth { get; set; }
        public string Education { get; set; }
        public string City { get; set; }
        public string Address_2 { get; set; }
        public string Address_1 { get; set; }
        public string PDA_Flag_Description { get; set; }
        public string PDA_Flag { get; set; }
        [Column(TypeName = "date")]
        public DateTime Start_Date { get; set; }
        [Column(TypeName = "date")]
        public DateTime End_Date { get; set; }
        public string Site_desc { get; set; }
        public string Legacy_Salesman_Code { get; set; }
    }
}
