// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorProject.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\_Imports.razor"
using BlazorProject.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\_Imports.razor"
using BlazorProject.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\_Imports.razor"
using BlazorProject.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Index - Copy.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Index - Copy.razor"
using System.Text.Json.Serialization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Index___Copy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Index - Copy.razor"
       

    public string CID_Dashboard { get; set; }
    public string CID_Dev { get; set; }
    public string CID_Prod { get; set; }
    protected override void OnInitialized()
    {
        CID_Dashboard = "SCAYfU2ZW0bmtfo";
        CID_Dev = "uSta6pVCW8WHNKc";
        CID_Prod = "XZ1XPFkDwanUoae";
        System.Diagnostics.Debug.WriteLine("Login Page Loaded");

        NavigationManager.LocationChanged += LocationChanged;
        //NavigationManager.NavigateTo($"https://api.bimsync.com/oauth2/authorize?client_id={CID_Dashboard}&response_type=code&redirect_uri=https://127.0.0.1");

        base.OnInitialized();
    }

    public void Goto() { NavigationManager.NavigateTo($"https://api.bimsync.com/oauth2/authorize?client_id={CID_Dashboard}&response_type=code&redirect_uri=https://localhost:44305/login"); }

    void LocationChanged(object sender, LocationChangedEventArgs e)
    {
        JSRuntime.InvokeVoidAsync("alert", "Navigation event triggered");
        string navigationMethod = e.IsNavigationIntercepted ? "HTML" : "code";
        System.Diagnostics.Debug.WriteLine($"Notified of navigation via {navigationMethod} to {e.Location}");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
