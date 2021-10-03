#pragma checksum "C:\Users\Mahmoud\Desktop\Blazor\BlazorServerSide\BlazorServerSide\StateMangementWithFlux\StateMangementWithFluxCounter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9156624cf25c7ba655af4bcbaab7c07d474d8f6f"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServerSide.StateMangementWithFlux
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/statemangementwithfluxcounter")]
    public partial class StateMangementWithFluxCounter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#nullable restore
#line 6 "C:\Users\Mahmoud\Desktop\Blazor\BlazorServerSide\BlazorServerSide\StateMangementWithFlux\StateMangementWithFluxCounter.razor"
                   counterStore.GetState().Count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Mahmoud\Desktop\Blazor\BlazorServerSide\BlazorServerSide\StateMangementWithFlux\StateMangementWithFluxCounter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Click me");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\Mahmoud\Desktop\Blazor\BlazorServerSide\BlazorServerSide\StateMangementWithFlux\StateMangementWithFluxCounter.razor"
        
    
    protected override void OnInitialized()
    {
        base.OnInitialized();

        counterStore.AddStateChangeListeners(() => { StateHasChanged(); });
    }

    private void IncrementCount()
    {
        counterStore.IncrementCount();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CounterStore counterStore { get; set; }
    }
}
#pragma warning restore 1591
