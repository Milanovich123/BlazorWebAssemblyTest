#pragma checksum "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Home.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b151c44c3125c74bc38cc5c88e31b7f9f8fa84ad"
// <auto-generated/>
#pragma warning disable 1591
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
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Home.razor"
using BlazorProject.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Home : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Home</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>BimSync 3D viewer by Milan Mastbergen.</p>\r\n\r\n\r\n");
            __builder.AddContent(2, 
#nullable restore
#line 12 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Home.razor"
 AppState.Message

#line default
#line hidden
#nullable disable
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Home.razor"
       

    protected override void OnInitialized()
    {
        AppState.OnChange += StateHasChanged;
    }

    public void Dispose()
    {
        AppState.OnChange -= StateHasChanged;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppState AppState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
