#pragma checksum "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\DeletePages\DeleteSuppliers.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2856f5c1bc72cabb9b690fa09d2d735a114b9750"
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
#line 3 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\DeletePages\DeleteSuppliers.razor"
using NorthwindCrudApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/deletesupplier/{supplierId:int}")]
    public partial class DeleteSuppliers : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "p");
            __Blazor.NorthwindCrudApp.Pages.DeletePages.DeleteSuppliers.TypeInference.CreateMatTextField_0(__builder, 1, 2, "Company Name", 3, 
#nullable restore
#line 7 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\DeletePages\DeleteSuppliers.razor"
                                supplier.CompanyName

#line default
#line hidden
#nullable disable
            , 4, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => supplier.CompanyName = __value, supplier.CompanyName)), 5, () => supplier.CompanyName);
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.OpenElement(7, "p");
            __Blazor.NorthwindCrudApp.Pages.DeletePages.DeleteSuppliers.TypeInference.CreateMatTextField_1(__builder, 8, 9, "Contact Name", 10, 
#nullable restore
#line 10 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\DeletePages\DeleteSuppliers.razor"
                                supplier.ContactName

#line default
#line hidden
#nullable disable
            , 11, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => supplier.ContactName = __value, supplier.ContactName)), 12, () => supplier.ContactName);
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
            __builder.OpenElement(14, "p");
            __Blazor.NorthwindCrudApp.Pages.DeletePages.DeleteSuppliers.TypeInference.CreateMatTextField_2(__builder, 15, 16, "Contact Title", 17, 
#nullable restore
#line 13 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\DeletePages\DeleteSuppliers.razor"
                                supplier.ContactTitle

#line default
#line hidden
#nullable disable
            , 18, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => supplier.ContactTitle = __value, supplier.ContactTitle)), 19, () => supplier.ContactTitle);
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
            __builder.OpenElement(21, "p");
            __Blazor.NorthwindCrudApp.Pages.DeletePages.DeleteSuppliers.TypeInference.CreateMatTextField_3(__builder, 22, 23, "Address", 24, 
#nullable restore
#line 16 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\DeletePages\DeleteSuppliers.razor"
                                supplier.Address

#line default
#line hidden
#nullable disable
            , 25, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => supplier.Address = __value, supplier.Address)), 26, () => supplier.Address);
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
            __builder.OpenElement(28, "p");
            __Blazor.NorthwindCrudApp.Pages.DeletePages.DeleteSuppliers.TypeInference.CreateMatTextField_4(__builder, 29, 30, "City", 31, 
#nullable restore
#line 19 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\DeletePages\DeleteSuppliers.razor"
                                supplier.City

#line default
#line hidden
#nullable disable
            , 32, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => supplier.City = __value, supplier.City)), 33, () => supplier.City);
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
            __builder.OpenElement(35, "p");
            __Blazor.NorthwindCrudApp.Pages.DeletePages.DeleteSuppliers.TypeInference.CreateMatTextField_5(__builder, 36, 37, "Region", 38, 
#nullable restore
#line 22 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\DeletePages\DeleteSuppliers.razor"
                                supplier.Region

#line default
#line hidden
#nullable disable
            , 39, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => supplier.Region = __value, supplier.Region)), 40, () => supplier.Region);
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
            __builder.OpenElement(42, "p");
            __Blazor.NorthwindCrudApp.Pages.DeletePages.DeleteSuppliers.TypeInference.CreateMatTextField_6(__builder, 43, 44, "PostalCode", 45, 
#nullable restore
#line 25 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\DeletePages\DeleteSuppliers.razor"
                                supplier.PostalCode

#line default
#line hidden
#nullable disable
            , 46, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => supplier.PostalCode = __value, supplier.PostalCode)), 47, () => supplier.PostalCode);
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n");
            __builder.OpenElement(49, "p");
            __Blazor.NorthwindCrudApp.Pages.DeletePages.DeleteSuppliers.TypeInference.CreateMatTextField_7(__builder, 50, 51, "Country", 52, 
#nullable restore
#line 28 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\DeletePages\DeleteSuppliers.razor"
                                supplier.Country

#line default
#line hidden
#nullable disable
            , 53, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => supplier.Country = __value, supplier.Country)), 54, () => supplier.Country);
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n");
            __builder.OpenElement(56, "p");
            __Blazor.NorthwindCrudApp.Pages.DeletePages.DeleteSuppliers.TypeInference.CreateMatTextField_8(__builder, 57, 58, "Phone", 59, 
#nullable restore
#line 31 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\DeletePages\DeleteSuppliers.razor"
                                supplier.Phone

#line default
#line hidden
#nullable disable
            , 60, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => supplier.Phone = __value, supplier.Phone)), 61, () => supplier.Phone);
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n");
            __builder.OpenElement(63, "p");
            __Blazor.NorthwindCrudApp.Pages.DeletePages.DeleteSuppliers.TypeInference.CreateMatTextField_9(__builder, 64, 65, "Fax", 66, 
#nullable restore
#line 34 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\DeletePages\DeleteSuppliers.razor"
                                supplier.Fax

#line default
#line hidden
#nullable disable
            , 67, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => supplier.Fax = __value, supplier.Fax)), 68, () => supplier.Fax);
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n");
            __builder.OpenElement(70, "p");
            __Blazor.NorthwindCrudApp.Pages.DeletePages.DeleteSuppliers.TypeInference.CreateMatTextField_10(__builder, 71, 72, "Home Page", 73, 
#nullable restore
#line 37 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\DeletePages\DeleteSuppliers.razor"
                                supplier.HomePage

#line default
#line hidden
#nullable disable
            , 74, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => supplier.HomePage = __value, supplier.HomePage)), 75, () => supplier.HomePage);
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n");
            __builder.OpenComponent<MatBlazor.MatButton>(77);
            __builder.AddAttribute(78, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\DeletePages\DeleteSuppliers.razor"
                     Delete

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(79, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(80, "Delete");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(81, "\r\n");
            __builder.OpenComponent<MatBlazor.MatButton>(82);
            __builder.AddAttribute(83, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\DeletePages\DeleteSuppliers.razor"
                     Cancel

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(84, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(85, "Cancel");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\DeletePages\DeleteSuppliers.razor"
       
    Supplier supplier = new Supplier();

    [Parameter]
    public int supplierId { get; set; }


    protected override async Task OnInitializedAsync()
    {
        if(supplierId!=0)
        {
            supplier = await supplierService.GetById(supplierId);
        }

    }
    protected async Task Delete()
    {
        await supplierService.Delete(supplierId);
        navigationManager.NavigateTo("/supplier");
    }
    void Cancel()
    {
         navigationManager.NavigateTo("/supplier");
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NorthwindCrudApp.IService.ISupplierService supplierService { get; set; }
    }
}
namespace __Blazor.NorthwindCrudApp.Pages.DeletePages.DeleteSuppliers
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
        public static void CreateMatTextField_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_9<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_10<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
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
