#pragma checksum "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\EditPages\EditProducts.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bc2a1d1243059d0e3050a712c5b1c1fc83c6488"
// <auto-generated/>
#pragma warning disable 1591
namespace NorthwindCrudApp.Pages.EditPages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\_Imports.razor"
using NorthwindCrudApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\_Imports.razor"
using NorthwindCrudApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\EditPages\EditProducts.razor"
using NorthwindCrudApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editproducts/{productId:int}")]
    public partial class EditProducts : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>EditProducts</h3>\r\n");
            __builder.OpenElement(1, "p");
            __Blazor.NorthwindCrudApp.Pages.EditPages.EditProducts.TypeInference.CreateMatTextField_0(__builder, 2, 3, "Product Name", 4, 
#nullable restore
#line 8 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\EditPages\EditProducts.razor"
                                product.ProductName

#line default
#line hidden
#nullable disable
            , 5, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.ProductName = __value, product.ProductName)), 6, () => product.ProductName);
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.OpenElement(8, "p");
            __Blazor.NorthwindCrudApp.Pages.EditPages.EditProducts.TypeInference.CreateMatTextField_1(__builder, 9, 10, "Supplier ID", 11, 
#nullable restore
#line 11 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\EditPages\EditProducts.razor"
                                product.SupplierID

#line default
#line hidden
#nullable disable
            , 12, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.SupplierID = __value, product.SupplierID)), 13, () => product.SupplierID);
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.OpenElement(15, "p");
            __Blazor.NorthwindCrudApp.Pages.EditPages.EditProducts.TypeInference.CreateMatTextField_2(__builder, 16, 17, "Category ID", 18, 
#nullable restore
#line 14 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\EditPages\EditProducts.razor"
                                product.CategoryID

#line default
#line hidden
#nullable disable
            , 19, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.CategoryID = __value, product.CategoryID)), 20, () => product.CategoryID);
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
            __builder.OpenElement(22, "p");
            __Blazor.NorthwindCrudApp.Pages.EditPages.EditProducts.TypeInference.CreateMatTextField_3(__builder, 23, 24, "Quantity Per Unit", 25, 
#nullable restore
#line 17 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\EditPages\EditProducts.razor"
                                product.QuantityPerUnit

#line default
#line hidden
#nullable disable
            , 26, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.QuantityPerUnit = __value, product.QuantityPerUnit)), 27, () => product.QuantityPerUnit);
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
            __builder.OpenElement(29, "p");
            __Blazor.NorthwindCrudApp.Pages.EditPages.EditProducts.TypeInference.CreateMatTextField_4(__builder, 30, 31, "Unit Price", 32, 
#nullable restore
#line 20 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\EditPages\EditProducts.razor"
                                product.UnitPrice

#line default
#line hidden
#nullable disable
            , 33, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.UnitPrice = __value, product.UnitPrice)), 34, () => product.UnitPrice);
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
            __builder.OpenElement(36, "p");
            __Blazor.NorthwindCrudApp.Pages.EditPages.EditProducts.TypeInference.CreateMatTextField_5(__builder, 37, 38, "Units In Stock", 39, 
#nullable restore
#line 23 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\EditPages\EditProducts.razor"
                                product.UnitsInStock

#line default
#line hidden
#nullable disable
            , 40, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.UnitsInStock = __value, product.UnitsInStock)), 41, () => product.UnitsInStock);
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
            __builder.OpenElement(43, "p");
            __Blazor.NorthwindCrudApp.Pages.EditPages.EditProducts.TypeInference.CreateMatTextField_6(__builder, 44, 45, "Units In Order", 46, 
#nullable restore
#line 26 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\EditPages\EditProducts.razor"
                                product.UnitsOnOrder

#line default
#line hidden
#nullable disable
            , 47, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.UnitsOnOrder = __value, product.UnitsOnOrder)), 48, () => product.UnitsOnOrder);
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n");
            __builder.OpenElement(50, "p");
            __Blazor.NorthwindCrudApp.Pages.EditPages.EditProducts.TypeInference.CreateMatTextField_7(__builder, 51, 52, "Reorder Level", 53, 
#nullable restore
#line 29 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\EditPages\EditProducts.razor"
                                product.ReorderLevel

#line default
#line hidden
#nullable disable
            , 54, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.ReorderLevel = __value, product.ReorderLevel)), 55, () => product.ReorderLevel);
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
            __builder.OpenElement(57, "p");
            __Blazor.NorthwindCrudApp.Pages.EditPages.EditProducts.TypeInference.CreateMatTextField_8(__builder, 58, 59, "Discontinued", 60, 
#nullable restore
#line 32 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\EditPages\EditProducts.razor"
                                product.Discontinued

#line default
#line hidden
#nullable disable
            , 61, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.Discontinued = __value, product.Discontinued)), 62, () => product.Discontinued);
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n\r\n\r\n\r\n");
            __builder.OpenComponent<MatBlazor.MatButton>(64);
            __builder.AddAttribute(65, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\EditPages\EditProducts.razor"
                     Update

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(66, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(67, "Save");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(68, "\r\n");
            __builder.OpenComponent<MatBlazor.MatButton>(69);
            __builder.AddAttribute(70, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\EditPages\EditProducts.razor"
                     Cancel

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(71, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(72, "Cancel");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\EditPages\EditProducts.razor"
       
    Product product = new Product();

    [Parameter]
    public int productId { get; set; }

    protected override async Task OnInitializedAsync()
    {
        if(productId!=0)
        {
            product = await productService.GetProductById(productId);
        }
    }

    protected async Task Update()
    {
        await productService.Update(product);
        navigationManager.NavigateTo("/product");
    }
    void Cancel()
    {
        navigationManager.NavigateTo("/product");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NorthwindCrudApp.IService.IProductService productService { get; set; }
    }
}
namespace __Blazor.NorthwindCrudApp.Pages.EditPages.EditProducts
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
    }
}
#pragma warning restore 1591
