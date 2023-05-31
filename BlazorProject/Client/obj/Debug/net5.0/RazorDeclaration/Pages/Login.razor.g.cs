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
#line 2 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Login.razor"
using BlazorProject.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Login.razor"
using BlazorProject.Shared.ResponseClasses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Login.razor"
using System.Security.Cryptography;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Login.razor"
                                   
private string clientVerifier;
[Parameter]
public List<ProjectResponse>? projects { get; set; }
[Parameter]
public List<ModelResponse>? models { get; set; }

public List<Project> projectslist { get; set; }
public UserResponse user { get; set; }

bool LoggedIn = false;

[Parameter]
public string? auth_code { get; set; }
public string name { get; set; }

public string CID_Dashboard { get; set; }
public string CID_Dev { get; set; }
public string CID_Prod { get; set; }
public string redirect_uri { get; set; }
protected override void OnInitialized()
{
    checkLoggedIn();
    CID_Dashboard = "SCAYfU2ZW0bmtfo";
    CID_Dev = "uSta6pVCW8WHNKc";
    CID_Prod = "XZ1XPFkDwanUoae";
    redirect_uri = NavigationManager.BaseUri + "login";
    clientVerifier = GenerateVerifier();
    if (LoggedIn)
    {
        getProjects();
    }
    base.OnInitialized();
}

public void login() { NavigationManager.NavigateTo($"https://api.bimsync.com/oauth2/authorize?client_id={CID_Dev}&response_type=code&redirect_uri={NavigationManager.BaseUri}login"); }
public void logout() {
    projects = null;
    user = null;
    LoggedIn = false;
    AppState.LoggedIn = false;
    NavigationManager.NavigateTo("/login");
}


public void checkLoggedIn()
{
    if (AppState.LoggedIn)
    {
        LoggedIn = true;
    } else
    {
        string uri = NavigationManager.Uri;
        string sub = uri.Substring(uri.IndexOf('=') + 1);
        if (sub.Length == 10)//thiscouldbebad(checking if code is of length 10 to check if logged in..)
        {
            AppState.LoggedIn = true;
            LoggedIn = true;
        }
    }
}
public async void getProjects()
{
    string uri = NavigationManager.Uri;
    string sub = uri.Substring(uri.IndexOf('=') + 1);
    auth_code = sub;
    try
    {
        string token = await bim.GetTokens(auth_code, clientVerifier, redirect_uri);
        user = await bim.GetUser();
        AppState.UpdateUser(user);

        projects = await bim.GetProjects();
        StateHasChanged();
    }
    catch (Exception e)
    {
        JSRuntime.InvokeVoidAsync("alert", $"Error: {e.Message} at stacktrace: {e.StackTrace}");
    }

}
private void goToViewer(string projectId)
{
    NavigationManager.NavigateTo(NavigationManager.BaseUri + "viewer/" + projectId);
}
private string GenerateVerifier()
{
    var rng = RandomNumberGenerator.Create();

    var bytes = new byte[120];
    rng.GetBytes(bytes);

    var code_verifier = Convert.ToBase64String(bytes)
        .TrimEnd('=')
        .Replace('+', '-')
        .Replace('/', '_');

    return code_verifier;
}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppState AppState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BimsyncService bim { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
