#pragma checksum "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomeInventor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f7a5fc3e609e42ee2c9dd5dd191b9cfb9d4eeb1"
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
#line 2 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomeInventor.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomeInventor.razor"
using SonicWarehouseManagement.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomeInventor.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/inventorylist")]
    public partial class HomeInventor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Inventory list</h2>\r\n<hr>\r\n");
#nullable restore
#line 10 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomeInventor.razor"
 if (ilist == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 13 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomeInventor.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<thead>\r\n            <tr>\r\n                <th style=\"font-size: small;\">ID</th>\r\n                <th style=\"font-size: small;\">Item number</th>\r\n                <th style=\"font-size: small;\">Date</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 25 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomeInventor.razor"
             foreach (var i in ilist)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddAttribute(14, "style", "font-size: small;");
            __builder.AddContent(15, 
#nullable restore
#line 28 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomeInventor.razor"
                                                   i.ID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddAttribute(18, "style", "font-size: small;");
            __builder.AddContent(19, 
#nullable restore
#line 29 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomeInventor.razor"
                                                   i.Item_Code

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.OpenElement(21, "td");
            __builder.AddAttribute(22, "style", "font-size: small;");
            __builder.AddContent(23, 
#nullable restore
#line 30 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomeInventor.razor"
                                                   i.Date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "td");
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.OpenElement(27, "a");
            __builder.AddAttribute(28, "style", "font-size: small;");
            __builder.AddAttribute(29, "href", "/viewinventory/" + (
#nullable restore
#line 32 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomeInventor.razor"
                                                                           i.ID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "class", "btn-sm btn-primary");
            __builder.AddContent(31, "View");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 35 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomeInventor.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n    ");
            __builder.OpenComponent<SonicWarehouseManagement.Client.Shared.Pagination>(38);
            __builder.AddAttribute(39, "TotalPagesQuantity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 38 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomeInventor.razor"
                                    totalPageQuantity

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "CurrentPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 38 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomeInventor.razor"
                                                                    currentPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "Radius", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 38 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomeInventor.razor"
                                                                                         2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "SelectedPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 38 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomeInventor.razor"
                                                                                                          SelectedPage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 39 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomeInventor.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\HomeInventor.razor"
       
    Inventory[] ilist;

    private int totalPageQuantity;
    private int currentPage = 1;
    private string searchitemnum = string.Empty;

    private HubConnection hubCon;

    protected override async Task OnInitializedAsync()
    {
        hubCon = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/InventoryHub"))
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
        var httpResponse = await Http.GetAsync($"api/Inventories?page={page}&quantityPerPage={quantityPerPage}&item={searchitemnum}");

        if (httpResponse.IsSuccessStatusCode)
        {
            totalPageQuantity = int.Parse(httpResponse.Headers.GetValues("pagesQuantity").FirstOrDefault());
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            ilist = JsonSerializer.Deserialize<Inventory[]>(responseString,
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
