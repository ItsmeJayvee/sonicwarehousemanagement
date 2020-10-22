using System;
using System.Collections.Generic;
using System.Text;

namespace SonicWarehouseManagement.Shared
{
    public class SalesInvoicePagination
    {
        public int Page { get; set; } = 1;
        public int QuantityPerPage { get; set; } = 10;
    }
}
