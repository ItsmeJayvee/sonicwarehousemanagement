#pragma checksum "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Shared\Pagination.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33d8f245c738410147be2292da41811373ba9de9"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SonicWarehouseManagement.Client.Shared
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
    public partial class Pagination : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\jv.limbaroc\Desktop\SonicWMS\sonicwarehousemanagement\Client\Shared\Pagination.razor"
       
    [Parameter]
    public int CurrentPage { get; set; } = 1;
    [Parameter]
    public int TotalPagesQuantity { get; set; }
    [Parameter]
    public int Radius { get; set; } = 3;
    [Parameter]
    public EventCallback<int> SelectedPage { get; set; }
    List<LinkModel> links;


    protected override void OnParametersSet()
    {
        LoadPages();
    }

    private async Task SelectedPageInternal(LinkModel link)
    {
        if(link.Page == CurrentPage)
        {
            return;
        }

        if(!link.Enabled)
        {
            return;
        }

        CurrentPage = link.Page;
        await SelectedPage.InvokeAsync(link.Page);
    }

    private void LoadPages()
    {
        links = new List<LinkModel>();
        var isPreviousPageLinkEnabled = CurrentPage != 1;
        var previousPage = CurrentPage - 1;
        links.Add(new LinkModel(previousPage, isPreviousPageLinkEnabled, "Previous"));

        for(int i = 1; i <= TotalPagesQuantity; i++)
        {
            if(i >= CurrentPage - Radius && i <= CurrentPage + Radius)
            {
                links.Add(new LinkModel(i) { Active = CurrentPage == i });
            }
        }

        var isNextPageLinkEnabled = CurrentPage != TotalPagesQuantity;
        var nextPage = CurrentPage + 1;
        links.Add(new LinkModel(nextPage, isNextPageLinkEnabled, "Next"));
    }

    class LinkModel
    {
        public LinkModel(int page)
            : this(page, true) { }

        public LinkModel(int page, bool enabled)
            : this(page, enabled, page.ToString()) { }

        public LinkModel(int page, bool enabled, string text)
        {
            Page = page;
            Enabled = enabled;
            Text = text;
        }

        public string Text { get; set; }
        public int Page { get; set; }
        public bool Enabled { get; set; } = true;
        public bool Active { get; set; } = false;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
