#pragma checksum "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1de2172829f1914c046252846091301130ee09a"
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
#line 2 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
using BlazorProject.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
using BlazorProject.Shared.ResponseClasses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
using System.Security.Cryptography;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/viewer/{projectId}")]
    public partial class Viewer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Viewer</h1>\r\n\r\n");
            __builder.OpenElement(1, "div");
#nullable restore
#line 13 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
     if (currentSelectedObject != null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "span");
            __builder.AddContent(3, 
#nullable restore
#line 15 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
               currentSelectedObject.Attributes.Name.Value

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, " - ");
            __builder.AddContent(5, 
#nullable restore
#line 15 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
                                                              currentSelectedObject.IfcType

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 16 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<span>ObjectInformation</span>");
#nullable restore
#line 20 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 23 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
 if (viewerResponse != null)
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
     if (!loaded)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "btn-group");
            __builder.AddAttribute(9, "role", "group");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "class", "btn btn-primary");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
                                                      load

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, "Load all objects from project");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 32 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "title", "Show all");
            __builder.AddAttribute(16, "class", "btn btn-secondary");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
                                                                     showAll

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, "Show all");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "title", "Hide all");
            __builder.AddAttribute(22, "class", "btn btn-secondary");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
                                                                     hideAll

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(24, "Hide all");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "btn-group");
            __builder.AddAttribute(28, "role", "group");
            __builder.OpenElement(29, "button");
            __builder.AddAttribute(30, "title", "Show selected");
            __builder.AddAttribute(31, "class", "buttoneye");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
                                                                      makeOpaque

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "title", "Translucent selected");
            __builder.AddAttribute(36, "class", "buttoneye");
            __builder.AddAttribute(37, "id", "eye2");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
                                                                                       makeTranslucent

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n            ");
            __builder.OpenElement(40, "button");
            __builder.AddAttribute(41, "title", "Hide selected");
            __builder.AddAttribute(42, "class", "buttoneye");
            __builder.AddAttribute(43, "id", "eye3");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
                                                                                hideSelected

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 42 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(45, "<div id=\"viewer-container\"></div>");
#nullable restore
#line 48 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "class", "btn btn-primary");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
                                              () => loadViewerToken()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(49, "Get Viewer");
            __builder.CloseElement();
#nullable restore
#line 52 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(50, "<br>\r\n");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "h2");
            __builder.AddContent(53, "ProjectId: ");
            __builder.AddContent(54, 
#nullable restore
#line 54 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
                            projectId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 55 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
 if (models == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(55, "button");
            __builder.AddAttribute(56, "class", "btn btn-primary");
            __builder.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
                                              loadModels

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(58, "Get list of models");
            __builder.CloseElement();
#nullable restore
#line 58 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
 if (models != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(59, "button");
            __builder.AddAttribute(60, "class", "btn btn-primary");
            __builder.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 61 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
                                              hideModels

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(62, "Hide list of models");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n    <br>");
            __builder.OpenElement(64, "table");
            __builder.OpenElement(65, "tr");
            __builder.OpenElement(66, "th");
            __builder.OpenElement(67, "button");
            __builder.AddAttribute(68, "class", "btn btn-success");
            __builder.AddAttribute(69, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 66 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
                                                          showAllModels

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(70, "Show all models");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n            ");
            __builder.OpenElement(72, "th");
            __builder.OpenElement(73, "button");
            __builder.AddAttribute(74, "class", "btn btn-danger");
            __builder.AddAttribute(75, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 67 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
                                                         hideAllModels

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(76, "Hide all models");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 69 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
         foreach (var model in models)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(77, "tr");
            __builder.OpenElement(78, "td");
            __builder.OpenElement(79, "button");
            __builder.AddAttribute(80, "class", "btn btn-success");
            __builder.AddAttribute(81, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 72 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
                                                              () => showModel(model.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(82, "Show ");
            __builder.AddContent(83, 
#nullable restore
#line 72 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
                                                                                               model.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                ");
            __builder.OpenElement(85, "td");
            __builder.OpenElement(86, "button");
            __builder.AddAttribute(87, "class", "btn btn-danger");
            __builder.AddAttribute(88, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
                                                             () => hideModel(model.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(89, "Hide ");
            __builder.AddContent(90, 
#nullable restore
#line 73 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
                                                                                              model.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 75 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 77 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 79 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
       

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
#line 143 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
                                                                                      
                await JSRuntime.InvokeVoidAsync("showModel", model.Id);
            }
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 146 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
                                                
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
#line 156 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
                                                                                      
                await JSRuntime.InvokeVoidAsync("hideModel", model.Id);
            }
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 159 "C:\Users\m.mastbergen\source\repos\test\BlazorWebAssemblyTest\BlazorProject\Client\Pages\Viewer.razor"
                                                
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
            await JSRuntime.InvokeVoidAsync("createAlert", "ID: " + currentSelectedObject.ObjectId + "\nType: " + currentSelectedObject.IfcType + "\nName: " + currentSelectedObject.Attributes.Name.Value + "\nObjectType: " + currentSelectedObject.Attributes.ObjectType.Value);
        }
    }
    async Task showAll()
    {
        await JSRuntime.InvokeVoidAsync("showAll");
    }
    async Task hideAll()
    {
        await JSRuntime.InvokeVoidAsync("hideAll");
    }
    async Task hideSelected()
    {
        if (currentSelectedObject != null)
        {
            foreach (var entity in selectedObjects)
            {
                await JSRuntime.InvokeVoidAsync("hideSelected", entity.ObjectId.ToString());
            }
        }
    }
    async Task makeTranslucent()
    {
        if (currentSelectedObject != null)
        {
            foreach (var entity in selectedObjects)
            {
                await JSRuntime.InvokeVoidAsync("translucent", entity.ObjectId.ToString());
            }
        }
    }
    async Task makeOpaque()
    {
        if (currentSelectedObject != null)
        {
            foreach (var entity in selectedObjects)
            {
                await JSRuntime.InvokeVoidAsync("opaque", entity.ObjectId.ToString());
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
