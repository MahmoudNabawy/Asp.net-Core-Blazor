#pragma checksum "C:\Users\Mahmoud\Desktop\Blazor\BlazorServerSide\BlazorServerSide\Life Cycle Events\LifeCycleEventsIndexComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffe7ff3f8e21e8bbfb3ba60ae356dcf0e56e3007"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServerSide.Life_Cycle_Events
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Mahmoud\Desktop\Blazor\BlazorServerSide\BlazorServerSide\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mahmoud\Desktop\Blazor\BlazorServerSide\BlazorServerSide\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mahmoud\Desktop\Blazor\BlazorServerSide\BlazorServerSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mahmoud\Desktop\Blazor\BlazorServerSide\BlazorServerSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mahmoud\Desktop\Blazor\BlazorServerSide\BlazorServerSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Mahmoud\Desktop\Blazor\BlazorServerSide\BlazorServerSide\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Mahmoud\Desktop\Blazor\BlazorServerSide\BlazorServerSide\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Mahmoud\Desktop\Blazor\BlazorServerSide\BlazorServerSide\_Imports.razor"
using BlazorServerSide;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Mahmoud\Desktop\Blazor\BlazorServerSide\BlazorServerSide\_Imports.razor"
using BlazorServerSide.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Mahmoud\Desktop\Blazor\BlazorServerSide\BlazorServerSide\_Imports.razor"
using BlazorServerSide.Controlers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Mahmoud\Desktop\Blazor\BlazorServerSide\BlazorServerSide\_Imports.razor"
using BlazorServerSide.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Mahmoud\Desktop\Blazor\BlazorServerSide\BlazorServerSide\_Imports.razor"
using BlazorServerSide.Dependency_Injection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Mahmoud\Desktop\Blazor\BlazorServerSide\BlazorServerSide\_Imports.razor"
using BlazorServerSide.StateMangementWithFlux.Stores.CounterStore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/lifecycleeventsindex")]
    public partial class LifeCycleEventsIndexComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>LifeCycleEventsIndexComponent</h3>\r\n\r\n");
            __builder.OpenComponent<BlazorServerSide.Life_Cycle_Events.LifeCycleEventsChildComponent>(1);
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n\r\n<br>\r\n<br>\r\n\r\n");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "class", "btn");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\Mahmoud\Desktop\Blazor\BlazorServerSide\BlazorServerSide\Life Cycle Events\LifeCycleEventsIndexComponent.razor"
                              ClickMe

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(6, "ClickMe");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\Mahmoud\Desktop\Blazor\BlazorServerSide\BlazorServerSide\Life Cycle Events\LifeCycleEventsIndexComponent.razor"
       


    // The first three methods called twice in first established
    // because frist send request then recieve response
    // rhe signalR established and the recieve response again

    // Browser ========== Req ==========> Server
    // Browser <========== Res =========== Server
    // Browser ----------- SignalR -----------> Server
    // Browser <========== Res =========== Server

    //

    // 1
    public override Task SetParametersAsync(ParameterView parameters)
    {
        return base.SetParametersAsync(parameters);
    }

    // 2
    protected override void OnInitialized()
    {
        base.OnInitialized();
    }

    // 3
    protected override void OnParametersSet()
    {
        base.OnParametersSet();
    }

    /////////////////////////////////////////

    // 7
    protected override bool ShouldRender()
    {
        return base.ShouldRender();
    }

    // 8
    protected override void OnAfterRender(bool firstRender)
    {
        base.OnAfterRender(firstRender);
    }

    private void ClickMe()
    {

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
