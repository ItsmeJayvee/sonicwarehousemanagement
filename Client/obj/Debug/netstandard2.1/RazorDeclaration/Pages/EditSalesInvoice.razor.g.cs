#pragma checksum "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\EditSalesInvoice.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49c6637f098c048a6d10326e3cf78855bf179d57"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\EditSalesInvoice.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\EditSalesInvoice.razor"
using SonicWarehouseManagement.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editsalesinvoice/{id}")]
    public partial class EditSalesInvoice : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 248 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\EditSalesInvoice.razor"
       
    SalesInvoice si = new SalesInvoice();

    private HubConnection hubCon;

    [Parameter]
    public string id { get; set; }

    protected override async Task OnInitializedAsync()
    {
        si = await Http.GetJsonAsync<SalesInvoice>("api/ISR_DailySalesInvoiceManual/" + id);

        hubCon = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/DailySalesInvoiceManualHub"))
            .Build();

        await hubCon.StartAsync();
    }

    public bool IsConnected =>
        hubCon.State == HubConnectionState.Connected;

    public async Task updatesalesinvoice()
    {
        await Http.PutJsonAsync("api/ISR_DailySalesInvoiceManual/" + id, si);
        if (IsConnected) await SendMessage();
        NavigationManager.NavigateTo("salesinvoicelist");
    }

    Task SendMessage() => hubCon.SendAsync("SendMessage");

    void cancel()
    {
        NavigationManager.NavigateTo("salesinvoicelist");
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
