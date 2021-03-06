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
