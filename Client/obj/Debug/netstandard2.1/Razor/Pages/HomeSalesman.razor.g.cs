#pragma checksum "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\HomeSalesman.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f0c991b001ee8ecac3a211eafe3547d6cde2123"
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
#line 1 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\_Imports.razor"
using SonicWarehouseManagement.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\_Imports.razor"
using SonicWarehouseManagement.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\HomeSalesman.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\HomeSalesman.razor"
using SonicWarehouseManagement.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/salesmanlist")]
    public partial class HomeSalesman : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Business Partners</h2>\r\n<hr>\r\n");
            __builder.AddMarkupContent(1, "<a href=\"/addsalesman\" class=\"btn btn-primary\">Add new salesman  </a>\r\n<hr>\r\n");
#nullable restore
#line 11 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\HomeSalesman.razor"
 if (smlist == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 14 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\HomeSalesman.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, @"<thead>
            <tr>
                <th style=""font-size: small;"">ID</th>
                <th style=""font-size: small;"">Salesman code</th>
                <th style=""font-size: small;"">Salesman name</th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 26 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\HomeSalesman.razor"
             foreach (var sales in smlist)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddAttribute(15, "style", "font-size: small;");
            __builder.AddContent(16, 
#nullable restore
#line 29 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\HomeSalesman.razor"
                                                   sales.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "td");
            __builder.AddAttribute(19, "style", "font-size: small;");
            __builder.AddContent(20, 
#nullable restore
#line 30 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\HomeSalesman.razor"
                                                   sales.Salesman_Code

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddAttribute(23, "style", "font-size: small;");
            __builder.AddContent(24, 
#nullable restore
#line 31 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\HomeSalesman.razor"
                                                   sales.Salesman_Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "td");
            __builder.AddMarkupContent(27, "\r\n                        ");
            __builder.OpenElement(28, "a");
            __builder.AddAttribute(29, "style", "font-size: small;");
            __builder.AddAttribute(30, "href", "/editsalesman/" + (
#nullable restore
#line 33 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\HomeSalesman.razor"
                                                                          sales.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "class", "btn-sm btn-primary");
            __builder.AddContent(32, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                        ");
            __builder.OpenElement(34, "a");
            __builder.AddAttribute(35, "style", "font-size: small;");
            __builder.AddAttribute(36, "href", "/deletesalesman/" + (
#nullable restore
#line 34 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\HomeSalesman.razor"
                                                                            sales.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "class", "btn-sm btn-danger");
            __builder.AddContent(38, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
#nullable restore
#line 37 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\HomeSalesman.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(42, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 40 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\HomeSalesman.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\HomeSalesman.razor"
       
    SalesmanMaster[] smlist;

    private HubConnection hubCon;

    protected override async Task OnInitializedAsync()
    {
        hubCon = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/SalesmanHub"))
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

    protected async Task LoadData()
    {
        smlist = await Http.GetJsonAsync<SalesmanMaster[]>("api/SalesmanMasters");
        StateHasChanged();
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
