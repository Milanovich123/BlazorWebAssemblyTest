#pragma checksum "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23266a190799d427a1348f142dc15d59b7cbaa90"
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
#line 2 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
using BlazorProject.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
using BlazorProject.Shared.ResponseClasses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
using System.Security.Cryptography;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/viewer/{projectId}")]
    public partial class Viewer : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Viewer</h1>\r\n\r\n");
            __builder.OpenElement(1, "div");
#nullable restore
#line 13 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
     if (currentSelectedObject != null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "span");
#nullable restore
#line 15 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
__builder.AddContent(3, currentSelectedObject.Attributes["Name"].Value);

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, " - ");
#nullable restore
#line 15 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
__builder.AddContent(5, currentSelectedObject.IfcType);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 16 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<span>ObjectInformation</span>");
#nullable restore
#line 20 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 23 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
 if (viewerResponse != null)
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
     if (!loaded)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "class", "btn btn-primary");
            __builder.AddAttribute(9, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
                                                  load

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(10, "Load all objects from project");
            __builder.CloseElement();
#nullable restore
#line 29 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "title", "Show all");
            __builder.AddAttribute(13, "class", "btn btn-secondary");
            __builder.AddAttribute(14, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
                                                                     showAll

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(15, "Show all");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "title", "Hide all");
            __builder.AddAttribute(19, "class", "btn btn-secondary");
            __builder.AddAttribute(20, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
                                                                     hideOther

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(21, "Hide all");
            __builder.CloseElement();
#nullable restore
#line 34 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "id", "viewer-container");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "btn-group");
            __builder.AddAttribute(26, "role", "group");
            __builder.AddMarkupContent(27, "<button title=\"Models\" class=\"buttoncube\"></button>\r\n\r\n            ");
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "title", "Toon alles");
            __builder.AddAttribute(30, "class", "buttoneye");
            __builder.AddAttribute(31, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
                                                                   showAll

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "title", "Toon geselecteerde");
            __builder.AddAttribute(35, "class", "dropbtn");
            __builder.AddAttribute(36, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
                                                                         showSelected

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "title", "Maak transparant");
            __builder.AddAttribute(40, "class", "buttoneye");
            __builder.AddAttribute(41, "id", "eye2");
            __builder.AddAttribute(42, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
                                                                                   makeTranslucent

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n            ");
            __builder.OpenElement(44, "button");
            __builder.AddAttribute(45, "title", "Maak anderen transparant");
            __builder.AddAttribute(46, "class", "dropbtn");
            __builder.AddAttribute(47, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
                                                                               translucentAll

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.OpenElement(49, "button");
            __builder.AddAttribute(50, "title", "Verberg geselecteerde");
            __builder.AddAttribute(51, "class", "buttoneye");
            __builder.AddAttribute(52, "id", "eye3");
            __builder.AddAttribute(53, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
                                                                                        hideSelected

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n            ");
            __builder.OpenElement(55, "button");
            __builder.AddAttribute(56, "title", "Verberg anderen");
            __builder.AddAttribute(57, "class", "dropbtn");
            __builder.AddAttribute(58, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
                                                                      hideOther

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 49 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(59, "button");
            __builder.AddAttribute(60, "class", "btn btn-primary");
            __builder.AddAttribute(61, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
                                              () => loadViewerToken()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(62, "Get Viewer");
            __builder.CloseElement();
#nullable restore
#line 53 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(63, "<br>\r\n");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "h2");
            __builder.AddContent(66, "ProjectId: ");
#nullable restore
#line 55 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
__builder.AddContent(67, projectId);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 56 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
 if (models == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(68, "button");
            __builder.AddAttribute(69, "class", "btn btn-primary");
            __builder.AddAttribute(70, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
                                              loadModels

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(71, "Get list of models");
            __builder.CloseElement();
#nullable restore
#line 59 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
 if (models != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(72, "button");
            __builder.AddAttribute(73, "class", "btn btn-primary");
            __builder.AddAttribute(74, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
                                              hideModels

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(75, "Hide list of models");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n    <br>");
            __builder.OpenElement(77, "table");
            __builder.OpenElement(78, "tr");
            __builder.OpenElement(79, "th");
            __builder.OpenElement(80, "button");
            __builder.AddAttribute(81, "class", "btn btn-success");
            __builder.AddAttribute(82, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 67 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
                                                          showAllModels

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(83, "Show all models");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n            ");
            __builder.OpenElement(85, "th");
            __builder.OpenElement(86, "button");
            __builder.AddAttribute(87, "class", "btn btn-danger");
            __builder.AddAttribute(88, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 68 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
                                                         hideAllModels

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(89, "Hide all models");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 70 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
         foreach (var model in models)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(90, "tr");
            __builder.OpenElement(91, "td");
            __builder.OpenElement(92, "button");
            __builder.AddAttribute(93, "class", "btn btn-success");
            __builder.AddAttribute(94, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
                                                              () => showModel(model.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(95, "Show ");
#nullable restore
#line 73 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
__builder.AddContent(96, model.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n                ");
            __builder.OpenElement(98, "td");
            __builder.OpenElement(99, "button");
            __builder.AddAttribute(100, "class", "btn btn-danger");
            __builder.AddAttribute(101, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 74 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
                                                             () => hideModel(model.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(102, "Hide ");
#nullable restore
#line 74 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
__builder.AddContent(103, model.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 76 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 78 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 80 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
       

    [Parameter]
    public string projectId { get; set; }

    public static string objectId = "placeholder";

    [Parameter]
    public List<ModelResponse>? models { get; set; }

    public ViewerResponse viewerResponse { get; set; }

    public EntityResponse currentSelectedObject { get; set; }
    public IEnumerable<EntityResponse> selectedObjects { get; set; }

    public string? token { get; set; }
    public bool loaded = false;
    public HttpClient httpClient;

    protected override async Task OnInitializedAsync()
    {
        ChangeParaContentActionAsync = LocalChangeParaContentValueAsync;
        var client = _clientFactory.CreateClient();
        if (bim.tokenResponse != null)
        {
            token = bim.tokenResponse.access_token;
        }
        loadViewerToken();
    }



    private async void loadModels()
    {
        try
        {
            models = await bim.GetModels(projectId);
            StateHasChanged();
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message} at stacktrace: {e.StackTrace}");
            JSRuntime.InvokeVoidAsync("alert", $"Please login first");
        }
    }
    private void hideModels()
    {
        models = null;
    }

    async Task load()
    {
        JSRuntime.InvokeVoidAsync("log", "Loading models from this url: " + viewerResponse.Url);
        await JSRuntime.InvokeVoidAsync("createViewer", viewerResponse.Url);
        loaded = true;
    }

    async Task showAllModels()
    {
        if (models != null)
        {
            List<Task> listOfTasks = new List<Task>();
            foreach (var model in models)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 144 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
                                                                                      
                await JSRuntime.InvokeVoidAsync("showModel", model.Id);
            }
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 147 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
                                                
        }
    }
    async Task hideAllModels()
    {
        if (models != null)
        {
            List<Task> listOfTasks = new List<Task>();
            foreach (var model in models)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 157 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
                                                                                      
                await JSRuntime.InvokeVoidAsync("hideModel", model.Id);
            }
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 160 "\\FS01\USERS$\m.mastbergen\Documents\GitHub\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
                                                
        }
    }
    async Task showModel(string id)
    {
        await JSRuntime.InvokeVoidAsync("showModel", id);
    }
    async Task hideModel(string id)
    {
        await JSRuntime.InvokeVoidAsync("hideModel", id);
    }
    async Task entity()
    {
        if (currentSelectedObject != null)
        {
            await getEntity();
            await JSRuntime.InvokeVoidAsync("createAlert", "ID: " + currentSelectedObject.ObjectId + "\nType: " + currentSelectedObject.IfcType + "\nName: " + currentSelectedObject.Attributes["Name"].Value + "\nObjectType: " + currentSelectedObject.Attributes["ObjectType"].Value);
        }
    }
    async Task showAll()
    {
        await JSRuntime.InvokeVoidAsync("showAll");
    }
    async Task translucentAll()
    {
        var idArray = selectedObjects?.Select(entity => entity.ObjectId.ToString()).ToArray();
        await JSRuntime.InvokeVoidAsync("translucentAll", idArray ?? new string[] { "" });
    }
    async Task hideOther()
    {
        var idArray = selectedObjects?.Select(entity => entity.ObjectId.ToString()).ToArray();
        await JSRuntime.InvokeVoidAsync("hideOther", idArray ?? new string[] { "" });
    }

    async Task hideSelected()
    {
        if (currentSelectedObject != null)
        {
            var idArray = selectedObjects.Select(entity => entity.ObjectId.ToString()).ToArray();
            await JSRuntime.InvokeVoidAsync("hideSelected", idArray);
        }
    }
    async Task makeTranslucent()
    {
        if (currentSelectedObject != null)
        {
            var idArray = selectedObjects.Select(entity => entity.ObjectId.ToString()).ToArray();
            await JSRuntime.InvokeVoidAsync("translucent", idArray);
        }
    }
    async Task showSelected()
    {
        if (currentSelectedObject != null)
        {
            if (currentSelectedObject != null)
            {
                var idArray = selectedObjects.Select(entity => entity.ObjectId.ToString()).ToArray();
                await JSRuntime.InvokeVoidAsync("showSelected", idArray);
            }
        }
    }

    private async void loadViewerToken(ModelResponse model = null)
    {
        try
        {
            if (model != null)
            {
                JSRuntime.InvokeVoidAsync("log", "Trying to make viewer token for model: " + model.Name);
                viewerResponse = await bim.GetViewerToken(projectId, model);
                JSRuntime.InvokeVoidAsync("log", "viewerResponse created: " + viewerResponse.Token);
            }
            else
            {
                JSRuntime.InvokeVoidAsync("log", "Trying to make viewer token for project: " + projectId);
                viewerResponse = await bim.GetViewerToken(projectId, model);
                JSRuntime.InvokeVoidAsync("log", "viewerResponse created: " + viewerResponse.Token);
            }
            //await load();
            StateHasChanged();
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message} at stacktrace: {e.StackTrace}");
            JSRuntime.InvokeVoidAsync("alert", $"Error: {e.Message} at stacktrace: {e.StackTrace}");
        }
    }

    [JSInvokable]
    public static async Task ChangeParaContentValue(string value)
    {
        await ChangeParaContentActionAsync.Invoke(value);
    }
    private static Func<string, Task> ChangeParaContentActionAsync;

    private async Task LocalChangeParaContentValueAsync(string value)
    {
        if (value == null || value == "")
        {
            currentSelectedObject = null;
        }
        else
        {
            objectId = value;
            await getEntity();
            StateHasChanged();
        }
    }

    public async Task getEntity()
    {

        List<Task<EntityResponse>> listOfTasks = new List<Task<EntityResponse>>();
        selectedObjects = new List<EntityResponse>();
        if (projectId == null || objectId == null)
        {
            currentSelectedObject = null;
        }
        else
        {
            List<string> idList = new List<string>();
            idList = objectId.Split(',').ToList();
            foreach (var id in idList)
            {
                listOfTasks.Add(bim.GetObject(projectId, id));
            }
            selectedObjects = await Task.WhenAll<EntityResponse>(listOfTasks);
            currentSelectedObject = selectedObjects.First();
        }
    }

    public void giveAlert(string message)
    {
        JSRuntime.InvokeVoidAsync("createAlert", message);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory _clientFactory { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BimsyncService bim { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
