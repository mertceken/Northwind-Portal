#pragma checksum "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\ShippersPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d975aa925c549497f950b50ac31391af6e31c3b1"
// <auto-generated/>
#pragma warning disable 1591
namespace NorthwindCrudApp.Pages
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
#line 3 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\ShippersPage.razor"
using NorthwindCrudApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/shipper")]
    public partial class ShippersPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MatBlazor.MatButton>(0);
            __builder.AddAttribute(1, "Outlined", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 4 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\ShippersPage.razor"
                     true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\ShippersPage.razor"
                                       e=>OpenDialog(false)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(4, "Add New Shipper");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.AddMarkupContent(6, "<h3>ShippersPage</h3>\r\n\r\n");
            __Blazor.NorthwindCrudApp.Pages.ShippersPage.TypeInference.CreateMatTable_0(__builder, 7, 8, 
#nullable restore
#line 7 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\ShippersPage.razor"
                  shipperList

#line default
#line hidden
#nullable disable
            , 9, "oi-elevator", 10, (__builder2) => {
                __builder2.AddMarkupContent(11, "<th>ShipperID</th>\r\n        ");
                __builder2.AddMarkupContent(12, "<th>CompanyName</th>\r\n        ");
                __builder2.AddMarkupContent(13, "<th>Phone</th>\r\n        ");
                __builder2.AddMarkupContent(14, "<th>Action</th>");
            }
            , 15, (context) => (__builder2) => {
                __builder2.OpenElement(16, "td");
#nullable restore
#line 15 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\ShippersPage.razor"
__builder2.AddContent(17, context.ShipperID);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n        ");
                __builder2.OpenElement(19, "td");
#nullable restore
#line 16 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\ShippersPage.razor"
__builder2.AddContent(20, context.CompanyName);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.OpenElement(22, "td");
#nullable restore
#line 17 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\ShippersPage.razor"
__builder2.AddContent(23, context.Phone);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n        ");
                __builder2.OpenElement(25, "td");
                __builder2.OpenComponent<MatBlazor.MatButton>(26);
                __builder2.AddAttribute(27, "Raised", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\ShippersPage.razor"
                           true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "Icon", "edit");
                __builder2.AddAttribute(29, "title", "Edit");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n        ");
                __builder2.OpenComponent<MatBlazor.MatButton>(31);
                __builder2.AddAttribute(32, "Raised", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\ShippersPage.razor"
                           true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\ShippersPage.razor"
                                             e=>OpenDialog(true)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "Icon", "restore_from_trash");
                __builder2.AddAttribute(35, "title", "Delete");
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            );
            __builder.AddMarkupContent(36, "\r\n");
            __builder.OpenComponent<MatBlazor.MatDialog>(37);
            __builder.AddAttribute(38, "IsOpen", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 24 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\ShippersPage.razor"
                          dialogIsOpen

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "IsOpenChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dialogIsOpen = __value, dialogIsOpen))));
            __builder.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.MatDialogTitle>(41);
                __builder2.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(43, "Add/Edit Shipper Detail");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\r\n    ");
                __builder2.OpenComponent<MatBlazor.MatDialogContent>(45);
                __builder2.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.NorthwindCrudApp.Pages.ShippersPage.TypeInference.CreateMatTextField_1(__builder3, 47, 48, "Company Name", 49, 
#nullable restore
#line 27 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\ShippersPage.razor"
                                                         shippers.CompanyName

#line default
#line hidden
#nullable disable
                    , 50, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => shippers.CompanyName = __value, shippers.CompanyName)), 51, () => shippers.CompanyName);
                    __builder3.AddMarkupContent(52, "\r\n        ");
                    __Blazor.NorthwindCrudApp.Pages.ShippersPage.TypeInference.CreateMatTextField_2(__builder3, 53, 54, "Phone", 55, 
#nullable restore
#line 28 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\ShippersPage.razor"
                                                  shippers.Phone

#line default
#line hidden
#nullable disable
                    , 56, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => shippers.Phone = __value, shippers.Phone)), 57, () => shippers.Phone);
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(58, "\r\n    ");
                __builder2.OpenComponent<MatBlazor.MatDialogActions>(59);
                __builder2.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MatBlazor.MatButton>(61);
                    __builder3.AddAttribute(62, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\ShippersPage.razor"
                            OkClick

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(64, "Add");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(65, "\r\n        ");
                    __builder3.OpenComponent<MatBlazor.MatButton>(66);
                    __builder3.AddAttribute(67, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\ShippersPage.razor"
                            CloseDialog

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(68, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(69, "Close");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\ShippersPage.razor"
       
    private List<Shippers> shipperList = new List<Shippers>();

    Shippers shippers = new Shippers();

   

    bool _isEdit = false;
    bool dialogIsOpen = false;

    protected override async Task OnInitializedAsync()
    {
        GetShippers();
    }
    private void GetShippers()
    {
        shipperList = shipperService.GetShippers();
    }
    
    protected async Task AddShippers()
    {
        await shipperService.AddShipper(shippers);
        GetShippers();

    }
    private void OkClick()
    {
        dialogIsOpen = false;
        if (!_isEdit) AddShippers();
    }

    private void OpenDialog(bool isEdit)
    {
        _isEdit = isEdit;
        if (!_isEdit) shippers = new Shippers();
        dialogIsOpen = true;

    }

    private void CloseDialog()
    {
        dialogIsOpen = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NorthwindCrudApp.IService.IShipperService shipperService { get; set; }
    }
}
namespace __Blazor.NorthwindCrudApp.Pages.ShippersPage
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatTable_0<TableItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TableItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment<TableItem> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTable<TableItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "Class", __arg1);
        __builder.AddAttribute(__seq2, "MatTableHeader", __arg2);
        __builder.AddAttribute(__seq3, "MatTableRow", __arg3);
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
    }
}
#pragma warning restore 1591
