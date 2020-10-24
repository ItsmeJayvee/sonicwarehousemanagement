using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Linq;
using SonicWarehouseManagement.Server.Hubs;
using SonicWarehouseManagement.Server.Data;
using Microsoft.EntityFrameworkCore;

namespace SonicWarehouseManagement.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSignalR();
            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddResponseCompression(option =>
            {
                option.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
                    new[]{ "applicaion/octet-stream"
                });
            });
            services.AddDbContext<AppDbContext>(option =>
                option.UseSqlServer(Configuration.GetConnectionString("default"))
            );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseResponseCompression();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapHub<ArticleHub>("/ArticleHub");
                endpoints.MapHub<BusinessPartnerHub>("/BusinessPartnerHub");
                endpoints.MapHub<SalesmanHub>("/SalesmanHub");
                endpoints.MapHub<SalesInvoiceHeadersHub>("/SalesInvoiceHeadersHub");
                endpoints.MapHub<PurchaseHeadersHub>("/PurchaseHeadersHub");
                endpoints.MapHub<PurchaseDetailsHub>("/PurchaseDetailsHub");
                endpoints.MapHub<SalesOrderHub>("/SalesOrderHub");
                endpoints.MapHub<WarehouseHub>("/WarehouseHub");
                endpoints.MapHub<LocationHub>("/LocationHub");
                endpoints.MapHub<DeliveryReceiptHub>("/DeliveryReceiptHub");
                endpoints.MapHub<BusinessUnitHub>("/BusinessUnitHub");
                endpoints.MapHub<SAPSalesmanMasterHub>("/SAPSalesmanMasterHub");
                endpoints.MapFallbackToFile("index.html");
            });
        }
    }
}
