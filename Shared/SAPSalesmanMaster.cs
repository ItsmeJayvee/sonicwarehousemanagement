using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SonicWarehouseManagement.Shared
{
    public class SAPSalesmanMaster
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
        public int Salesman_Code { get; set; }
        public int SAP_Salesman_Code { get; set; }
        public int Salesman_Customer_Code { get; set; }
        public string Route_Code { get; set; }
        public string SalesLoc { get; set; }
        public string GiftLoc { get; set; }
        public string DamageLoc { get; set; }

    }
}
