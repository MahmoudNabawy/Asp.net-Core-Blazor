#pragma checksum "C:\Users\Mahmoud\Desktop\Blazor\BlazorServerSide\BlazorServerSide\Controlers\FeildComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49ce974f94cd1208c723058d16fb36f4e15982f1"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServerSide.Controlers
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
    public partial class FeildComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "field is-horizontal");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "field-label is-normal");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "label");
            __builder.AddAttribute(7, "class", "label");
            __builder.AddContent(8, 
#nullable restore
#line 3 "C:\Users\Mahmoud\Desktop\Blazor\BlazorServerSide\BlazorServerSide\Controlers\FeildComponent.razor"
                              Label

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "field-body");
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "field");
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "p");
            __builder.AddAttribute(18, "class", "control");
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.AddContent(20, 
#nullable restore
#line 8 "C:\Users\Mahmoud\Desktop\Blazor\BlazorServerSide\BlazorServerSide\Controlers\FeildComponent.razor"
                 Control

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\Mahmoud\Desktop\Blazor\BlazorServerSide\BlazorServerSide\Controlers\FeildComponent.razor"
       
    [Parameter]
    public string Label { get; set; }

    [Parameter]
    public RenderFragment Control { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591