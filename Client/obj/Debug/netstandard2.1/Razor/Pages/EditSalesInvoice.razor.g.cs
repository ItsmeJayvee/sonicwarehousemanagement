#pragma checksum "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\EditSalesInvoice.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6c91b7805a5183c8d79338c2120d603148c442f"
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<h2>Edit sales invoice</h2>\r\n    <hr>\r\n    ");
            __builder.OpenElement(4, "p");
            __builder.AddContent(5, "Sales Invoice: ");
            __builder.OpenElement(6, "b");
            __builder.AddContent(7, 
#nullable restore
#line 9 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\EditSalesInvoice.razor"
                          si.Invoice_No

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "p");
            __builder.AddContent(10, "Site: ");
            __builder.AddContent(11, 
#nullable restore
#line 10 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\EditSalesInvoice.razor"
              si.Site

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(12, " - ");
            __builder.AddContent(13, 
#nullable restore
#line 10 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\EditSalesInvoice.razor"
                         si.Distributor_Desc

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "p");
            __builder.AddContent(16, "Date: ");
            __builder.AddContent(17, 
#nullable restore
#line 11 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\EditSalesInvoice.razor"
              si.Calendar_Day

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    <hr>\r\n    ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "table-responsive");
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "table");
            __builder.AddAttribute(23, "class", "table");
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.AddMarkupContent(25, "<thead>\r\n                <tr>\r\n                    <th style=\"font-size: x-small;\">Item Id</th>\r\n                    <th style=\"font-size: x-small;\">Item Name</th>\r\n                    <th style=\"font-size: x-small;\">Pack Size</th>\r\n                    <th style=\"font-size: x-small;\">Brand</th>\r\n                    <th style=\"font-size: x-small;\">Brand Name</th>\r\n                    <th style=\"font-size: x-small;\">Basepack</th>\r\n                    <th style=\"font-size: x-small;\">Basepack Name</th>\r\n                    <th style=\"font-size: x-small;\">Lead Basepack</th>\r\n                    <th style=\"font-size: x-small;\">Sales CS</th>\r\n                    <th style=\"font-size: x-small;\">Sales PC</th>\r\n                    <th style=\"font-size: x-small;\">Free CS</th>\r\n                    <th style=\"font-size: x-small;\">Free PC</th>\r\n                    <th style=\"font-size: x-small;\">Sales Liter</th>\r\n                    <th style=\"font-size: x-small;\">Free Liter</th>\r\n                    <th style=\"font-size: x-small;\">Sales Aggr CS</th>\r\n                    <th style=\"font-size: x-small;\">Sales Aggr PC</th>\r\n                    <th style=\"font-size: x-small;\">Free Aggr CS</th>\r\n                    <th style=\"font-size: x-small;\">Free Aggr PC</th>\r\n                    <th style=\"font-size: x-small;\">GSV</th>\r\n                    <th style=\"font-size: x-small;\">TPR</th>\r\n                    <th style=\"font-size: x-small;\">UW</th>\r\n                    <th style=\"font-size: x-small;\">DT Discount</th>\r\n                    <th style=\"font-size: x-small;\">Sales After</th>\r\n                    <th style=\"font-size: x-small;\">Volume Discount</th>\r\n                    <th style=\"font-size: x-small;\">Coupon Discount</th>\r\n                    <th style=\"font-size: x-small;\">NIV</th>\r\n                    <th style=\"font-size: x-small;\">VAT</th>\r\n                    <th style=\"font-size: x-small;\">Total Sales</th>\r\n                    <th style=\"font-size: x-small;\">Aggr Pieces</th>\r\n                    <th style=\"font-size: x-small;\">Cabinet Count</th>\r\n                </tr>\r\n            </thead>\r\n            ");
            __builder.OpenElement(26, "tbody");
            __builder.AddMarkupContent(27, "\r\n");
#nullable restore
#line 50 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\EditSalesInvoice.razor"
                 if (sid == null)
                {
                    // do nothign
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\EditSalesInvoice.razor"
                     foreach (var items in sid)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(28, "                        ");
            __builder.OpenElement(29, "tr");
            __builder.AddMarkupContent(30, "\r\n                            ");
            __builder.OpenElement(31, "td");
            __builder.AddAttribute(32, "style", "font-size: x-small;");
            __builder.AddContent(33, 
#nullable restore
#line 59 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\EditSalesInvoice.razor"
                                                             items.Product_Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                            ");
            __builder.OpenElement(35, "td");
            __builder.AddAttribute(36, "style", "font-size: x-small;");
            __builder.AddContent(37, 
#nullable restore
#line 60 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\EditSalesInvoice.razor"
                                                             items.Product_Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                            ");
            __builder.OpenElement(39, "td");
            __builder.AddAttribute(40, "style", "font-size: x-small;");
            __builder.AddContent(41, 
#nullable restore
#line 61 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\EditSalesInvoice.razor"
                                                             items.Pack_Size

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                            ");
            __builder.OpenElement(43, "td");
            __builder.AddAttribute(44, "style", "font-size: x-small;");
            __builder.AddContent(45, 
#nullable restore
#line 62 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\EditSalesInvoice.razor"
                                                             items.Master_Brand

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                            ");
            __builder.OpenElement(47, "td");
            __builder.AddAttribute(48, "style", "font-size: x-small;");
            __builder.AddContent(49, 
#nullable restore
#line 63 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\EditSalesInvoice.razor"
                                                             items.Master_Brand_Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                            ");
            __builder.OpenElement(51, "td");
            __builder.AddAttribute(52, "style", "font-size: x-small;");
            __builder.AddContent(53, 
#nullable restore
#line 64 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\EditSalesInvoice.razor"
                                                             items.Master_Basepack

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                            ");
            __builder.OpenElement(55, "td");
            __builder.AddAttribute(56, "style", "font-size: x-small;");
            __builder.AddContent(57, 
#nullable restore
#line 65 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\EditSalesInvoice.razor"
                                                             items.Master_Basepack_Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                            ");
            __builder.OpenElement(59, "td");
            __builder.AddAttribute(60, "style", "font-size: x-small;");
            __builder.AddContent(61, 
#nullable restore
#line 66 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\EditSalesInvoice.razor"
                                                             items.Lead_Basepack

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                            ");
            __builder.OpenElement(63, "td");
            __builder.AddAttribute(64, "style", "font-size: x-small;");
            __builder.AddContent(65, 
#nullable restore
#line 67 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\EditSalesInvoice.razor"
                                                             items.Sales_Qty_CS

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                            ");
            __builder.OpenElement(67, "td");
            __builder.AddAttribute(68, "style", "font-size: x-small;");
            __builder.AddContent(69, 
#nullable restore
#line 68 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\EditSalesInvoice.razor"
                                                             items.Sales_Qty_PC

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                            ");
            __builder.OpenElement(71, "td");
            __builder.AddAttribute(72, "style", "font-size: x-small;");
            __builder.AddContent(73, 
#nullable restore
#line 69 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\EditSalesInvoice.razor"
                                                             items.Free_Qty_CS

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                            ");
            __builder.OpenElement(75, "td");
            __builder.AddAttribute(76, "style", "font-size: x-small;");
            __builder.AddContent(77, 
#nullable restore
#line 70 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\EditSalesInvoice.razor"
                                                             items.Free_Qty_PC

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                            ");
            __builder.OpenElement(79, "td");
            __builder.AddAttribute(80, "style", "font-size: x-small;");
            __builder.AddContent(81, 
#nullable restore
#line 71 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\EditSalesInvoice.razor"
                                                             items.Sales_Qty_Liter

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                            ");
            __builder.OpenElement(83, "td");
            __builder.AddAttribute(84, "style", "font-size: x-small;");
            __builder.AddContent(85, 
#nullable restore
#line 72 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\EditSalesInvoice.razor"
                                                             items.Free_Qty_Liter

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                            ");
            __builder.OpenElement(87, "td");
            __builder.AddAttribute(88, "style", "font-size: x-small;");
            __builder.AddContent(89, 
#nullable restore
#line 73 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\EditSalesInvoice.razor"
                                                             items.Sales_Qty_Aggr_CS

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                            ");
            __builder.OpenElement(91, "td");
            __builder.AddAttribute(92, "style", "font-size: x-small;");
            __builder.AddContent(93, 
#nullable restore
#line 74 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\EditSalesInvoice.razor"
                                                             items.Sales_Qty_Aggr_PC

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n                            ");
            __builder.OpenElement(95, "td");
            __builder.AddAttribute(96, "style", "font-size: x-small;");
            __builder.AddContent(97, 
#nullable restore
#line 75 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\EditSalesInvoice.razor"
                                                             items.Free_Qty_Aggr_CS

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n                            ");
            __builder.OpenElement(99, "td");
            __builder.AddAttribute(100, "style", "font-size: x-small;");
            __builder.AddContent(101, 
#nullable restore
#line 76 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\EditSalesInvoice.razor"
                                                             items.Free_Qty_Aggr_PC

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n                            ");
            __builder.OpenElement(103, "td");
            __builder.AddAttribute(104, "style", "font-size: x-small;");
            __builder.AddContent(105, 
#nullable restore
#line 77 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\EditSalesInvoice.razor"
                                                             items.GSV

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n                            ");
            __builder.OpenElement(107, "td");
            __builder.AddAttribute(108, "style", "font-size: x-small;");
            __builder.AddContent(109, 
#nullable restore
#line 78 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\EditSalesInvoice.razor"
                                                             items.TPR

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n                            ");
            __builder.OpenElement(111, "td");
            __builder.AddAttribute(112, "style", "font-size: x-small;");
            __builder.AddContent(113, 
#nullable restore
#line 79 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\EditSalesInvoice.razor"
                                                             items.UW

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n                            ");
            __builder.OpenElement(115, "td");
            __builder.AddAttribute(116, "style", "font-size: x-small;");
            __builder.AddContent(117, 
#nullable restore
#line 80 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\EditSalesInvoice.razor"
                                                             items.DT_Discount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n                            ");
            __builder.OpenElement(119, "td");
            __builder.AddAttribute(120, "style", "font-size: x-small;");
            __builder.AddContent(121, 
#nullable restore
#line 81 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\EditSalesInvoice.razor"
                                                             items.Sales_After

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n                            ");
            __builder.OpenElement(123, "td");
            __builder.AddAttribute(124, "style", "font-size: x-small;");
            __builder.AddContent(125, 
#nullable restore
#line 82 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\EditSalesInvoice.razor"
                                                             items.Volume_Discount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n                            ");
            __builder.OpenElement(127, "td");
            __builder.AddAttribute(128, "style", "font-size: x-small;");
            __builder.AddContent(129, 
#nullable restore
#line 83 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\EditSalesInvoice.razor"
                                                             items.Coupon_Discount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n                            ");
            __builder.OpenElement(131, "td");
            __builder.AddAttribute(132, "style", "font-size: x-small;");
            __builder.AddContent(133, 
#nullable restore
#line 84 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\EditSalesInvoice.razor"
                                                             items.NIV

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n                            ");
            __builder.OpenElement(135, "td");
            __builder.AddAttribute(136, "style", "font-size: x-small;");
            __builder.AddContent(137, 
#nullable restore
#line 85 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\EditSalesInvoice.razor"
                                                             items.VAT

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n                            ");
            __builder.OpenElement(139, "td");
            __builder.AddAttribute(140, "style", "font-size: x-small;");
            __builder.AddContent(141, 
#nullable restore
#line 86 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\EditSalesInvoice.razor"
                                                             items.Total_Sales_Amnt_Inc

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n                            ");
            __builder.OpenElement(143, "td");
            __builder.AddAttribute(144, "style", "font-size: x-small;");
            __builder.AddContent(145, 
#nullable restore
#line 87 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\EditSalesInvoice.razor"
                                                             items.Aggr_Pieces

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(146, "\r\n                            ");
            __builder.OpenElement(147, "td");
            __builder.AddAttribute(148, "style", "font-size: x-small;");
            __builder.AddContent(149, 
#nullable restore
#line 88 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\EditSalesInvoice.razor"
                                                             items.Cabinet_Count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n");
#nullable restore
#line 90 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\EditSalesInvoice.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\EditSalesInvoice.razor"
                     
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(152, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(154, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(155, "\r\n    <hr>\r\n    ");
            __builder.OpenElement(156, "div");
            __builder.AddAttribute(157, "class", "col-md-4");
            __builder.AddMarkupContent(158, "\r\n        ");
            __builder.OpenElement(159, "div");
            __builder.AddAttribute(160, "class", "form-group");
            __builder.AddMarkupContent(161, "\r\n            ");
            __builder.OpenElement(162, "input");
            __builder.AddAttribute(163, "type", "button");
            __builder.AddAttribute(164, "class", "btn btn-success");
            __builder.AddAttribute(165, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 98 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\EditSalesInvoice.razor"
                                                                    updatesalesinvoice

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(166, "value", "Update");
            __builder.CloseElement();
            __builder.AddMarkupContent(167, "\r\n            ");
            __builder.OpenElement(168, "input");
            __builder.AddAttribute(169, "type", "button");
            __builder.AddAttribute(170, "class", "btn btn-danger");
            __builder.AddAttribute(171, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 99 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\EditSalesInvoice.razor"
                                                                   cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(172, "value", "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(173, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(174, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(175, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 104 "C:\Users\jv.limbaroc\Desktop\git\sonicwarehousemanagement\Client\Pages\EditSalesInvoice.razor"
           
    SalesInvoice_Headers si = new SalesInvoice_Headers();
    SalesInvoice_Details[] sid;

    private HubConnection hubCon;

    [Parameter]
    public string id { get; set; }

    protected override async Task OnInitializedAsync()
    {
        si = await Http.GetJsonAsync<SalesInvoice_Headers>("api/SalesInvoiceHeaders/" + id);
        sid = await Http.GetJsonAsync<SalesInvoice_Details[]>("api/SalesInvoiceDetailsIndex/" + id);

        hubCon = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/SalesInvoiceHeadersHub"))
            .Build();

        await hubCon.StartAsync();
    }

    public bool IsConnected =>
        hubCon.State == HubConnectionState.Connected;

    public async Task updatesalesinvoice()
    {
        await Http.PutJsonAsync("api/SalesInvoiceHeaders/" + id, si);
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
