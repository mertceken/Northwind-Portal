#pragma checksum "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\DeletePages\DeleteShippers.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94f4c6758ea505565f239e4e3ad7db2c743f30ac"
// <auto-generated/>
#pragma warning disable 1591
namespace NorthwindCrudApp.Pages.DeletePages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\_Imports.razor"
using NorthwindCrudApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\_Imports.razor"
using NorthwindCrudApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\DeletePages\DeleteShippers.razor"
using NorthwindCrudApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/deleteshipper/{shipperId:int}")]
    public partial class DeleteShippers : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Delete Shippers</h3>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __Blazor.NorthwindCrudApp.Pages.DeletePages.DeleteShippers.TypeInference.CreateMatTextField_0(__builder, 2, 3, "CompanyName", 4, 
#nullable restore
#line 10 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\DeletePages\DeleteShippers.razor"
                                shippers.CompanyName

#line default
#line hidden
#nullable disable
            , 5, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => shippers.CompanyName = __value, shippers.CompanyName)), 6, () => shippers.CompanyName);
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.OpenElement(8, "p");
            __Blazor.NorthwindCrudApp.Pages.DeletePages.DeleteShippers.TypeInference.CreateMatTextField_1(__builder, 9, 10, "Phone", 11, 
#nullable restore
#line 13 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\DeletePages\DeleteShippers.razor"
                                shippers.Phone

#line default
#line hidden
#nullable disable
            , 12, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => shippers.Phone = __value, shippers.Phone)), 13, () => shippers.Phone);
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.OpenComponent<MatBlazor.MatButton>(15);
            __builder.AddAttribute(16, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\DeletePages\DeleteShippers.razor"
                     Delete

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(18, "Delete");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(19, "\r\n");
            __builder.OpenComponent<MatBlazor.MatButton>(20);
            __builder.AddAttribute(21, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\DeletePages\DeleteShippers.razor"
                     Cancel

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(23, "Cancel");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\DeletePages\DeleteShippers.razor"
       
    Shippers shippers = new Shippers();

    [Parameter]
    public int shipperId { get; set; }

    protected override async Task OnInitializedAsync()
    {
        if(shipperId!=0)
        {
            shippers = await shipperService.GetById(shipperId);
        }
    }

    protected async Task Delete()
    {
        await shipperService.DeleteShipper(shipperId);
         navigationManager.NavigateTo("/shipper");
    }
    void Cancel()
    {
         navigationManager.NavigateTo("/shipper");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NorthwindCrudApp.IService.IShipperService shipperService { get; set; }
    }
}
namespace __Blazor.NorthwindCrudApp.Pages.DeletePages.DeleteShippers
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatTextField_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
