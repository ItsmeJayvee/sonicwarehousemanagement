#pragma checksum "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomePurchaseOrder.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27ab76b543d341391dd3f2b0fd5131f7372e0e5a"
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
#line 1 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\_Imports.razor"
using SonicWarehouseManagement.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\_Imports.razor"
using SonicWarehouseManagement.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomePurchaseOrder.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomePurchaseOrder.razor"
using SonicWarehouseManagement.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomePurchaseOrder.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/purchaseorderlist")]
    public partial class HomePurchaseOrder : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Purchase order</h2>\r\n<hr>\r\n");
            __builder.AddMarkupContent(1, "<a href=\"/addpurchaseorder\" class=\"btn btn-primary\">Create new purchase order</a>\r\n<hr>\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "form-inline");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.AddMarkupContent(5, "<label class=\"sr-only\" for=\"search-ordernumber\">Search</label>\r\n    ");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "type", "text");
            __builder.AddAttribute(8, "class", "form-control mb-2 mr-sm-2");
            __builder.AddAttribute(9, "placeholder", "Search article number");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomePurchaseOrder.razor"
                                                                searchartnum

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchartnum = __value, searchartnum));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "type", "button");
            __builder.AddAttribute(15, "class", "btn btn-primary mr-sm-2 mb-2");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomePurchaseOrder.razor"
                                                                         Search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(17, "Search");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n<hr>\r\n");
#nullable restore
#line 18 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomePurchaseOrder.razor"
 if (polist == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "    ");
            __builder.AddMarkupContent(21, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 21 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomePurchaseOrder.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, "    ");
            __builder.OpenElement(23, "table");
            __builder.AddAttribute(24, "class", "table");
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.AddMarkupContent(26, "<thead>\r\n            <tr>\r\n                <th>ID</th>\r\n                <th>Article document</th>\r\n                <th>Bill document</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(27, "tbody");
            __builder.AddMarkupContent(28, "\r\n");
#nullable restore
#line 33 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomePurchaseOrder.razor"
             foreach (var po in polist)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(29, "                ");
            __builder.OpenElement(30, "tr");
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.OpenElement(32, "td");
            __builder.AddAttribute(33, "style", "font-size: small;");
            __builder.AddContent(34, 
#nullable restore
#line 36 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomePurchaseOrder.razor"
                                                   po.ID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.OpenElement(36, "td");
            __builder.AddAttribute(37, "style", "font-size: small;");
            __builder.AddContent(38, 
#nullable restore
#line 37 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomePurchaseOrder.razor"
                                                   po.Article_Doc

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.OpenElement(40, "td");
            __builder.AddAttribute(41, "style", "font-size: small;");
            __builder.AddContent(42, 
#nullable restore
#line 38 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomePurchaseOrder.razor"
                                                   po.Bill_Doc

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                    ");
            __builder.OpenElement(44, "td");
            __builder.AddMarkupContent(45, "\r\n                        ");
            __builder.OpenElement(46, "a");
            __builder.AddAttribute(47, "href", "/editpurchaseorder/" + (
#nullable restore
#line 40 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomePurchaseOrder.razor"
                                                     po.ID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "class", "btn-sm btn-primary");
            __builder.AddContent(49, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                        ");
            __builder.OpenElement(51, "a");
            __builder.AddAttribute(52, "href", "/deletepurchaseorder/" + (
#nullable restore
#line 41 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomePurchaseOrder.razor"
                                                       po.ID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "class", "btn-sm btn-danger");
            __builder.AddContent(54, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n");
#nullable restore
#line 44 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomePurchaseOrder.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(58, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n    ");
            __builder.OpenComponent<SonicWarehouseManagement.Client.Shared.Pagination>(61);
            __builder.AddAttribute(62, "TotalPagesQuantity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 47 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomePurchaseOrder.razor"
                                    totalPageQuantity

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(63, "CurrentPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 47 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomePurchaseOrder.razor"
                                                                    currentPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(64, "Radius", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 47 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomePurchaseOrder.razor"
                                                                                         2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(65, "SelectedPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 47 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomePurchaseOrder.razor"
                                                                                                          SelectedPage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(66, "\r\n");
#nullable restore
#line 48 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomePurchaseOrder.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomePurchaseOrder.razor"
       
    PurchaseHeaders[] polist;

    private int totalPageQuantity;
    private int currentPage = 1;
    private string searchartnum = string.Empty;

    private HubConnection hubCon;

    protected override async Task OnInitializedAsync()
    {
        hubCon = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/PurchaseHeadersHub"))
            .Build();

        hubCon.On("ReceiveMessage", () =>
        {
            CallLoadData();
            StateHasChanged();
        });

        await hubCon.StartAsync();
        await LoadData();
    }

    private void CallLoadData()
    {
        Task.Run(async () =>
        {
            await LoadData();
        });
    }

    private async Task SelectedPage(int page)
    {
        currentPage = page;
        await LoadData(page);
    }

    private async Task Search()
    {
        currentPage = 1;
        await LoadData();
    }

    protected async Task LoadData(int page = 1, int quantityPerPage = 10)
    {
        var httpResponse = await Http.GetAsync($"api/PurchaseOrderHeadersIndex?page={page}&quantityPerPage={quantityPerPage}&article={searchartnum}");

        if (httpResponse.IsSuccessStatusCode)
        {
            totalPageQuantity = int.Parse(httpResponse.Headers.GetValues("pagesQuantity").FirstOrDefault());
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            polist = JsonSerializer.Deserialize<PurchaseHeaders[]>(responseString,
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            StateHasChanged();
        }
        else
        {
            //Error handler
        }
    }

    public void Dispose()
    {
        _ = hubCon.DisposeAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
