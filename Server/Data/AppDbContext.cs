using Microsoft.EntityFrameworkCore;
using SonicWarehouseManagement.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SonicWarehouseManagement.Server.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option)
            :base(option)
        {

        }

        public DbSet<ArticleMaster> Article_Masters { get; set; }
        public DbSet<BusinessPartner> Business_Partners { get; set; }
        public DbSet<InvoiceDetails> Invoice_Details { get; set; }
        public DbSet<InvoiceHeaders> Invoice_Headers { get; set; }
        public DbSet<ISR_DailySalesInvoice> ISR_Daily_Sales_Invoices { get; set; }
        public DbSet<SalesmanMaster> Salesman_Masters { get; set; }
        public DbSet<PurchaseOrder> Purchase_Orders { get; set; }
        public DbSet<PurchaseDetails> Purchase_Details { get; set; }
        public DbSet<PurchaseHeaders> Purchase_Headers { get; set; }
        public DbSet<SalesOrder> Sales_Orders { get; set; }
        public DbSet<SalesOrderHeaders> SalesOrder_Headers { get; set; }
        public DbSet<SalesOrderDetails> SalesOrder_Details { get; set; }
    }
}
