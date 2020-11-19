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
#line 2 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditPurchaseOrder.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditPurchaseOrder.razor"
using SonicWarehouseManagement.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditPurchaseOrder.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editpurchaseorder/{id}")]
    public partial class EditPurchaseOrder : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 130 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditPurchaseOrder.razor"
       
    ArticleMaster artmas = new ArticleMaster();
    PurchaseHeaders po = new PurchaseHeaders();
    PurchaseDetails pds = new PurchaseDetails();
    Warehouse loc = new Warehouse();
    Warehouse[] wh;
    PurchaseDetails[] pd;

    private HubConnection hubCon;

    public string searchitemnum { get; set; }
    public DateTime pdate { get; set; }
    public DateTime ddate { get; set; }

    [Parameter]
    public string id { get; set; }

    protected override async Task OnInitializedAsync()
    {
        po = await Http.GetJsonAsync<PurchaseHeaders>("api/PurchaseOrderHeadersIndex/" + id);
        pd = await Http.GetJsonAsync<PurchaseDetails[]>("api/PurchaseOrderDetailsIndex/" + po.ID);
        wh = await Http.GetJsonAsync<Warehouse[]>("api/Warehouse");

        hubCon = new HubConnectionBuilder()
        .WithUrl(NavigationManager.ToAbsoluteUri("/PurchaseDetailsHub"))
        .Build();

        await hubCon.StartAsync();
    }

    public bool IsConnected =>
        hubCon.State == HubConnectionState.Connected;

    private async Task Search()
    {
        artmas = await Http.GetJsonAsync<ArticleMaster>("api/ArticleMasters/" + searchitemnum);
        this.StateHasChanged();
    }

    public async Task insertsalesinvoice()
    {
        loc = await Http.GetJsonAsync<Warehouse>("api/Warehouse/" + pds.Site);

        var InsertInventory = new Inventory { Date = Convert.ToDateTime(DateTime.Now.ToShortDateString()), Item_Code = artmas.Article_Code, Quantity = Convert.ToInt32(artmas.Unit_Conversion2), Transaction_Type = "Purchase Order", Uom = pds.Uom, Warehouse = pds.Site, Location = loc.SiteName };
        await Http.PostJsonAsync("api/Inventory", InsertInventory);

        var InsertInventoryHeader = new InventoryHeader { Date = Convert.ToDateTime(DateTime.Now.ToShortDateString()), Item_Code = artmas.Article_Code, Ref_ID = "Purchase Order" };
        await Http.PostJsonAsync("api/InventoryHeaderIndex/" + artmas.Article_Code, InsertInventoryHeader);

        var InsertInventoryDetails = new InventoryDetails { Header_Ref = artmas.Article_Code, Quantity = Convert.ToInt32(artmas.Unit_Conversion2), Transaction_Type = "Purchase Order", Uom = pds.Uom, Warehouse = pds.Site, Location = loc.SiteName };
        await Http.PostJsonAsync("api/InventoryDetailsManual", InsertInventoryDetails);

        var purchaseOrderDetails = new PurchaseDetails { Header_ID = po.ID, Site = pds.Site, Posting_Date = Convert.ToDateTime(pdate.ToShortDateString()), Document_Date = Convert.ToDateTime(ddate.ToShortDateString()), Item_Code = artmas.Article_Code, Item_Desc = artmas.Article_Description, Quantity = Convert.ToInt32(artmas.Unit_Conversion2), Uom = pds.Uom };
        await Http.PostJsonAsync("api/PurchaseOrderDetailsIndex", purchaseOrderDetails);

        if (IsConnected) await SendMessage();
        NavigationManager.NavigateTo("refresh2/" + po.Article_Doc);
    }

    void cancel()
    {
        NavigationManager.NavigateTo("purchaseorderlist");
    }

    Task SendMessage() => hubCon.SendAsync("SendMessage");

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
