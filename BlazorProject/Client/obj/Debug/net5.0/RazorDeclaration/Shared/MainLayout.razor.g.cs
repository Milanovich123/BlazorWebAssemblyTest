// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorProject.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\_Imports.razor"
using BlazorProject.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\_Imports.razor"
using BlazorProject.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Shared\MainLayout.razor"
using BlazorProject.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Shared\MainLayout.razor"
       
    protected override void OnInitialized()
    {
        AppState.OnChange += StateHasChanged;
    }

    public void Dispose()
    {
        AppState.OnChange -= StateHasChanged;
    }
    void UpdateEnabledButtonClicked()
    {
        if (AppState.Enabled)
        {
            AppState.UpdateEnabled(false);
        }
        else
        {
            AppState.UpdateEnabled(true);
        }
    }
    void Logout()
    {
        AppState.LoggedIn = false;
        AppState.UpdateUser(null);
        NavigationManager.NavigateTo("/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppState AppState { get; set; }
    }
}
#pragma warning restore 1591
