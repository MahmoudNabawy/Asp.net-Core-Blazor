#pragma checksum "C:\Users\Mahmoud\Desktop\Blazor\BlazorServerSide\BlazorServerSide\Life Cycle Events Avoiding a Data Intialization PitFall\LifeCycleEventsAvoidingaDataIntializationPitFallChildComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aebec5a300099ab5b9922c6879a4dd6e51cfb9fd"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServerSide.Life_Cycle_Events_Avoiding_a_Data_Intialization_PitFall
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
    public partial class LifeCycleEventsAvoidingaDataIntializationPitFallChildComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>LifeCycleEventsAvoidingaDataIntializationPitFallChildComponent</h3>\r\n\r\n");
#nullable restore
#line 3 "C:\Users\Mahmoud\Desktop\Blazor\BlazorServerSide\BlazorServerSide\Life Cycle Events Avoiding a Data Intialization PitFall\LifeCycleEventsAvoidingaDataIntializationPitFallChildComponent.razor"
 if (this.Employee != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<h3>Employee Details:</h3>\r\n");
            __builder.OpenElement(2, "p");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddContent(4, 
#nullable restore
#line 7 "C:\Users\Mahmoud\Desktop\Blazor\BlazorServerSide\BlazorServerSide\Life Cycle Events Avoiding a Data Intialization PitFall\LifeCycleEventsAvoidingaDataIntializationPitFallChildComponent.razor"
     Employee.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(5, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.OpenElement(7, "p");
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.AddContent(9, 
#nullable restore
#line 10 "C:\Users\Mahmoud\Desktop\Blazor\BlazorServerSide\BlazorServerSide\Life Cycle Events Avoiding a Data Intialization PitFall\LifeCycleEventsAvoidingaDataIntializationPitFallChildComponent.razor"
     Employee.Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(10, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.OpenElement(12, "p");
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.AddContent(14, 
#nullable restore
#line 13 "C:\Users\Mahmoud\Desktop\Blazor\BlazorServerSide\BlazorServerSide\Life Cycle Events Avoiding a Data Intialization PitFall\LifeCycleEventsAvoidingaDataIntializationPitFallChildComponent.razor"
     Employee.Department

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(15, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 15 "C:\Users\Mahmoud\Desktop\Blazor\BlazorServerSide\BlazorServerSide\Life Cycle Events Avoiding a Data Intialization PitFall\LifeCycleEventsAvoidingaDataIntializationPitFallChildComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\Mahmoud\Desktop\Blazor\BlazorServerSide\BlazorServerSide\Life Cycle Events Avoiding a Data Intialization PitFall\LifeCycleEventsAvoidingaDataIntializationPitFallChildComponent.razor"
       

    [Parameter]
    public Employee Employee { get; set; }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        if(this.Employee != null) this.Employee.LoadRecords();
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591