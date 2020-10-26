#pragma checksum "D:\IntegratedWebAPI\sonicwarehousemanagement\Client\Pages\DeleteSalesOrder.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2773bad57e0a6dfbfef13db414e01ff3bd27686a"
// <auto-generated/>
#pragma warning disable 1591
namespace SonicWarehouseManagement.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\IntegratedWebAPI\sonicwarehousemanagement\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\IntegratedWebAPI\sonicwarehousemanagement\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\IntegratedWebAPI\sonicwarehousemanagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\IntegratedWebAPI\sonicwarehousemanagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\IntegratedWebAPI\sonicwarehousemanagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\IntegratedWebAPI\sonicwarehousemanagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\IntegratedWebAPI\sonicwarehousemanagement\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\IntegratedWebAPI\sonicwarehousemanagement\Client\_Imports.razor"
using SonicWarehouseManagement.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\IntegratedWebAPI\sonicwarehousemanagement\Client\_Imports.razor"
using SonicWarehouseManagement.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\IntegratedWebAPI\sonicwarehousemanagement\Client\Pages\DeleteSalesOrder.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\IntegratedWebAPI\sonicwarehousemanagement\Client\Pages\DeleteSalesOrder.razor"
using SonicWarehouseManagement.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/deletesalesorder/{id}")]
    public partial class DeleteSalesOrder : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Delete sales order</h3>\r\n<hr>\r\n");
            __builder.AddMarkupContent(1, "<p>Are you sure you want to delete this sales order?</p>\r\n<br>\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-md-4");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<thead>\r\n            <tr>\r\n                <th style=\"font-size: small;\">Order number</th>\r\n                <th style=\"font-size: small;\">Sales order Date</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "td");
            __builder.AddAttribute(14, "style", "font-size: small;");
            __builder.AddContent(15, 
#nullable restore
#line 22 "D:\IntegratedWebAPI\sonicwarehousemanagement\Client\Pages\DeleteSalesOrder.razor"
                                               solist.Order_Number

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "td");
            __builder.AddAttribute(18, "style", "font-size: small;");
            __builder.AddContent(19, 
#nullable restore
#line 23 "D:\IntegratedWebAPI\sonicwarehousemanagement\Client\Pages\DeleteSalesOrder.razor"
                                               solist.SO_Date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "form-group");
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "type", "button");
            __builder.AddAttribute(29, "class", "btn btn-danger");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "D:\IntegratedWebAPI\sonicwarehousemanagement\Client\Pages\DeleteSalesOrder.razor"
                                                               deletesalesorder

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "value", "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.OpenElement(33, "input");
            __builder.AddAttribute(34, "type", "button");
            __builder.AddAttribute(35, "class", "btn btn-primary");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "D:\IntegratedWebAPI\sonicwarehousemanagement\Client\Pages\DeleteSalesOrder.razor"
                                                                cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "value", "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "D:\IntegratedWebAPI\sonicwarehousemanagement\Client\Pages\DeleteSalesOrder.razor"
       
    SalesOrder solist = new SalesOrder();

    private HubConnection hubCon;

    [Parameter]
    public string id { get; set; }

    protected override async Task OnInitializedAsync()
    {
        solist = await Http.GetJsonAsync<SalesOrder>("api/SalesOrders/" + id);

        hubCon = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/SalesOrderHub"))
            .Build();

        await hubCon.StartAsync();
    }

    public bool IsConnected =>
        hubCon.State == HubConnectionState.Connected;

    Task SendMessage() => hubCon.SendAsync("SendMessage");

    public async Task deletesalesorder()
    {
        await Http.DeleteAsync("api/SalesOrders/" + id);
        if (IsConnected) await SendMessage();
        NavigationManager.NavigateTo("salesorderlist");
    }

    void cancel()
    {
        NavigationManager.NavigateTo("salesorderlist");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
