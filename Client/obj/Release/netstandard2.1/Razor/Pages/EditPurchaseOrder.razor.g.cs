#pragma checksum "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditPurchaseOrder.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e989e621666e24636da2918e1725fd4ef8a83729"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/editpurchaseorder/{id}")]
    public partial class EditPurchaseOrder : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Purchase order</h2>\r\n<hr>\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Order number: ");
            __builder.OpenElement(3, "b");
            __builder.AddContent(4, 
#nullable restore
#line 9 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditPurchaseOrder.razor"
                     po.Article_Doc

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenElement(6, "p");
            __builder.AddContent(7, "Bill Document: ");
            __builder.OpenElement(8, "b");
            __builder.AddContent(9, 
#nullable restore
#line 10 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditPurchaseOrder.razor"
                      po.Bill_Doc

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.OpenElement(11, "table");
            __builder.AddAttribute(12, "class", "table");
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.AddMarkupContent(14, @"<thead>
        <tr>
            <th>Site</th>
            <th>Item Code</th>
            <th>Item Description</th>
            <th>Quantity</th>
            <th>Uom</th>
            <th>Posting Date</th>
            <th>Document Date</th>
        </tr>
    </thead>
    ");
            __builder.OpenElement(15, "tbody");
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 24 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditPurchaseOrder.razor"
         if (pd == null)
        {
            // do nothing
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditPurchaseOrder.razor"
             foreach (var items in pd)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "                ");
            __builder.OpenElement(18, "tr");
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddAttribute(21, "style", "font-size: small");
            __builder.AddContent(22, 
#nullable restore
#line 33 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditPurchaseOrder.razor"
                                                  items.Site

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "td");
            __builder.AddAttribute(25, "style", "font-size: small");
            __builder.AddContent(26, 
#nullable restore
#line 34 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditPurchaseOrder.razor"
                                                  items.Item_Code

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "td");
            __builder.AddAttribute(29, "style", "font-size: small");
            __builder.AddContent(30, 
#nullable restore
#line 35 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditPurchaseOrder.razor"
                                                  items.Item_Desc

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.OpenElement(32, "td");
            __builder.AddAttribute(33, "style", "font-size: small");
            __builder.AddContent(34, 
#nullable restore
#line 36 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditPurchaseOrder.razor"
                                                  items.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.OpenElement(36, "td");
            __builder.AddAttribute(37, "style", "font-size: small");
            __builder.AddContent(38, 
#nullable restore
#line 37 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditPurchaseOrder.razor"
                                                  items.Uom

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.OpenElement(40, "td");
            __builder.AddAttribute(41, "style", "font-size: small");
            __builder.AddContent(42, 
#nullable restore
#line 38 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditPurchaseOrder.razor"
                                                  items.Posting_Date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                    ");
            __builder.OpenElement(44, "td");
            __builder.AddAttribute(45, "style", "font-size: small");
            __builder.AddContent(46, 
#nullable restore
#line 39 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditPurchaseOrder.razor"
                                                  items.Document_Date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n");
#nullable restore
#line 41 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditPurchaseOrder.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditPurchaseOrder.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(49, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n<hr>\r\n");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "container");
            __builder.AddMarkupContent(54, "\r\n    ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "row");
            __builder.AddMarkupContent(57, "\r\n        ");
            __builder.AddMarkupContent(58, "<div class=\"text-left col-md-12\">\r\n            <h6><b>Insert Sales Invoice Details:</b></h6>\r\n        </div>\r\n        <hr>\r\n        ");
            __builder.OpenElement(59, "form");
            __builder.AddMarkupContent(60, "\r\n            ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "row");
            __builder.AddMarkupContent(63, "\r\n                ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "col-md-3");
            __builder.AddMarkupContent(66, "\r\n                    ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "form-group");
            __builder.AddMarkupContent(69, "\r\n                        ");
            __builder.AddMarkupContent(70, "<label for=\"prodcode\" class=\"control-label\" style=\"font-size: small;\">Site</label>\r\n                        ");
            __builder.OpenElement(71, "input");
            __builder.AddAttribute(72, "form", "prodcode");
            __builder.AddAttribute(73, "class", "form-control");
            __builder.AddAttribute(74, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 57 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditPurchaseOrder.razor"
                                                                            pds.Site

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(75, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => pds.Site = __value, pds.Site));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                ");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "col-md-3");
            __builder.AddMarkupContent(81, "\r\n                    ");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "form-group");
            __builder.AddMarkupContent(84, "\r\n                        ");
            __builder.AddMarkupContent(85, "<label for=\"prodname\" class=\"control-label\" style=\"font-size: small;\">Posting Date</label>\r\n                        ");
            __builder.OpenElement(86, "input");
            __builder.AddAttribute(87, "form", "prodname");
            __builder.AddAttribute(88, "class", "form-control");
            __builder.AddAttribute(89, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 63 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditPurchaseOrder.razor"
                                                                            pds.Posting_Date

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(90, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => pds.Posting_Date = __value, pds.Posting_Date));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                ");
            __builder.OpenElement(94, "div");
            __builder.AddAttribute(95, "class", "col-md-3");
            __builder.AddMarkupContent(96, "\r\n                    ");
            __builder.OpenElement(97, "div");
            __builder.AddAttribute(98, "class", "form-group");
            __builder.AddMarkupContent(99, "\r\n                        ");
            __builder.AddMarkupContent(100, "<label for=\"packsize\" class=\"control-label\" style=\"font-size: small;\">Document Date</label>\r\n                        ");
            __builder.OpenElement(101, "input");
            __builder.AddAttribute(102, "form", "packsize");
            __builder.AddAttribute(103, "class", "form-control");
            __builder.AddAttribute(104, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 69 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditPurchaseOrder.razor"
                                                                            pds.Document_Date

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(105, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => pds.Document_Date = __value, pds.Document_Date));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n                ");
            __builder.OpenElement(109, "div");
            __builder.AddAttribute(110, "class", "col-md-3");
            __builder.AddMarkupContent(111, "\r\n                    ");
            __builder.OpenElement(112, "div");
            __builder.AddAttribute(113, "class", "form-group");
            __builder.AddMarkupContent(114, "\r\n                        ");
            __builder.AddMarkupContent(115, "<label for=\"masterbrand\" class=\"control-label\" style=\"font-size: small;\">Item Code</label>\r\n                        ");
            __builder.OpenElement(116, "input");
            __builder.AddAttribute(117, "form", "masterbrand");
            __builder.AddAttribute(118, "class", "form-control");
            __builder.AddAttribute(119, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 75 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditPurchaseOrder.razor"
                                                                               pds.Item_Code

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(120, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => pds.Item_Code = __value, pds.Item_Code));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n                ");
            __builder.OpenElement(124, "div");
            __builder.AddAttribute(125, "class", "col-md-4");
            __builder.AddMarkupContent(126, "\r\n                    ");
            __builder.OpenElement(127, "div");
            __builder.AddAttribute(128, "class", "form-group");
            __builder.AddMarkupContent(129, "\r\n                        ");
            __builder.AddMarkupContent(130, "<label for=\"masterbrandname\" class=\"control-label\" style=\"font-size: small;\">Item Description</label>\r\n                        ");
            __builder.OpenElement(131, "input");
            __builder.AddAttribute(132, "form", "masterbrandname");
            __builder.AddAttribute(133, "class", "form-control");
            __builder.AddAttribute(134, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 81 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditPurchaseOrder.razor"
                                                                                   pds.Item_Desc

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(135, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => pds.Item_Desc = __value, pds.Item_Desc));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n                ");
            __builder.OpenElement(139, "div");
            __builder.AddAttribute(140, "class", "col-md-4");
            __builder.AddMarkupContent(141, "\r\n                    ");
            __builder.OpenElement(142, "div");
            __builder.AddAttribute(143, "class", "form-group");
            __builder.AddMarkupContent(144, "\r\n                        ");
            __builder.AddMarkupContent(145, "<label for=\"masterbasepack\" class=\"control-label\" style=\"font-size: small;\">Quantity</label>\r\n                        ");
            __builder.OpenElement(146, "input");
            __builder.AddAttribute(147, "form", "masterbasepack");
            __builder.AddAttribute(148, "class", "form-control");
            __builder.AddAttribute(149, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 87 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditPurchaseOrder.razor"
                                                                                  pds.Quantity

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(150, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => pds.Quantity = __value, pds.Quantity));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\r\n                ");
            __builder.OpenElement(154, "div");
            __builder.AddAttribute(155, "class", "col-md-4");
            __builder.AddMarkupContent(156, "\r\n                    ");
            __builder.OpenElement(157, "div");
            __builder.AddAttribute(158, "class", "form-group");
            __builder.AddMarkupContent(159, "\r\n                        ");
            __builder.AddMarkupContent(160, "<label for=\"masterbasepackname\" class=\"control-label\" style=\"font-size: small;\">Uom</label>\r\n                        ");
            __builder.OpenElement(161, "select");
            __builder.AddAttribute(162, "form", "masterbasepackname");
            __builder.AddAttribute(163, "class", "form-control");
            __builder.AddAttribute(164, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 93 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditPurchaseOrder.razor"
                                                                                       pds.Uom

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(165, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => pds.Uom = __value, pds.Uom));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(166, "\r\n                            ");
            __builder.OpenElement(167, "option");
            __builder.AddAttribute(168, "class", true);
            __builder.AddAttribute(169, "disabled", true);
            __builder.AddAttribute(170, "selected", true);
            __builder.AddContent(171, "Choose");
            __builder.CloseElement();
            __builder.AddMarkupContent(172, "\r\n                            ");
            __builder.OpenElement(173, "option");
            __builder.AddAttribute(174, "class", "CS");
            __builder.AddContent(175, "CS");
            __builder.CloseElement();
            __builder.AddMarkupContent(176, "\r\n                            ");
            __builder.OpenElement(177, "option");
            __builder.AddAttribute(178, "class", "PC");
            __builder.AddContent(179, "PC");
            __builder.CloseElement();
            __builder.AddMarkupContent(180, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(181, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(182, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(183, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(184, "\r\n            ");
            __builder.OpenElement(185, "div");
            __builder.AddAttribute(186, "class", "row");
            __builder.AddMarkupContent(187, "\r\n                ");
            __builder.OpenElement(188, "div");
            __builder.AddAttribute(189, "class", "text-center");
            __builder.AddMarkupContent(190, "\r\n                    ");
            __builder.OpenElement(191, "input");
            __builder.AddAttribute(192, "type", "button");
            __builder.AddAttribute(193, "class", "btn btn-success");
            __builder.AddAttribute(194, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 103 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditPurchaseOrder.razor"
                                                                            insertsalesinvoice

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(195, "value", "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(196, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(197, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(198, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(199, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(200, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 110 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Pages\EditPurchaseOrder.razor"
       
    PurchaseHeaders po = new PurchaseHeaders();
    PurchaseDetails pds = new PurchaseDetails();
    PurchaseDetails[] pd;

    private HubConnection hubCon;

    [Parameter]
    public string id { get; set; }

    protected override async Task OnInitializedAsync()
    {
        po = await Http.GetJsonAsync<PurchaseHeaders>("api/PurchaseOrderHeadersIndex/" + id);
        pd = await Http.GetJsonAsync<PurchaseDetails[]>("api/PurchaseOrderDetailsIndex/" + id);

        hubCon = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/PurchaseDetailsHub"))
            .Build();

        await hubCon.StartAsync();
    }

    public bool IsConnected =>
        hubCon.State == HubConnectionState.Connected;

    public async Task insertsalesinvoice()
    {
        await Http.PostJsonAsync("api/PurchaseOrderDetailsIndex/" + id, pds);
        if (IsConnected) await SendMessage();
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
