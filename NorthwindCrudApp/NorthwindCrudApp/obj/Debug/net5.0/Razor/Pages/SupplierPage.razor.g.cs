#pragma checksum "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\SupplierPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce9854f0f09a82db9ce8c3c0387570622cd63501"
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
#line 2 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\SupplierPage.razor"
using NorthwindCrudApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/suppliers")]
    public partial class SupplierPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MatBlazor.MatButton>(0);
            __builder.AddAttribute(1, "Outlined", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 4 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\SupplierPage.razor"
                     true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\SupplierPage.razor"
                                       e=>OpenDialog(false)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(4, "Add New Supplier");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __Blazor.NorthwindCrudApp.Pages.SupplierPage.TypeInference.CreateMatTable_0(__builder, 6, 7, 
#nullable restore
#line 6 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\SupplierPage.razor"
                  suppliers

#line default
#line hidden
#nullable disable
            , 8, (__builder2) => {
                __builder2.AddMarkupContent(9, "<th>SupplierID</th>\r\n        ");
                __builder2.AddMarkupContent(10, "<th>CompanyName</th>\r\n        ");
                __builder2.AddMarkupContent(11, "<th>ContactName</th>\r\n        ");
                __builder2.AddMarkupContent(12, "<th>ContactTitle</th>\r\n        ");
                __builder2.AddMarkupContent(13, "<th>Address</th>\r\n        ");
                __builder2.AddMarkupContent(14, "<th>City</th>\r\n        ");
                __builder2.AddMarkupContent(15, "<th>Region</th>\r\n        ");
                __builder2.AddMarkupContent(16, "<th>PostalCode</th>\r\n        ");
                __builder2.AddMarkupContent(17, "<th>Country</th>\r\n        ");
                __builder2.AddMarkupContent(18, "<th>Phone</th>\r\n        ");
                __builder2.AddMarkupContent(19, "<th>Fax</th>\r\n        ");
                __builder2.AddMarkupContent(20, "<th>HomePage</th>\r\n        ");
                __builder2.AddMarkupContent(21, "<th>Action</th>");
            }
            , 22, (context) => (__builder2) => {
                __builder2.OpenElement(23, "td");
#nullable restore
#line 23 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\SupplierPage.razor"
__builder2.AddContent(24, context.SupplierID);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n        ");
                __builder2.OpenElement(26, "td");
#nullable restore
#line 24 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\SupplierPage.razor"
__builder2.AddContent(27, context.CompanyName);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.OpenElement(29, "td");
#nullable restore
#line 25 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\SupplierPage.razor"
__builder2.AddContent(30, context.ContactName);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n        ");
                __builder2.OpenElement(32, "td");
#nullable restore
#line 26 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\SupplierPage.razor"
__builder2.AddContent(33, context.ContactTitle);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n        ");
                __builder2.OpenElement(35, "td");
#nullable restore
#line 27 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\SupplierPage.razor"
__builder2.AddContent(36, context.Address);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n        ");
                __builder2.OpenElement(38, "td");
#nullable restore
#line 28 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\SupplierPage.razor"
__builder2.AddContent(39, context.City);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n        ");
                __builder2.OpenElement(41, "td");
#nullable restore
#line 29 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\SupplierPage.razor"
__builder2.AddContent(42, context.Region);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n        ");
                __builder2.OpenElement(44, "td");
#nullable restore
#line 30 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\SupplierPage.razor"
__builder2.AddContent(45, context.PostalCode);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n        ");
                __builder2.OpenElement(47, "td");
#nullable restore
#line 31 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\SupplierPage.razor"
__builder2.AddContent(48, context.Country);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n        ");
                __builder2.OpenElement(50, "td");
#nullable restore
#line 32 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\SupplierPage.razor"
__builder2.AddContent(51, context.Phone);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n        ");
                __builder2.OpenElement(53, "td");
#nullable restore
#line 33 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\SupplierPage.razor"
__builder2.AddContent(54, context.Fax);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n        ");
                __builder2.OpenElement(56, "td");
#nullable restore
#line 34 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\SupplierPage.razor"
__builder2.AddContent(57, context.HomePage);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n        ");
                __builder2.OpenElement(59, "td");
                __builder2.OpenComponent<MatBlazor.MatButton>(60);
                __builder2.AddAttribute(61, "Raised", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 36 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\SupplierPage.razor"
                            true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(62, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\SupplierPage.razor"
                                              e=>OpenDialog(true)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "Icon", "edit");
                __builder2.AddAttribute(64, "title", "Edit");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(65, "\r\n         ");
                __builder2.OpenComponent<MatBlazor.MatButton>(66);
                __builder2.AddAttribute(67, "Raised", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 37 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\SupplierPage.razor"
                            true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(68, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\SupplierPage.razor"
                                              e=>OpenDialog(true)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(69, "Icon", "restore_from_trash");
                __builder2.AddAttribute(70, "title", "Delete");
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            );
            __builder.AddMarkupContent(71, "\r\n");
            __builder.OpenComponent<MatBlazor.MatDialog>(72);
            __builder.AddAttribute(73, "IsOpen", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 41 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\SupplierPage.razor"
                          dialogIsOpen

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(74, "IsOpenChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dialogIsOpen = __value, dialogIsOpen))));
            __builder.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.MatDialogTitle>(76);
                __builder2.AddAttribute(77, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(78, "Add/Edit Order Detail");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(79, "\r\n    ");
                __builder2.OpenComponent<MatBlazor.MatDialogContent>(80);
                __builder2.AddAttribute(81, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.NorthwindCrudApp.Pages.SupplierPage.TypeInference.CreateMatTextField_1(__builder3, 82, 83, "Company Name", 84, 
#nullable restore
#line 44 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\SupplierPage.razor"
                                                        supplier.CompanyName

#line default
#line hidden
#nullable disable
                    , 85, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => supplier.CompanyName = __value, supplier.CompanyName)), 86, () => supplier.CompanyName);
                    __builder3.AddMarkupContent(87, "\r\n        ");
                    __Blazor.NorthwindCrudApp.Pages.SupplierPage.TypeInference.CreateMatTextField_2(__builder3, 88, 89, "Contact Name", 90, 
#nullable restore
#line 45 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\SupplierPage.razor"
                                                         supplier.ContactName

#line default
#line hidden
#nullable disable
                    , 91, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => supplier.ContactName = __value, supplier.ContactName)), 92, () => supplier.ContactName);
                    __builder3.AddMarkupContent(93, "\r\n         ");
                    __Blazor.NorthwindCrudApp.Pages.SupplierPage.TypeInference.CreateMatTextField_3(__builder3, 94, 95, "Contact Title", 96, 
#nullable restore
#line 46 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\SupplierPage.razor"
                                                           supplier.ContactTitle

#line default
#line hidden
#nullable disable
                    , 97, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => supplier.ContactTitle = __value, supplier.ContactTitle)), 98, () => supplier.ContactTitle);
                    __builder3.AddMarkupContent(99, "\r\n          ");
                    __Blazor.NorthwindCrudApp.Pages.SupplierPage.TypeInference.CreateMatTextField_4(__builder3, 100, 101, "Address", 102, 
#nullable restore
#line 47 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\SupplierPage.razor"
                                                      supplier.Address

#line default
#line hidden
#nullable disable
                    , 103, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => supplier.Address = __value, supplier.Address)), 104, () => supplier.Address);
                    __builder3.AddMarkupContent(105, "\r\n           ");
                    __Blazor.NorthwindCrudApp.Pages.SupplierPage.TypeInference.CreateMatTextField_5(__builder3, 106, 107, "City", 108, 
#nullable restore
#line 48 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\SupplierPage.razor"
                                                    supplier.City

#line default
#line hidden
#nullable disable
                    , 109, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => supplier.City = __value, supplier.City)), 110, () => supplier.City);
                    __builder3.AddMarkupContent(111, "\r\n            ");
                    __Blazor.NorthwindCrudApp.Pages.SupplierPage.TypeInference.CreateMatTextField_6(__builder3, 112, 113, "Region", 114, 
#nullable restore
#line 49 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\SupplierPage.razor"
                                                       supplier.Region

#line default
#line hidden
#nullable disable
                    , 115, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => supplier.Region = __value, supplier.Region)), 116, () => supplier.Region);
                    __builder3.AddMarkupContent(117, "\r\n             ");
                    __Blazor.NorthwindCrudApp.Pages.SupplierPage.TypeInference.CreateMatTextField_7(__builder3, 118, 119, "Postal Code", 120, 
#nullable restore
#line 50 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\SupplierPage.razor"
                                                             supplier.PostalCode

#line default
#line hidden
#nullable disable
                    , 121, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => supplier.PostalCode = __value, supplier.PostalCode)), 122, () => supplier.PostalCode);
                    __builder3.AddMarkupContent(123, "\r\n              ");
                    __Blazor.NorthwindCrudApp.Pages.SupplierPage.TypeInference.CreateMatTextField_8(__builder3, 124, 125, "Country", 126, 
#nullable restore
#line 51 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\SupplierPage.razor"
                                                          supplier.Country

#line default
#line hidden
#nullable disable
                    , 127, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => supplier.Country = __value, supplier.Country)), 128, () => supplier.Country);
                    __builder3.AddMarkupContent(129, "\r\n               ");
                    __Blazor.NorthwindCrudApp.Pages.SupplierPage.TypeInference.CreateMatTextField_9(__builder3, 130, 131, "Phone", 132, 
#nullable restore
#line 52 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\SupplierPage.razor"
                                                         supplier.Phone

#line default
#line hidden
#nullable disable
                    , 133, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => supplier.Phone = __value, supplier.Phone)), 134, () => supplier.Phone);
                    __builder3.AddMarkupContent(135, "\r\n                ");
                    __Blazor.NorthwindCrudApp.Pages.SupplierPage.TypeInference.CreateMatTextField_10(__builder3, 136, 137, "Fax", 138, 
#nullable restore
#line 53 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\SupplierPage.razor"
                                                        supplier.Fax

#line default
#line hidden
#nullable disable
                    , 139, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => supplier.Fax = __value, supplier.Fax)), 140, () => supplier.Fax);
                    __builder3.AddMarkupContent(141, "\r\n                ");
                    __Blazor.NorthwindCrudApp.Pages.SupplierPage.TypeInference.CreateMatTextField_11(__builder3, 142, 143, "HomePage", 144, 
#nullable restore
#line 54 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\SupplierPage.razor"
                                                             supplier.HomePage

#line default
#line hidden
#nullable disable
                    , 145, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => supplier.HomePage = __value, supplier.HomePage)), 146, () => supplier.HomePage);
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(147, "\r\n    ");
                __builder2.OpenComponent<MatBlazor.MatDialogActions>(148);
                __builder2.AddAttribute(149, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MatBlazor.MatButton>(150);
                    __builder3.AddAttribute(151, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\SupplierPage.razor"
                            OkClick

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(152, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(153, "Add");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(154, "\r\n        ");
                    __builder3.OpenComponent<MatBlazor.MatButton>(155);
                    __builder3.AddAttribute(156, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\SupplierPage.razor"
                            CloseDialog

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(157, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(158, "Close");
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
#line 66 "C:\Users\User\Documents\GitHub\Northwind-Portal\NorthwindCrudApp\NorthwindCrudApp\Pages\SupplierPage.razor"
       
    private List<Supplier> suppliers = new List<Supplier>();
    Supplier supplier = new Supplier();
    bool _isEdit = false;
    bool dialogIsOpen = false;

    string Message = "";

    protected override async Task OnInitializedAsync()
    {
        GetSuppliers();

    }

    private void GetSuppliers()
    {
        suppliers = supplierService.GetSuppliers();
    }

 

    protected async Task AddSuppliers()
    {
        await supplierService.AddSupplier(supplier);
    }
   

    private void OpenDialog(bool isEdit)
    {
        _isEdit = isEdit;
        if (!_isEdit) supplier = new Supplier();
        dialogIsOpen = true;
    }

    private async void OkClick()
    {
        dialogIsOpen = false;
        if (!_isEdit) AddSuppliers();
  

    }

    private void CloseDialog()
    {
        dialogIsOpen = false;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NorthwindCrudApp.IService.ISupplierService supplierService { get; set; }
    }
}
namespace __Blazor.NorthwindCrudApp.Pages.SupplierPage
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatTable_0<TableItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TableItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment<TableItem> __arg2)
        {
        __builder.OpenComponent<global::MatBlazor.MatTable<TableItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "MatTableHeader", __arg1);
        __builder.AddAttribute(__seq2, "MatTableRow", __arg2);
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
        public static void CreateMatTextField_11<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
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
