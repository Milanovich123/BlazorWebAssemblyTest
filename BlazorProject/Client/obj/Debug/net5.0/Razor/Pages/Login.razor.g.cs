#pragma checksum "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc737766dd385e433416f8b31777d85c4926dfa0"
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
#line 2 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Login.razor"
using BlazorProject.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Login.razor"
using BlazorProject.Shared.ResponseClasses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Login.razor"
using System.Security.Cryptography;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 9 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Login.razor"
 if (projects == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<h1>Connect to BimSync to proceed</h1>\r\n    <br>");
#nullable restore
#line 13 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Login.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Login.razor"
     if (user != null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "h1");
            __builder.AddContent(2, "Hello ");
            __builder.AddContent(3, 
#nullable restore
#line 18 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Login.razor"
                   user.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(4, " ");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Login.razor"
                                                                            logout

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Log out");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        <br>");
#nullable restore
#line 20 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Login.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Login.razor"
     
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Login.razor"
 if (projects != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(10, "<h3>\r\n        Projects:\r\n    </h3>");
#nullable restore
#line 27 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Login.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "ul");
#nullable restore
#line 29 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Login.razor"
     if (projects == null)
    {
    }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Login.razor"
         foreach (var project in projects)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "li");
            __builder.AddAttribute(13, "style", " font-size:24px");
            __builder.AddContent(14, 
#nullable restore
#line 36 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Login.razor"
                                          project.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "class", "btn btn-primary");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Login.razor"
                                                      () => goToViewer(project.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(19, "View project");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n            <br>");
#nullable restore
#line 39 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Login.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Login.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 43 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Login.razor"
 if (!LoggedIn)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "class", "btn btn-primary");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Login.razor"
                                              login

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(24, "Log In");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n    <br>");
#nullable restore
#line 49 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Login.razor"
                
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Login.razor"
                                   
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